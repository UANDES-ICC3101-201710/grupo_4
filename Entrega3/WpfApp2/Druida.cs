using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    [Serializable]
    public class Druida : Heroe
    {
        public Druida(int Vida, int Mana, string Nombre, int Conteodemana, int Armadura, int Ataque, int Durabilidad, int HabilidadFindeTurno)
            : base(Vida, Mana, Nombre, Conteodemana, Armadura, Ataque, Durabilidad, HabilidadFindeTurno)
        {

        }
        public override void Habilidad(Heroe H)
        {
            if (Mana >= 2)
            {
                Ataque += 1;
                Armadura += 1;
                HabilidadFindeTurno += 1;
                Mana -= 2;

            }
        }
    }
}
