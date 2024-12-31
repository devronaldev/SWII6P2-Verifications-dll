using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWII6P2Verifications
{
    public static class Verifications
    {
        public static bool IsProductFull(string name, double price)
        {
            if (string.IsNullOrEmpty(name))
            {
                return false;
            }

            if (price == 0)
            {
                return false;
            }

            return true;
        }

        public static bool IsUserFull(string name, string password)
        {
            if (string.IsNullOrEmpty(name))
            {
                return false;
            }
            if (string.IsNullOrEmpty(password))
            {
                return false;
            }
            return true;
        }
    }
}
