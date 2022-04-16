using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace OGF_tool
{
    public enum THM
    {
         THM_CHUNK_VERSION = 0x0810,
         THM_CHUNK_DATA = 0x0811,
         THM_CHUNK_TEXTUREPARAM = 0x0812,
         THM_CHUNK_TYPE = 0x0813,
         THM_CHUNK_TEXTURE_TYPE = 0x0814,
         THM_CHUNK_DETAIL_EXT = 0x0815,
         THM_CHUNK_MATERIAL = 0x0816,
         THM_CHUNK_BUMP = 0x0817,
         THM_CHUNK_EXT_NORMALMAP = 0x0818,
         THM_CHUNK_FADE_DELAY = 0x0819,
         THM_CHUNK_SHADING_MODEL = 0x0820,
         THM_CHUNK_REFLECTION_FACTOR = 0x0821,
         THM_CHUNK_BUMP_VERSION = 0x0822,
    };

    public class XRayLoader
    {
        public long chunk_pos = 0;

        uint CHUNK_COMPRESSED = 0x80000000;

        public MemoryStream mem_stream;
        public BinaryReader reader;


        public void Destroy()
        {
            mem_stream.Dispose();
            reader.Dispose();
        }

        public byte ReadByte()
        {
            return reader.ReadByte();
        }

        public int ReadInt32()
        {
            return reader.ReadInt32();
        }

        public float ReadFloat()
        {
            return reader.ReadSingle();
        }

        public uint ReadUInt32()
        {
            return reader.ReadUInt32();
        }

        public byte[] ReadBytes(int count)
        {
            return reader.ReadBytes(count);
        }

        public bool SetData(byte[] input)
        {
            if (input == null) return false;
            mem_stream = new MemoryStream(input);
            reader = new BinaryReader(mem_stream);
            return true;
        }

        public void SetStream(Stream stream)
        {
            reader = new BinaryReader(stream);
        }

        public void SetReader(BinaryReader rd)
        {
            reader = rd;
        }

        public bool find_chunk(int chunkId, bool skip = false, bool reset = false)
        {
            return find_chunkSize(chunkId, skip, reset) != 0;
        }

        public byte[] find_and_return_chunk_in_chunk(int chunkId, bool skip = false, bool reset = false)
        {
            int size = (int)find_chunkSize(chunkId, skip, reset);

            if (size > 0)
            {
                return ReadBytes(size);
            }
            else
                return null;
        }

        public uint find_chunkSize(int chunkId, bool skip = false, bool reset = false)
        {
            chunk_pos = 0;

            if (reset) reader.BaseStream.Position = 0;

            while (reader.BaseStream.Position < reader.BaseStream.Length)
            {
                if (reader.BaseStream.Position + 8 > reader.BaseStream.Length)
                    return 0;

                uint dwType = reader.ReadUInt32();
                uint dwSize = reader.ReadUInt32();

                if (dwType == chunkId || (dwType ^ CHUNK_COMPRESSED) == chunkId)
                {
                    chunk_pos = reader.BaseStream.Position - 8;
                    return dwSize;
                }
                else
                {
                    if (reader.BaseStream.Position + dwSize < reader.BaseStream.Length)
                        reader.BaseStream.Position += dwSize;
                    else if (reader.BaseStream.Position + 8 < reader.BaseStream.Length)
                        reader.BaseStream.Position += 4;
                    else
                        return 0;
                }
            }

            return 0;
        }

        public void open_chunk(BinaryWriter w, int chunkId)
        {
            w.Write(chunkId);
            chunk_pos = w.BaseStream.Position;
            w.Write(0);     // the place for 'size'
        }

        public void close_chunk(BinaryWriter w)
        {
            if (chunk_pos == 0)
            {
                throw new InvalidOperationException("no chunk!");
            }

            long pos = w.BaseStream.Position;
            w.BaseStream.Position = chunk_pos;
            w.Write((int)(pos - chunk_pos - 4));
            w.BaseStream.Position = pos;
            chunk_pos = 0;
        }

        public string read_stringZ()
        {
            List<char> str = new List<char>();

            while (reader.BaseStream.Position < reader.BaseStream.Length)
            {
                byte one = reader.ReadByte();
                if (one != 0)
                {
                    str.Add((char)one);
                }
                else
                {
                    break;
                }
            }

            return new string(str.ToArray());
        }

        public void write_stringZ(BinaryWriter w, string str)
        {
            foreach (char c in str)
            {
                byte b = (byte)c;
                w.Write(b);
            }

            w.Write((byte)0);
        }
    }

    public class OGF_Children
    {
        public List<OGF_Child> childs = new List<OGF_Child>();

        public uint chunk_size;

        public long pos;

        public MotionRefs refs = new MotionRefs();

        public UserData usertdata = null;

        public BoneData bones = new BoneData();

        public OGF_Children()
        {
            refs.pos = -1;
        }

    }

    public struct MotionRefs
    {
        public long pos;
        public List<string> refs0;
        public uint chunk_size()
        {
            uint temp = 4;
            foreach (var text in refs0)
                temp += (uint)text.Length + 1;
            return temp;
        }
        public byte[] count()
        {
            return BitConverter.GetBytes(refs0.Count);
        }
        public byte[] data()
        {
            List<byte> temp = new List<byte>();

            foreach (var str in refs0)
            {
                temp.AddRange(Encoding.ASCII.GetBytes(str));
                temp.Add(0);
            }

            return temp.ToArray();
        }
    }

    public class UserData
    {
        public long pos;
        public string data;

        public uint old_size;

        public UserData()
        {
            this.pos = 0;
            this.data = "";
            this.old_size = 0;
        }

        public byte[] data_all()
        {
            List<byte> temp = new List<byte>();

            temp.AddRange(Encoding.ASCII.GetBytes(data));
            temp.Add(0);

            return temp.ToArray();
        }

        public uint chunk_size()
        {
            return (uint)data.Length +1;
        }

        public uint NewSize()
        {
            return chunk_size() - old_size;
        }
    }

    public struct BoneData
    {
        public long pos;
        public List<string> bones;
        public List<string> parent_bones;
        public List<string> materials;
        public List<float>  mass;
        public uint chunk_size()
        {
            uint temp = 4;                                  // count byte

            for (int i = 0; i < bones.Count; i++)
            {
                temp += (uint)bones[i].Length + 1;          // bone name
                temp += (uint)parent_bones[i].Length + 1;   // parent bone name
                temp += 60;                                 // obb
            }

            return temp;
        }
        public byte[] count()
        {
            return BitConverter.GetBytes(bones.Count);
        }
        public byte[] data()
        {
            List<byte> temp = new List<byte>();

            for (int i = 0; i < bones.Count; i++)
            {
                temp.AddRange(Encoding.ASCII.GetBytes(bones[i]));       // bone name
                temp.AddRange(Encoding.ASCII.GetBytes(parent_bones[i]));// parent bone name
                temp.Add(60);                                           // obb
                temp.Add(0);
            }

            return temp.ToArray();
        }
    }

    public class OGF_Child
    {
        public string m_texture;

        public string m_shader;

        public OGF_Child(long _pos, int _parent_id, long _parent_pos, int _old_size, string texture, string shader)
        {
            pos = _pos;
            parent_id = _parent_id;
            parent_pos = _parent_pos;
            m_texture = texture;
            m_shader = shader;
            old_size = _old_size;
        }

        public long pos;

        public long parent_pos;
        public int parent_id;

        public int old_size;

        public uint NewSize()
        {
            return (uint)(m_texture.Length + m_shader.Length + 2 - old_size);
        }

        public byte[] data()
        {
            List<byte> temp = new List<byte>();

            temp.AddRange(BitConverter.GetBytes(2));
            temp.AddRange(BitConverter.GetBytes(m_texture.Length + m_shader.Length + 2));

            foreach (char c in m_texture)
            {
                byte b = (byte)c;
                temp.Add(b);
            }

            temp.Add(0);

            foreach (char c in m_shader)
            {
                byte b = (byte)c;
                temp.Add(b);
            }

            temp.Add(0);

            return temp.ToArray();

        }
    }
}
