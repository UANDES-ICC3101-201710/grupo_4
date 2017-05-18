using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupo_4
{
    public interface IHabilidad
    {
        void Aplicar();
    }

    public interface IEfecto
    {
        void Morir();
    }

    public class Heroe : IHabilidad, IEfecto
    {
        public int Vida;
        public int Mana;
        public string Nombre;
        public List<Cartas> mano = new List<Cartas>();


        public Heroe(int Vida, int Mana, string Nombre)
        {
            this.Vida = Vida;
            this.Mana = Mana;
            this.Nombre = Nombre;
        }

        public virtual void AumentaVida(int a)
        {
            this.Vida += a;
        }
        public virtual void DisminuyeVida(int b)
        {
            this.Vida -= b;
        }
        public virtual void Morir()
        {
            if (Vida == 0)
            {
                Console.WriteLine("Has muerto");
                Environment.Exit(0);
            }
        }
        public void Aplicar()
        {

        }
        public void Robar(List<Cartas> mazo, List<Cartas> mano)
        {
            mano.Add(mazo[0]);
            mazo.Remove(mazo[0]);
        }

        public void PonerenTablero(Cartas Carta, List<Cartas> Tablero, Heroe heroe)
        {
            if (heroe.Mana >= Carta.Coste)
            {
                Tablero.Add(Carta);
                mano.Remove(Carta);
                heroe.Mana -= Carta.Coste;
            }


        }

    }

    public class Usuario : Heroe
    {
        public int Ranking;
        public int IdUsuario;

        public Usuario(int Vida, int Mana, string Nombre, int Ranking, int IdUsuario) : base(Vida, Mana, Nombre)
        {
            this.Ranking = Ranking;
            this.IdUsuario = IdUsuario;
        }
    }


    public abstract class Cartas : IHabilidad
    {
        public string Clase;
        public int Coste;
        public string NombreCarta;

        public Cartas(string Clase, int Coste, string NombreCarta)
        {
            this.Clase = Clase;
            this.Coste = Coste;
            this.NombreCarta = NombreCarta;
        }

        public void RestarVidaH(Heroe H, Minions M)
        {
            H.Vida -= M.Daño;
            if (H.Vida == 0)
            { H.Morir(); }
        }


        public void RestarVidaM(Minions MiJ1, Minions MiJ2, List<Cartas> TJ1, List<Cartas> TJ2)
        {
            MiJ1.Vida -= MiJ2.Daño;
            MiJ2.Vida -= MiJ1.Daño;
            if (MiJ1.Vida == 0)
            { TJ1.Remove(MiJ1); }
            if (MiJ2.Vida == 0)
            { TJ2.Remove(MiJ2); }
        }

        public virtual void RestarMana(Heroe H, Cartas C)
        {
            H.Mana -= C.Coste;

        }
        public void Aplicar()
        {

        }
    }

    public class Hechizo : Cartas
    {
        public Hechizo(string Clase, int Coste, string NombreCarta) : base(Clase, Coste, NombreCarta)
        {
        }
    }

    public class Minions : Cartas
    {
        private string Raza;
        public int Vida;
        public int Daño;

        public Minions(string Clase, int Coste, string NombreCarta, string Raza, int Vida, int Daño) : base(Clase, Coste, NombreCarta)
        {
            this.Raza = Raza;
            this.Vida = Vida;
            this.Daño = Daño;
        }


    }

    public class Arma : Cartas
    {
        public int Duracion;
        public int Ataque;

        public Arma(string Clase, int Coste, string NombreCarta, int Duracion, int Ataque) : base(Clase, Coste, NombreCarta)
        {
            this.Duracion = Duracion;
            this.Ataque = Ataque;

        }
    }
    public class Mazo
    {
        public List<Cartas> mazo1 = new List<Cartas>();
        public void AgregarCarta(Cartas carta)
        {
            mazo1.Add(carta);
        }
        public void shuffle()
        {
            List<Cartas> mazorevuelto = new List<Cartas>();
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
    public class Jugar
    {

    }


    class Program
    {



        public int QuienParte(Heroe h1, Heroe h2, Mazo m1, Mazo m2, Cartas Moneda, int per)
        {
            Random random = new Random();
            int rndnumber = random.Next(0, 2);

            if (rndnumber == 0)
            {
                Console.WriteLine("Parte jugador 1");
                Console.WriteLine("Menu");
                if (per == 0)
                {
                    h1.Robar(m1.mazo1, h1.mano);
                    h1.Robar(m1.mazo1, h1.mano);
                    h1.Robar(m1.mazo1, h1.mano);

                    h2.Robar(m2.mazo1, h2.mano);
                    h2.Robar(m2.mazo1, h2.mano);
                    h2.Robar(m2.mazo1, h2.mano);
                    h2.Robar(m2.mazo1, h2.mano);

                }
                else
                {
                    h2.Robar(m2.mazo1, h2.mano);
                    h2.Robar(m2.mazo1, h2.mano);
                    h2.Robar(m2.mazo1, h2.mano);

                    h1.Robar(m1.mazo1, h1.mano);
                    h1.Robar(m1.mazo1, h1.mano);
                    h1.Robar(m1.mazo1, h1.mano);
                    h1.Robar(m1.mazo1, h1.mano);


                }




            }



            else
            {
                Console.WriteLine("Parte jugador 2");

                if (per != 0)
                {
                    h1.Robar(m1.mazo1, h1.mano);
                    h1.Robar(m1.mazo1, h1.mano);
                    h1.Robar(m1.mazo1, h1.mano);

                    h2.Robar(m2.mazo1, h2.mano);
                    h2.Robar(m2.mazo1, h2.mano);
                    h2.Robar(m2.mazo1, h2.mano);
                    h2.Robar(m2.mazo1, h2.mano);

                }
                else
                {
                    h2.Robar(m2.mazo1, h2.mano);
                    h2.Robar(m2.mazo1, h2.mano);
                    h2.Robar(m2.mazo1, h2.mano);

                    h1.Robar(m1.mazo1, h1.mano);
                    h1.Robar(m1.mazo1, h1.mano);
                    h1.Robar(m1.mazo1, h1.mano);
                    h1.Robar(m1.mazo1, h1.mano);

                }
            }
            return rndnumber;
        }

        public void CantidadCartasEnTablero(List<Cartas> CartasenTablero)
        {
            int cant;
            cant = CartasenTablero.Count();
            if (cant > 10)
            {
                Console.WriteLine("No se pueden poner mas cartas");
            }
        }




        static void Main(string[] args)
        {
            Program MyV = new Program();
            Mazo mhunter = new Mazo();
            Mazo mwarrior = new Mazo();

            List<Cartas> Tablero1 = new List<Cartas>();
            List<Cartas> Tablero2 = new List<Cartas>();

            Heroe warrior = new Heroe(30, 100, "Warrior");
            Heroe hunter = new Heroe(30, 100, "Hunter");

            Hechizo moneda = new Hechizo(null, 0, "Moneda");





            Minions wisp1 = new Minions("Classic", 0, "Wisp", null, 1, 1);
            mhunter.mazo1.Add(wisp1);
            mwarrior.mazo1.Add(wisp1);
            Minions wisp2 = new Minions("Classic", 0, "Wisp", null, 1, 1);
            mhunter.mazo1.Add(wisp2);
            mwarrior.mazo1.Add(wisp2);
            Minions wisp3 = new Minions("Classic", 0, "Wisp", null, 1, 1);
            mhunter.mazo1.Add(wisp3);
            mwarrior.mazo1.Add(wisp3);

            Minions murloc1 = new Minions("Basic", 1, "Murloc Raider", "Murloc", 1, 2);
            mhunter.mazo1.Add(murloc1);
            mwarrior.mazo1.Add(murloc1);
            Minions murloc2 = new Minions("Basic", 1, "Murloc Raider", "Murloc", 1, 2);
            mhunter.mazo1.Add(murloc2);
            mwarrior.mazo1.Add(murloc2);
            Minions murloc3 = new Minions("Basic", 1, "Murloc Raider", "Murloc", 1, 2);
            mhunter.mazo1.Add(murloc3);
            mwarrior.mazo1.Add(murloc3);


            Minions bloodfen1 = new Minions("Basic", 2, "Bloodfen Raptor", "Beast", 2, 3);
            mhunter.mazo1.Add(bloodfen1);
            mwarrior.mazo1.Add(bloodfen1);
            Minions bloodfen2 = new Minions("Basic", 2, "Bloodfen Raptor", "Beast", 2, 3);
            mhunter.mazo1.Add(bloodfen2);
            mwarrior.mazo1.Add(bloodfen2);
            Minions bloodfen3 = new Minions("Basic", 2, "Bloodfen Raptor", "Beast", 2, 3);
            mhunter.mazo1.Add(bloodfen3);
            mwarrior.mazo1.Add(bloodfen3);

            Minions river1 = new Minions("Basic", 2, "River Crocolisk", " Beast", 3, 2);
            mhunter.mazo1.Add(river1);
            mwarrior.mazo1.Add(river1);
            Minions river2 = new Minions("Basic", 2, "River Crocolisk", " Beast", 3, 2);
            mhunter.mazo1.Add(river2);
            mwarrior.mazo1.Add(river2);
            Minions river3 = new Minions("Basic", 2, "River Crocolisk", " Beast", 3, 2);
            mhunter.mazo1.Add(river3);
            mwarrior.mazo1.Add(river3);

            Minions magma1 = new Minions("Basic", 3, "Magma Rager", "Elemental", 1, 5);
            mhunter.mazo1.Add(magma1);
            mwarrior.mazo1.Add(magma1);
            Minions magma2 = new Minions("Basic", 3, "Magma Rager", "Elemental", 1, 5);
            mhunter.mazo1.Add(magma2);
            mwarrior.mazo1.Add(magma2);
            Minions magma3 = new Minions("Basic", 3, "Magma Rager", "Elemental", 1, 5);
            mhunter.mazo1.Add(magma3);
            mwarrior.mazo1.Add(magma3);

            Minions chillwind1 = new Minions("Basic", 4, "Chillwind Yeti", null, 5, 4);
            mhunter.mazo1.Add(chillwind1);
            mwarrior.mazo1.Add(chillwind1);
            Minions chillwind2 = new Minions("Basic", 4, "Chillwind Yeti", null, 5, 4);
            mhunter.mazo1.Add(chillwind2);
            mwarrior.mazo1.Add(chillwind2);
            Minions chillwind3 = new Minions("Basic", 4, "Chillwind Yeti", null, 5, 4);
            mhunter.mazo1.Add(chillwind3);
            mwarrior.mazo1.Add(chillwind3);

            Minions oasis1 = new Minions("Basic", 4, "Oasis Snapjaw", "Beast", 7, 2);
            mhunter.mazo1.Add(oasis1);
            mwarrior.mazo1.Add(oasis1);
            Minions oasis2 = new Minions("Basic", 4, "Oasis Snapjaw", "Beast", 7, 2);
            mhunter.mazo1.Add(oasis2);
            mwarrior.mazo1.Add(oasis2);
            Minions oasis3 = new Minions("Basic", 4, "Oasis Snapjaw", "Beast", 7, 2);
            mhunter.mazo1.Add(oasis3);
            mwarrior.mazo1.Add(oasis3);

            Minions boulderfist1 = new Minions("Basic", 6, "Boulderfist Ogre", null, 7, 6);
            mhunter.mazo1.Add(boulderfist1);
            mwarrior.mazo1.Add(boulderfist1);
            Minions boulderfist2 = new Minions("Basic", 6, "Boulderfist Ogre", null, 7, 6);
            mhunter.mazo1.Add(boulderfist2);
            mwarrior.mazo1.Add(boulderfist2);
            Minions boulderfist3 = new Minions("Basic", 6, "Boulderfist Ogre", null, 7, 6);
            mhunter.mazo1.Add(boulderfist3);
            mwarrior.mazo1.Add(boulderfist3);


            Minions war1 = new Minions("Basic", 7, "War Golem", null, 7, 7);
            mhunter.mazo1.Add(war1);
            mwarrior.mazo1.Add(war1);
            Minions war2 = new Minions("Basic", 7, "War Golem", null, 7, 7);
            mhunter.mazo1.Add(war2);
            mwarrior.mazo1.Add(war2);
            Minions war3 = new Minions("Basic", 7, "War Golem", null, 7, 7);
            mhunter.mazo1.Add(war3);
            mwarrior.mazo1.Add(war3);

            Minions core1 = new Minions("Basic", 7, "Core Hound", "Beast", 5, 9);
            mhunter.mazo1.Add(core1);
            mwarrior.mazo1.Add(core1);
            Minions core2 = new Minions("Basic", 7, "Core Hound", "Beast", 5, 9);
            mhunter.mazo1.Add(core2);
            mwarrior.mazo1.Add(core2);
            Minions core3 = new Minions("Basic", 7, "Core Hound", "Beast", 5, 9);
            mhunter.mazo1.Add(core3);
            mwarrior.mazo1.Add(core3);

            mhunter.shuffle();
            mwarrior.shuffle();

            Console.WriteLine("Menu");
            Console.WriteLine("Elegir jugador (0:Warrior, 1:Hunter)");
            string personaje;
            personaje = Console.ReadLine();
            int per = Convert.ToInt32(personaje);
            int t = MyV.QuienParte(warrior, hunter, mwarrior, mhunter, moneda, per);
            Console.WriteLine(t);

            bool b = true;
            while (b == true)
            {
                if (t == 0)
                {
                    warrior.Robar(mwarrior.mazo1, warrior.mano);
                    Console.WriteLine("Jugador 1");
                    Console.WriteLine("Elegir Accion:(0:Jugar Carta, 1:AtacaraMinion");
                    string Accion;
                    Accion = Console.ReadLine();
                    int ACC = Convert.ToInt32(Accion);
                    if (per == 0)
                    {
                        if (ACC == 0)
                        {
                            foreach (Cartas par in warrior.mano)
                            {
                                Console.WriteLine("Nombre: " + par.NombreCarta + "Coste: " + par.Coste + "Vida: ");
                            }
                            Console.WriteLine("Elige carta para jugar (numero de la posicion de la carta[0,1,2..])");
                            string Cart;
                            Cart = Console.ReadLine();
                            int C = Convert.ToInt32(Cart);
                            if (Tablero1.Count < 10)
                            {
                                warrior.PonerenTablero(warrior.mano[C], Tablero1, warrior);
                            }

                        }
                        if (ACC == 1)
                        {
                            Console.WriteLine("Elige carta para Atacar en tablero (numero de la posicion de la carta[0,1,2..])");
                            string Cart;
                            Cart = Console.ReadLine();
                            int C = Convert.ToInt32(Cart);
                            Console.WriteLine("Elige carta  Atacada en tablero opuesto (numero de la posicion de la carta[0,1,2..])");
                            string Cart2;
                            Cart2 = Console.ReadLine();
                            int C2 = Convert.ToInt32(Cart2);
                            //Tablero1[C].RestarVidaM(Tablero1[C], Tablero2[C2], Tablero1, Tablero2);


                        }
                        else
                        {
                            if (ACC == 0)
                            {
                                hunter.Robar(mhunter.mazo1, hunter.mano);
                                foreach (Cartas par in hunter.mano)
                                {
                                    Console.WriteLine("Nombre: " + par.NombreCarta + " Coste: " + par.Coste);
                                }
                                Console.WriteLine("Elige carta para jugar (numero de la posicion de la carta[0,1,2..])");
                                string Cart;
                                Cart = Console.ReadLine();
                                int C = Convert.ToInt32(Cart);
                                if (Tablero1.Count < 10)
                                {
                                    hunter.PonerenTablero(hunter.mano[C], Tablero1, hunter);
                                }

                            }
                        }
                        if (ACC == 1)
                        {
                            Console.WriteLine("Elige carta para Atacar en tablero (numero de la posicion de la carta[0,1,2..])");
                            string Cart;
                            Cart = Console.ReadLine();
                            int C = Convert.ToInt32(Cart);
                            Console.WriteLine("Elige carta  Atacada en tablero opuesto (numero de la posicion de la carta[0,1,2..])");
                            string Cart2;
                            Cart2 = Console.ReadLine();
                            int C2 = Convert.ToInt32(Cart2);
                            //Tablero1[C].RestarVidaM(Tablero1[C], Tablero2[C2], Tablero1, Tablero2);


                        }
                    }

                }
                else
                {
                    Console.WriteLine("Jugador 2");
                    Console.WriteLine("Elegir Accion:(0:Jugar Carta, 1:AtacaraMinion");
                    string Accion;
                    Accion = Console.ReadLine();
                    int ACC = Convert.ToInt32(Accion);
                    if (per != 0)
                    {
                        if (ACC == 0)
                        {
                            warrior.Robar(mwarrior.mazo1, warrior.mano);
                            foreach (Cartas par in warrior.mano)
                            {
                                Console.WriteLine("Nombre: " + par.NombreCarta + "Coste: " + par.Coste + "Vida: ");
                            }
                            Console.WriteLine("Elige carta para jugar (numero de la posicion de la carta[0,1,2..])");
                            string Cart;
                            Cart = Console.ReadLine();
                            int C = Convert.ToInt32(Cart);
                            if (Tablero1.Count < 10)
                            {
                                warrior.PonerenTablero(warrior.mano[C], Tablero2, warrior);
                            }

                        }
                        if (ACC == 1)
                        {
                            Console.WriteLine("Elige carta para Atacar en tablero (numero de la posicion de la carta[0,1,2..])");
                            string Cart;
                            Cart = Console.ReadLine();
                            int C = Convert.ToInt32(Cart);
                            Console.WriteLine("Elige carta  Atacada en tablero opuesto (numero de la posicion de la carta[0,1,2..])");
                            string Cart2;
                            Cart2 = Console.ReadLine();
                            int C2 = Convert.ToInt32(Cart2);
                            //Tablero1[C].RestarVidaM(Tablero1[C], Tablero2[C2], Tablero1, Tablero2);


                        }
                        else
                        {
                            if (ACC == 0)
                            {
                                hunter.Robar(mhunter.mazo1, hunter.mano);
                                foreach (Cartas par in hunter.mano)
                                {
                                    Console.WriteLine("Nombre: " + par.NombreCarta + " Coste: " + par.Coste);
                                }
                                Console.WriteLine("Elige carta para jugar (numero de la posicion de la carta[0,1,2..])");
                                string Carat;
                                Carat = Console.ReadLine();
                                int Ca = Convert.ToInt32(Carat);
                                if (Tablero1.Count < 10)
                                {
                                    hunter.PonerenTablero(hunter.mano[Ca], Tablero2, hunter);
                                }

                            }
                            if (ACC == 1)
                            {
                                Console.WriteLine("Elige carta para Atacar en tablero (numero de la posicion de la carta[0,1,2..])");
                                string Cart;
                                Cart = Console.ReadLine();
                                int C = Convert.ToInt32(Cart);
                                Console.WriteLine("Elige carta  Atacada en tablero opuesto (numero de la posicion de la carta[0,1,2..])");
                                string Cart2;
                                Cart2 = Console.ReadLine();
                                int C2 = Convert.ToInt32(Cart2);
                                //Tablero1[C].RestarVidaM(Tablero1[C], Tablero2[C2], Tablero1, Tablero2);


                            }
                        }
                    }


                }

                if (t == 0)
                { t = 1; }
                else
                {
                    t = 0;
                }
            }

            Console.WriteLine(" tablero");
            foreach (Cartas par in Tablero1)
            {
                Console.WriteLine(par.NombreCarta);
            }



            Console.ReadKey();


        }
    }
}
