using System.IO;

namespace System.Speech.Internal.Synthesis
{
	internal class AudioData : IDisposable
	{
		internal Uri _uri;

		internal string _mimeType;

		internal Stream _stream;

		private string _localFile;

		private ResourceLoader _resourceLoader;

		internal AudioData(Uri uri, ResourceLoader resourceLoader)
		{
			_uri = uri;
			_resourceLoader = resourceLoader;
			Uri baseUri;
			_stream = _resourceLoader.LoadFile(uri, out _mimeType, out baseUri, out _localFile);
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		~AudioData()
		{
			Dispose(false);
		}

		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (_localFile != null)
				{
					_resourceLoader.UnloadFile(_localFile);
				}
				if (_stream != null)
				{
					_stream.Dispose();
					_stream = null;
					_localFile = null;
					_uri = null;
				}
			}
		}
	}
}
