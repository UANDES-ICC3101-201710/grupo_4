using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    [Serializable]
    public class Hechizo : Cartas
    {
        public Hechizo(string Clase, int Coste, string NombreCarta)
            : base(Clase, Coste, NombreCarta)
        {
        }
    }
}
