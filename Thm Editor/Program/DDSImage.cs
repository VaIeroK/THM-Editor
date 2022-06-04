using System;

namespace DDSReader
{
	public class DDSImage
	{
		public Pfim.IImage _image;

		public DDSImage(string file)
		{
			_image = Pfim.Pfim.FromFile(file);
			Process();
		}

		private void Process()
		{
			if (_image == null)
				throw new Exception("DDSImage image creation failed");
			_image.Decompress();
		}
	}
}
