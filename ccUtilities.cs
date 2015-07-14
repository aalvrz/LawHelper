using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace sistemaBufetes
{
    public class ccUtilities
    {
        public static string GetMD5Hash(string input)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider x = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] bs = System.Text.Encoding.UTF8.GetBytes(input);
            bs = x.ComputeHash(bs);
            System.Text.StringBuilder s = new System.Text.StringBuilder();
            foreach (byte b in bs)
            {
                s.Append(b.ToString("x2").ToLower());
            }
            string password = s.ToString();
            return password;
        }

        public static string ResolveRelativePath(string referencePath, string relativePath)
        {
            
            return Path.GetFullPath(Path.Combine(referencePath, relativePath));
        } 

 

    }
}
