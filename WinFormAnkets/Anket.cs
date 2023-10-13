using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormAnkets
{
    public class Anket
    {
        public string FailName { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public string Dogumili { get; set; }
        public Anket(string failname,string ad, string soyad, string email, string tel, string dogumili)
        {
            FailName = failname;
            Ad = ad;
            Soyad = soyad;
            Email = email;
            Tel = tel;
            Dogumili = dogumili;
        }
    }
}
