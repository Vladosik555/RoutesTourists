using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoutesTourists.Classes
{
    public class MailList
    {
        private List<string> AllMail = new List<string>()
        {
        "@yandex.ru",
        "@yandex.com",
        "@mail.ru",
        "@mail.com",
        "@inbox.ru",
        "@inbox.com",
        "@bk.ru",
        "@bk.com",
        "@hotmail.com",
        "@hotmail.ru",
        "@live.com",
        "@live.ru",
        "@furmail.ru",
        "@furmail.com",
        "@list.ru",
        "@list.com",
        "@email.ru",
        "@email.com"
        };
        public List<string> getMail()
        {
            return AllMail;
        }
    }
}
