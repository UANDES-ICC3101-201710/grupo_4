using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    public class Minions : Cartas
    {
        private string Raza;
        public int Vida;
        public int Daño;
        public int TurnoP;
        public int NDT;

        public Minions(string Clase, int Coste, string NombreCarta, string Raza, int Vida, int Daño, int TurnoP, int NDT)
            : base(Clase, Coste, NombreCarta)
        {
            this.Raza = Raza;
            this.Vida = Vida;
            this.Daño = Daño;
        }

        public void RestarVidaMs(Minions MiJ1, Minions MiJ2, List<Minions> TJ1, List<Minions> TJ2)
        {
            MiJ1.Vida -= MiJ2.Daño;
            MiJ2.Vida -= MiJ1.Daño;
            if (MiJ1.Vida <= 0)
            { TJ1.Remove(MiJ1); }
            if (MiJ2.Vida <= 0)
            { TJ2.Remove(MiJ2); }
        }
        public void RestarVidaHs(Heroe H, Minions M)
        {
            if (H.Armadura <= M.Daño)
            {
                H.Vida -= M.Daño - H.Armadura;
                H.Armadura = 0;
            }
            else
            {
                H.Armadura -= M.Daño;
            }
            if (H.Vida <= 0)
            { H.Morir(); }
        }




    }
}
