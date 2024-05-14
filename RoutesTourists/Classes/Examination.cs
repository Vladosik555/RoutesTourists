using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RoutesTourists.Classes
{
    public static class Examination
    {
        public static bool CheckLetter(string letters)
        {
            foreach (char letter in letters)
            {
                if (!Char.IsLetter(letter))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool CheckNumber(string numbers)
        {
            foreach (char number in numbers)
            {
                if (!Char.IsNumber(number))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool CheckFormatMail(string mail)
        {
            MailList emailList = new MailList();
            foreach (string email in emailList.getMail())
            {
                if (mail.EndsWith(email))
                {
                    return true;
                }
            }
            return false;
        }
        public static string GetAllNumber(string input)
        {
            if(input != null)
            {
                MatchCollection matches = Regex.Matches(input, @"\d+");
                StringBuilder result = new StringBuilder();
                foreach (Match match in matches)
                {
                    result.Append(match.Value).Append(" ");
                }
                return result.ToString().Trim();
            }
            return null;
        }

        public static bool CheckPhoneNumber(string numbers)
        {
            if (!numbers.StartsWith("+7") && !numbers.StartsWith("8"))
            {
                return false;
            }
            if ((numbers.StartsWith("+7") && numbers.Length == 12) || (numbers.StartsWith("8") && numbers.Length == 11))
            {
                if (Char.IsNumber(numbers[0]) || numbers[0] == '+')
                {
                    for (int i = 1; i < numbers.Length; i++)
                    {
                        if (!Char.IsNumber(numbers[i]))
                        {
                            return false;
                        }
                    }
                    return true;
                }
            }
            return false;
        }
    }
}
