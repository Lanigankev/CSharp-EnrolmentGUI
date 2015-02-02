using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace CollegeGUIapp
{
    class Hashcode
    {
        public string PassHash(string data)
        {

            SHA1 sha = SHA1.Create();
            byte[] hashdata = sha.ComputeHash(Encoding.Default.GetBytes(data));
            StringBuilder returnValue = new StringBuilder();

            for (int inst = 0; inst < hashdata.Length; inst++)
            {
                returnValue.Append(hashdata[inst].ToString());
            }
            return returnValue.ToString();
        }
    }
}
