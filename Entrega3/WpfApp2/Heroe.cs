using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    [Serializable]
    public class Heroe
    {
        public int Vida;
        public int Mana;
        public string Nombre;
        public int Conteodemana;
        public int Armadura;
        public int Ataque;
        public int Durabilidad;
        public int HabilidadFindeTurno;
        public List<Minions> mano = new List<Minions>();
        public List<Minions> Miespeciales = new List<Minions>();
        public List<Minions> Tablero1 = new List<Minions>();




        public Heroe(int Vida, int Mana, string Nombre, int Conteodemana, int Armadura, int Ataque, int Durabilidad, int HabilidadFindeTurno)
        {
            this.Armadura = Armadura;
            this.Vida = Vida;
            this.Mana = Mana;
            this.Nombre = Nombre;
            this.Conteodemana = Conteodemana;
            this.Ataque = Ataque;
            this.Durabilidad = Durabilidad;
            this.HabilidadFindeTurno = HabilidadFindeTurno;
        }

        public int  PonerenTablero(Minions Carta)
        {
            if (Mana >= Carta.Coste)
            {
                Tablero1.Add(Carta);
                mano.Remove(Carta);
                Mana -= Carta.Coste;
                return 1;
            }
            else { return 0; }
           
        }
        public virtual void Habilidad(Heroe H)
        {

        }
        public void HabilidadDruid(Heroe H, List<Minions> Mazo)
        {
            if (Mana >= 2)
            {
                Vida -= 2;
                Robar(Mazo, mano);

            }
        }



        public virtual void AumentaVida(int a)
        {
            this.Vida += a;
        }
        public virtual void DisminuyeVida(int b)
        {
            this.Vida -= b;
        }
        public void Morir()
        {
            
            
            Environment.Exit(0);

        }
       
        public void Robar(List<Minions> mazo, List<Minions> mano)
        {
            if (mazo.Count() > 0)
            {
                mano.Add(mazo[0]);
                mazo.Remove(mazo[0]);
            }
        }
        public void AtacarConHeroeAheroe(Heroe Hero)
        {
            Ataque -= Hero.Vida;
        }
        public void AtacarConHeroeAMinions(Minions M)
        {
            Ataque -= M.Vida;
            Vida -= M.Daño;
        }

        internal void Robar(Mazo mJugador1, List<Minions> mano)
        {
            throw new NotImplementedException();
        }
    }
}
