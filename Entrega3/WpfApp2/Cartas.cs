using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    [Serializable]
    public class Cartas 
    {
        public string Clase;
        public int Coste;
        public string NombreCarta;

        public Cartas(string Clase, int Coste, string NombreCarta)
        {
            this.Clase = Clase;
            this.Coste = Coste;
            this.NombreCarta = NombreCarta;
        }



    }
}
