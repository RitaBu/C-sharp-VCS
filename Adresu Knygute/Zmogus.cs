using System;
namespace AdresuKnygute
{
    public class Zmogus
    {
        public string Vardas { get; set; }
        public string Pavarde { get; set; }
        public string Telefonas { get; set; }

        public Zmogus(string vardas, string telefonas)
        {
            Vardas = vardas;
            Telefonas = telefonas;
        }

        public Zmogus(string vardas, string pavarde, string telefonas)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            Telefonas = telefonas;
        }

        public string GrazinkInformacija() 
        {
           return $"{Vardas} {Pavarde} {Telefonas}";
        }
    }
}
