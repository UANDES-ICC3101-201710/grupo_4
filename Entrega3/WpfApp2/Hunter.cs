using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{ [Serializable]
    public class Hunter : Heroe
    {

        public Hunter(int Vida, int Mana, string Nombre, int Conteodemana, int Armadura, int Ataque, int Durabilidad, int HabilidadFindeTurno)
            : base(Vida, Mana, Nombre, Conteodemana, Armadura, Ataque, Durabilidad, HabilidadFindeTurno)
        {

        }
        public override void Habilidad(Heroe Here)
        {
            if (Mana >= 2)
            {
                Here.Vida -= 2;
                Mana -= 2;
            }
           // else
            //{
              //  Console.WriteLine("No tienes Suficiente Mana");
            //}
        }
    }
}
