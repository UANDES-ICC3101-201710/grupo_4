using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    public class Jugar
    {

        public void Jugars(Heroe warrior, Mazo mwarrior)
        {
            warrior.Robar(mwarrior.mazo1, warrior.mano);

            foreach (Minions m in warrior.Tablero1)
            {
                m.NDT = 1;
                m.TurnoP = 0;
            }
            if (warrior.Conteodemana < 10)
            {
                warrior.Conteodemana += 1;
            }
            int a = warrior.Conteodemana - warrior.Mana;
            warrior.Mana += a;
            

        }


        

        public int jugarcartar(Heroe warrior, Minions C)
        {
            if (warrior.Tablero1.Count < 8)
            {
                if (warrior.PonerenTablero(C) == 1)
                {
                    
                    return 1;
                }
            }
            return 0;

        }
        public void AtacarMinions(Heroe warrior, Heroe hunter, Minions C, Minions C2)
        {

            if (C.TurnoP == 0 & C.NDT == 1)
            {
                C.RestarVidaMs(C, C2, warrior.Tablero1, hunter.Tablero1);
                C.NDT = 0;
            }
        }
        public void AtacarHeroe(Heroe warrior, Heroe hunter, Minions Cs)
        {

            if (Cs.TurnoP == 0 & Cs.NDT == 1)
            {
                Cs.RestarVidaHs(hunter, Cs);
                Cs.NDT = 0;
            }

        }
        public void Habilidades1(Heroe warrior, Heroe hunter, Mazo mwarrior)
        {


            if (warrior.Mana >= 2)
            {
                if (warrior.Nombre != "Brujo")
                {
                    warrior.Habilidad(hunter);
                }
                else
                {
                    warrior.HabilidadDruid(hunter, mwarrior.mazo1);
                }
            }

        }
        public void AtacarconHeroe(Heroe warrior, Heroe hunter)
        {
            warrior.AtacarConHeroeAheroe(hunter);
            if (warrior.Durabilidad != 0)
            {
                warrior.Durabilidad -= 1;
                if (warrior.Durabilidad == 0)
                {
                    warrior.Ataque = 0;
                }
            }
        }
        public void AtacarHeroeminions(Heroe warrior, Heroe hunter, Minions C2)
        {

            warrior.AtacarConHeroeAMinions(C2);
            if (warrior.Durabilidad != 0)
            {
                warrior.Durabilidad -= 1;
                if (warrior.Durabilidad == 0)
                {
                    warrior.Ataque = 0;
                }
            }
        }
        public void Pasar(Heroe warrior)
        {
            if (warrior.HabilidadFindeTurno != 0)
            {
                warrior.Ataque = 0;

            }

        }


    }
}

