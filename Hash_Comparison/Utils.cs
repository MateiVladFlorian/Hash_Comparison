using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Comparison
{
    public class Utils
    {
        static string filePath = string.Empty;
        static string hash = string.Empty;
        static int status = 0;

        public static void setFile(string path) => filePath = path;
        public static string getPath() => filePath;

        public static void setHash(string fileHash) => hash = fileHash;
        public static string getHash() => hash;

        public static void setStatus(int statusCode) => status = statusCode;
        public static int getStatus() => status;
    }
}
