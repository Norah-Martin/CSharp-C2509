using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Assignment14
{
    public class FileHelper
    {
        public bool IsValidFile(string filePath)
        {

            FileInfo fileInfo = new FileInfo(filePath);
            return fileInfo.Exists && fileInfo.Length < 1024 * 1024; // 1 MB
        }
    }
}
