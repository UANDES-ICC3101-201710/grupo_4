using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    public class Arma : Cartas
    {
        public int Duracion;
        public int Ataque;

        public Arma(string Clase, int Coste, string NombreCarta, int Duracion, int Ataque)
            : base(Clase, Coste, NombreCarta)
        {
            this.Duracion = Duracion;
            this.Ataque = Ataque;

        }
    }
}
