using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    [Serializable]
    public class Mago : Heroe
    {
        public Mago(int Vida, int Mana, string Nombre, int Conteodemana, int Armadura, int Ataque, int Durabilidad, int HabilidadFindeTurno)
            : base(Vida, Mana, Nombre, Conteodemana, Armadura, Ataque, Durabilidad, HabilidadFindeTurno)
        {

        }
        public  void elegircarta(int C2, Heroe H)
        {

            //= Convert.ToInt32(Cart2);
            if (C2 != -1)
            {
                H.Tablero1[C2].Vida -= 1;
            }
            else { H.Vida -= 1; }
        }


        public override void Habilidad(Heroe H)
        {
            if (Mana >= 2)
            {                //foreach (Minions c in H.Tablero1)
                             //{
                             //Console.WriteLine("Nombre: " + c.Coste + " Daño: " + c.Daño + " Vida: " + c.Vida);
                             //}
                             //Console.WriteLine("Elige carta  Atacada en tablero opuesto (numero de la posicion de la carta[0,1,2..]), -1 Atacar Heroe.");
                             //string Cart2;
                             //Cart2 = Console.ReadLine();

            }
            else
            {
                int C2 = 10;
                elegircarta(C2,H);  }
            //{
              //  Console.WriteLine("No tienes Suficiente Mana");
            //}
        }
    }
}
