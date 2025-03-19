using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncBasicThread.Utils
{
    class ConvertUtils
    {
        public static string AutoConvertBytes (decimal bytes, int decimalPlaces = 2)
        {
            string[] sizes = { "B", "KB", "MB", "GB", "TB" };
            int order = 0;
            while (bytes >= 1024 && order < sizes.Length - 1)
            {
                order++;
                bytes = bytes / 1024;
            }

            string _result = $"{Math.Round(bytes, decimalPlaces)} {sizes[order]}";
            return _result;
        }
    }
}
