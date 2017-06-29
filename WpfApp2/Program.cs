using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace WpfApp2
{
    class Program
    {
        public int QuienParte(Heroe h1, Heroe h2, Mazo m1, Mazo m2)
        {
            Random random = new Random();
            int rndnumber = random.Next(0, 2);

            if (rndnumber == 0)
            {
                h1.Robar(m1.mazo1, h1.mano);
                h1.Robar(m1.mazo1, h1.mano);
                h1.Robar(m1.mazo1, h1.mano);

                h2.Robar(m2.mazo1, h2.mano);
                h2.Robar(m2.mazo1, h2.mano);
                h2.Robar(m2.mazo1, h2.mano);
                h2.Robar(m2.mazo1, h2.mano);
            }
            else
            {
                h1.Robar(m1.mazo1, h1.mano);
                h1.Robar(m1.mazo1, h1.mano);
                h1.Robar(m1.mazo1, h1.mano);

                h2.Robar(m2.mazo1, h2.mano);
                h2.Robar(m2.mazo1, h2.mano);
                h2.Robar(m2.mazo1, h2.mano);
                h2.Robar(m2.mazo1, h2.mano);  
            }
            return rndnumber;
        }

        public void CantidadCartasEnTablero(List<Cartas> CartasenTablero)
        {
            int cant;
            cant = CartasenTablero.Count();
            if (cant > 10) { }
            
        }

        public void Guardar(Stream stream, BinaryFormatter bf,object obj)
        {
            bf.Serialize(stream, obj);

        }

    }
}
