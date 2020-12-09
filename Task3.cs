
using System.Text.RegularExpressions;

namespace Day3_HW
{
    class Task3
    {
        public static bool CheckEmail(string Email)
        {
            string Pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            return Regex.IsMatch(Email, Pattern);
        }

        public static bool CheckIP(string IP)
        {
            string Pattern = @"\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b";
            return Regex.IsMatch(IP, Pattern);
        }

    }
}
