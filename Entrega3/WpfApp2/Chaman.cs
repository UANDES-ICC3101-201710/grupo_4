using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    [Serializable]
    public class Chaman : Heroe
    {
        public Chaman(int Vida, int Mana, string Nombre, int Conteodemana, int Armadura, int Ataque, int Durabilidad, int HabilidadFindeTurno)
            : base(Vida, Mana, Nombre, Conteodemana, Armadura, Ataque, Durabilidad, HabilidadFindeTurno)
        {

        }
        public override void Habilidad(Heroe H)
        {
            if (Mana >= 2)
            {
                Random r = new Random();
                int ra = r.Next(0, 5);
                Tablero1.Add(Miespeciales[ra]);
                
            }
           

        }
    }
}
