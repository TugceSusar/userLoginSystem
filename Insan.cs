using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek_uygulama
{
    internal class Insan
    {
        private string ad;
        private string soyad;
        private ulong tc;
        private char cinsiyet;
        private byte yas;                            //yer kaplamaması için
        private bool calismaDurumu;

        public string Ad
        {
            get { return ad; }
            set
            {
                string toTitleCase = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value);
                ad = toTitleCase;
            }
        }
       
        public string Soyad
        {
            get { return soyad; }
            set { soyad = value.ToUpper(); }
        }

        public ulong Tc
        {
            get { return tc;}
            set
            {
                if ((value.ToString()).Length == 11)
                {
                    tc = value;
                }
            }
        }
        public char Cinsiyet
        {
            get { return cinsiyet; }
            set { cinsiyet = value; }
            
        }
        public byte Yas
        {
            get { return yas;}
            set { yas = value; }
        }
        public bool CalismaDurumu
        {
            get { return calismaDurumu; }
            set
            {
                calismaDurumu = value;
            }
        }
    }
}
