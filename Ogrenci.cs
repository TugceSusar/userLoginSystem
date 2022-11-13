namespace örnek_uygulama
{
    internal class Ogrenci : Insan
    {
        private string okul;
        private int sinif;
        private string bolum;
        private int okulNo;
        private string username;
        private string password;

        public string Okul
        {
            get { return okul; }
            set
            {
                okul = value;
            }
        }
        public int Sinif
        {
            get { return sinif; }
            set
            {
                sinif = value;
            }
        }
        public string Bolum
        {
            get { return bolum; }
            set
            {
                bolum = value;
            }
        }
        public int OkulNo
        {
            get { return okulNo; }
            set
            {
                okulNo = value;
            }
        }
        public string Username
        {
            get { return username; }
            set
            {
                username = value;
            }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }


}
