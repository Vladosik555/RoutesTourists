using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    }
}
