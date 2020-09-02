using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Festo_Rubik_s_Cube_Explorer
{
    public static class UserLogin
    {
        private static bool _isLoggedIn = false;
        private static string iniPath = "config.ini";

        public static bool IsLoggedIn
        {
            get
            {
                return _isLoggedIn;
            }
            set
            {
                _isLoggedIn = value;
            }
        }

        public static string Hash(string input)
        {
            // http://stackoverflow.com/questions/17292366/hashing-with-sha1-algorithm-in-c-sharp
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("X2"));
                }
                return sb.ToString();
            }
        }

        [Obsolete("this decode method is not use any more.")]
        private static string decodePassword(string s)
        {
            var bytes = Convert.FromBase64String(new string(s.Replace("$", "=").Reverse().ToArray()));
            return Encoding.UTF8.GetString(bytes);
        }

        private static string encodePassword(string s)
        {
            return Hash(s);

            //var b64string = Convert.ToBase64String(Encoding.UTF8.GetBytes(s));
            //return new string(b64string.Replace("=", "$").Reverse().ToArray());
        }

        public static string Password
        {
            get
            {
                if (File.Exists(iniPath))
                {
                    IniFile ini = new IniFile(iniPath);
                    if (!ini.KeyExists("password", "authorization"))
                    {
                        return null;
                    }
                    string pwd = ini.Read("password", "authorization");
                    try
                    {
                        //return decodePassword(pwd);
                        return pwd;
                    }
                    catch (Exception)
                    {
                        return null;
                    }

                }
                return null;
            }
            set
            {
                if (value.Length > 100) // too long
                {
                    return;
                }
                else
                {
                    var encodedPwd = encodePassword(value);
                    if (File.Exists(iniPath))
                    {
                        IniFile ini = new IniFile(iniPath);
                        ini.Write("password", encodedPwd, "authorization");
                    }

                }
            }

        }
    }
}
