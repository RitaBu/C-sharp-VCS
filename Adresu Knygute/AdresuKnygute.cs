using System;
using System.Collections.Generic;

namespace AdresuKnygute
{
    public class AdresuKnygute
    {
        private List<Zmogus> _zmones = new List<Zmogus>();

        public int Ilgis 
        {
            get { return _zmones.Count; }
        }

        public AdresuKnygute(string path)
        {
           
        }

        public void Atspausdink() 
        {
            for (int i = 0; i < Ilgis; i++)
            {
                Console.WriteLine($"{i+1}. {_zmones[i].GrazinkInformacija()}");
            }
        }
    }
}
