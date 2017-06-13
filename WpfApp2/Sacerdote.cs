using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
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
                //foreach (Minions c in Tablero1)
                //{
                //  Console.WriteLine("Nombre: " + c.Coste + " Daño: " + c.Daño + " Vida: " + c.Vida);
                //}
                //Console.WriteLine("Elige carta para Curar tablero  (numero de la posicion de la carta[0,1,2..]), -1 Curar Heroe.");
                //string Cart2;
                //Cart2 = Console.ReadLine();
                //int C2 = Convert.ToInt32(Cart2);
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
            //else
            //{
                //Console.WriteLine("No tienes Suficiente Mana");
            //}
}


