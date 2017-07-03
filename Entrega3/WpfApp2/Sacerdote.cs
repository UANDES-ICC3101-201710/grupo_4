using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    [Serializable]
    public class Sacerdote : Heroe
    {
        public Sacerdote(int Vida, int Mana, string Nombre, int Conteodemana, int Armadura, int Ataque, int Durabilidad, int HabilidadFindeTurno)
            : base(Vida, Mana, Nombre, Conteodemana, Armadura, Ataque, Durabilidad, HabilidadFindeTurno)
        {

        }
        public override void Habilidad(Heroe H)
        {
            if (Mana >= 2)
            {
                foreach (Minions i in Tablero1)
                {
                    if (i.Seleccionada == 1)
                    {
                        i.Vida += 1;
                    }
                }
                Mana -= 2;
            }
        }
              
            public void elegircarta1(int C2, Heroe H)
                {
                    if (C2 != -1)
                    {
                        H.Tablero1[C2].Vida += 2;
                    }
                    else { H.Vida += 2; }
                }
    }
            
}


