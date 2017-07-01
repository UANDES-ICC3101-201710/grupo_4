using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    [Serializable]
    public class Mazo
    {
        public List<Minions> mazo1 = new List<Minions>();
        public void AgregarCarta(Minions carta)
        {
            mazo1.Add(carta);
        }
        public void shuffle()
        {
            List<Minions> mazorevuelto = new List<Minions>();
            Random rnd = new Random();
            int indice = 0;
            while (mazo1.Count > 0)
            {
                indice = rnd.Next(0, mazo1.Count);
                mazorevuelto.Add(mazo1[indice]);
                mazo1.RemoveAt(indice);
            }
            this.mazo1 = mazorevuelto;
        }




    }
}
