using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    public class Usuario
    {
        public int Ranking;
        public int IdUsuario;
        public string nombre;

        public Usuario(int IdUsuario, int Ranking,string nombre)
        {
            this.Ranking = Ranking;
            this.IdUsuario = IdUsuario;
            this.nombre = nombre;
        }
    }
}
