﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    public class Warrior : Heroe
    {

        public Warrior(int Vida, int Mana, string Nombre, int Conteodemana, int Armadura, int Ataque, int Durabilidad, int HabilidadFindeTurno)
            : base(Vida, Mana, Nombre, Conteodemana, Armadura, Ataque, Durabilidad, HabilidadFindeTurno)
        {

        }
        public override void Habilidad(Heroe H)
        {
            if (Mana >= 2)
            {
                Armadura += 2;
                Mana -= 2;
            }
            //else
            //{
              //  Console.WriteLine("No tienes Suficiente Mana");
            //}
        }
    }
}
