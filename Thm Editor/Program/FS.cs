using System;
using System.IO;

namespace ThmEditor
{
    public partial class IReader : IDisposable
    {
        private uint CHUNK_COMPRESSED = 0x80000000;
        private long m_last_pos = 0;
        private BinaryReader reader;

        public void Dispose()
        {
            reader.Dispose();
        }

        public IReader(BinaryReader r)
        {
            reader = r;
        }

        public uint find_chunk(int chunkId, bool reset = true)
        {
            if (reset) reader.BaseStream.Position = 0;

            while (reader.BaseStream.Position < reader.BaseStream.Length)
            {
                if (reader.BaseStream.Position + 8 > reader.BaseStream.Length)
                    return 0;

                uint dwType = reader.ReadUInt32();
                uint dwSize = reader.ReadUInt32();

                if (dwType == chunkId || (dwType ^ CHUNK_COMPRESSED) == chunkId)
                {
                    m_last_pos = reader.BaseStream.Position - 8;
                    return dwSize;
                }
                else
                {
                    if (reader.BaseStream.Position + dwSize < reader.BaseStream.Length)
                        reader.BaseStream.Position += dwSize;
                    else if (reader.BaseStream.Position + 8 < reader.BaseStream.Length)
                        reader.BaseStream.Position += 4;
                }
            }

            return 0;
        }

        public bool r_bool()
        {
            return r_u8() == 1;
        }
        public byte r_u8()
        {
            return reader.ReadByte();
        }
        public ushort r_u16()
        {
            return reader.ReadUInt16();
        }
        public uint r_u32()
        {
            return reader.ReadUInt32();
        }
        public float r_float()
        {
            return reader.ReadSingle();
        }
        public string r_stringZ()
        {
            string str = "";

            while (true)
            {
                byte b;

                b = reader.ReadByte();

                if (b == 0)
                {
                    return str;
                }
                else
                {
                    str += Convert.ToChar(b).ToString();
                }
            }
        }
    }
    public partial class IWriter : IDisposable
    {
        private long chunk_pos = 0;
        private BinaryWriter writer;

        public void Dispose()
        {
            writer.Dispose();
        }

        public IWriter(BinaryWriter w)
        {
            writer = w;
        }

        public void open_chunk(int chunkId)
        {
            writer.Write(chunkId);
            chunk_pos = writer.BaseStream.Position;
            writer.Write((uint)0);     // the place for 'size'
        }
        public void close_chunk()
        {
            if (chunk_pos == 0)
            {
                throw new InvalidOperationException("no chunk!");
            }

            long pos = writer.BaseStream.Position;
            writer.BaseStream.Position = chunk_pos;
            writer.Write((int)(pos - chunk_pos - 4));
            writer.BaseStream.Position = pos;
            chunk_pos = 0;
        }

        public void w_bool(bool write)
        {
            w_u8(write ? (byte)1 : (byte)0);
        }
        public void w_u8(byte write)
        {
            writer.Write(write);
        }
        public void w_u16(ushort write)
        {
            writer.Write(write);
        }
        public void w_u32(uint write)
        {
            writer.Write(write);
        }
        public void w_float(float write)
        {
            writer.Write(write);
        }
        public void w_stringZ(string text)
        {
            char[] temp = text.ToCharArray();
            byte[] array = Array.ConvertAll(temp, q => Convert.ToByte(q));

            writer.Write(array);
            writer.Write((byte)0);
        }
    }
}