using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncBasicThread.Utils
{
    public delegate void FileProgressDelegate(string currentUnits, string totalUnits, int percentage);
    class FileUtils
    {
        public static void Copy(string sourceFile, string destFile, FileProgressDelegate? fileProgresss = null)
        {
            using (FileStream _sourceStream = new(sourceFile, FileMode.Open))
            using (FileStream _destStream = new(destFile, FileMode.Create))
            {
                long _fileSize = _sourceStream.Length;

                long _bufferSize = 1024 * 1024;
                byte[] _buffer = new byte[_bufferSize];

                int _read;
                decimal _totalRead = 0;

                while ((_read = _sourceStream.Read(_buffer, 0, _buffer.Length)) > 0)
                {
                    _destStream.Write(_buffer, 0, _read);
                    _totalRead += _read;

                    if (fileProgresss != null)
                    {
                        var _currentUnits = ConvertUtils.AutoConvertBytes(_totalRead);
                        var _totalUnits = ConvertUtils.AutoConvertBytes(_fileSize);
                        int _percentage = (int)((_totalRead / _fileSize) * 100);
                        fileProgresss.Invoke(_currentUnits, _totalUnits, _percentage);
                    }
                }
            }
        }
    }
}
