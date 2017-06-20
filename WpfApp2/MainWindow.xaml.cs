using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Resources;

namespace WpfApp2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Hechizo moneda = new Hechizo(null, 0, "Moneda");

        Minions wisp1 = new Minions("Classic", 0, "Wisp1", null, 1, 1, 1, 0, 0);
        Minions wisp2 = new Minions("Classic", 0, "Wisp2", null, 1, 1, 1, 0, 0);
        Minions wisp3 = new Minions("Classic", 0, "Wisp3", null, 1, 1, 1, 0, 0);
        Minions murloc1 = new Minions("Basic", 1, "Murloc1", "Murloc", 1, 2, 1, 0, 0);
        Minions murloc2 = new Minions("Basic", 1, "Murloc2", "Murloc", 1, 2, 1, 0, 0);
        Minions murloc3 = new Minions("Basic", 1, "Murloc3", "Murloc", 1, 2, 1, 0, 0);
        Minions bloodfen1 = new Minions("Basic", 2, "Bloodfen1", "Beast", 2, 3, 1, 0, 0);
        Minions bloodfen2 = new Minions("Basic", 2, "Bloodfen2", "Beast", 2, 3, 1, 0, 0);
        Minions bloodfen3 = new Minions("Basic", 2, "Bloodfen3", "Beast", 2, 3, 1, 0, 0);
        Minions river1 = new Minions("Basic", 2, "River1", " Beast", 3, 2, 1, 0, 0);
        Minions river2 = new Minions("Basic", 2, "River2", " Beast", 3, 2, 1, 0, 0);
        Minions river3 = new Minions("Basic", 2, "River3", " Beast", 3, 2, 1, 0, 0);
        Minions magma2 = new Minions("Basic", 3, "Magma2", "Elemental", 1, 5, 1, 0, 0);
        Minions magma1 = new Minions("Basic", 3, "Magma1", "Elemental", 1, 5, 1, 0, 0);
        Minions magma3 = new Minions("Basic", 3, "Magma3", "Elemental", 1, 5, 1, 0, 0);
        Minions chillwind2 = new Minions("Basic", 4, "Chillwind2", null, 5, 4, 1, 0, 0);
        Minions chillwind3 = new Minions("Basic", 4, "Chillwind3", null, 5, 4, 1, 0, 0);
        Minions chillwind1 = new Minions("Basic", 4, "Chillwind1", null, 5, 4, 1, 0, 0);
        Minions oasis1 = new Minions("Basic", 4, "Oasis1", "Beast", 7, 2, 1, 0, 0);
        Minions oasis2 = new Minions("Basic", 4, "Oasis2", "Beast", 7, 2, 1, 0, 0);
        Minions oasis3 = new Minions("Basic", 4, "Oasis3", "Beast", 7, 2, 1, 0, 0);
        Minions boulderfist1 = new Minions("Basic", 6, "Boulderfist1", null, 7, 6, 1, 0, 0);
        Minions boulderfist2 = new Minions("Basic", 6, "Boulderfist2", null, 7, 6, 1, 0, 0);
        Minions boulderfist3 = new Minions("Basic", 6, "Boulderfist3", null, 7, 6, 1, 0, 0);
        Minions war1 = new Minions("Basic", 7, "War1", null, 7, 7, 1, 0, 0);
        Minions war2 = new Minions("Basic", 7, "War2", null, 7, 7, 1, 0, 0);
        Minions war3 = new Minions("Basic", 7, "War3", null, 7, 7, 1, 0, 0);
        Minions core1 = new Minions("Basic", 7, "Corehound1", "Beast", 5, 9, 1, 0, 0);
        Minions core2 = new Minions("Basic", 7, "Corehound2", "Beast", 5, 9, 1, 0, 0);
        Minions core3 = new Minions("Basic", 7, "Corehound3", "Beast", 5, 9, 1, 0, 0);


        public MainWindow()
        {

            MJugador1.mazo1.Add(wisp1);
            MJugador2.mazo1.Add(wisp1);
            MJugador1.mazo1.Add(wisp2);
            MJugador2.mazo1.Add(wisp2);
            MJugador1.mazo1.Add(wisp3);
            MJugador2.mazo1.Add(wisp3);
            MJugador1.mazo1.Add(murloc1);
            MJugador2.mazo1.Add(murloc1);
            MJugador1.mazo1.Add(murloc2);
            MJugador2.mazo1.Add(murloc2);
            MJugador1.mazo1.Add(murloc3);
            MJugador2.mazo1.Add(murloc3);
            MJugador1.mazo1.Add(bloodfen1);
            MJugador2.mazo1.Add(bloodfen1);
            MJugador1.mazo1.Add(bloodfen2);
            MJugador2.mazo1.Add(bloodfen2);
            MJugador1.mazo1.Add(bloodfen3);
            MJugador2.mazo1.Add(bloodfen3);
            MJugador1.mazo1.Add(river1);
            MJugador2.mazo1.Add(river1);
            MJugador1.mazo1.Add(river2);
            MJugador2.mazo1.Add(river2);

            MJugador1.mazo1.Add(river3);
            MJugador2.mazo1.Add(river3);


            MJugador1.mazo1.Add(magma1);
            MJugador2.mazo1.Add(magma1);

            MJugador1.mazo1.Add(magma2);
            MJugador2.mazo1.Add(magma2);

            MJugador1.mazo1.Add(magma3);
            MJugador2.mazo1.Add(magma3);


            MJugador1.mazo1.Add(chillwind1);
            MJugador2.mazo1.Add(chillwind1);

            MJugador1.mazo1.Add(chillwind2);
            MJugador2.mazo1.Add(chillwind2);

            MJugador1.mazo1.Add(chillwind3);
            MJugador2.mazo1.Add(chillwind3);


            MJugador1.mazo1.Add(oasis1);
            MJugador2.mazo1.Add(oasis1);

            MJugador1.mazo1.Add(oasis2);
            MJugador2.mazo1.Add(oasis2);

            MJugador1.mazo1.Add(oasis3);
            MJugador2.mazo1.Add(oasis3);


            MJugador1.mazo1.Add(boulderfist1);
            MJugador2.mazo1.Add(boulderfist1);
            MJugador1.mazo1.Add(boulderfist2);
            MJugador2.mazo1.Add(boulderfist2);

            MJugador1.mazo1.Add(boulderfist3);
            MJugador2.mazo1.Add(boulderfist3);



            MJugador1.mazo1.Add(war1);
            MJugador2.mazo1.Add(war1);

            MJugador1.mazo1.Add(war2);
            MJugador2.mazo1.Add(war2);

            MJugador1.mazo1.Add(war3);
            MJugador2.mazo1.Add(war3);


            MJugador1.mazo1.Add(core1);
            MJugador2.mazo1.Add(core1);

            MJugador1.mazo1.Add(core2);
            MJugador2.mazo1.Add(core2);

            MJugador1.mazo1.Add(core3);
            MJugador2.mazo1.Add(core3);
            MJugador1.shuffle();
            MJugador2.shuffle();
            MJugador2.shuffle();

            InitializeComponent();

        }


        Mazo MJugador1 = new Mazo();
        Mazo MJugador2 = new Mazo();
        List<Heroe> Heroes = new List<Heroe>();
        Program MyV = new Program();
        Jugar jugs = new Jugar();

        int eligioheroe = 0;
        int jugando = 0;
        int r1 = 0;
        int r2 = 0;
        int r11 = 0;
        int r22 = 0;


        private void Paladin_Click(object sender, RoutedEventArgs e)
        {
            if (JugadorUno.Visibility == Visibility.Visible && eligioheroe == 0)
            {
                Paladin Jugador1 = new Paladin(30, 0, "Paladin",0, 0, 0, 0, 0);
                Heroes.Add(Jugador1);
                Minions Pala = new Minions("Paladin", 0, "Paladin", "Guerrero", 1, 1, 1, 0, 0);
                Jugador1.Miespeciales.Add(Pala);
                Paladin.Visibility = Visibility.Hidden;
                JugadorUno.Visibility = Visibility.Hidden;
                JugadorDos.Visibility = Visibility.Visible;
                r1 = 1;
                r11 = 1;
            }
            else
            {
                Paladin Jugador2 = new Paladin(30, 0, "Paladin", 0, 0, 0, 0, 0);
                Heroes.Add(Jugador2);
                Minions Pala = new Minions("Paladin", 0, "Paladin", "Guerrero", 1, 1, 1, 0, 0);
                Jugador2.Miespeciales.Add(Pala);
                eligioheroe = 1;
                EligeHeroes.Visibility = Visibility.Hidden;
                Guerrero.Visibility = Visibility.Hidden;
                Chaman.Visibility = Visibility.Hidden;
                Brujo.Visibility = Visibility.Hidden;
                Picaro.Visibility = Visibility.Hidden;
                Priest.Visibility = Visibility.Hidden;
                Cazador.Visibility = Visibility.Hidden;
                Druid.Visibility = Visibility.Hidden;
                Paladin.Visibility = Visibility.Hidden;
                Mago.Visibility = Visibility.Hidden;
                Tablero.Visibility = Visibility.Visible;
                JugadorUno.Visibility = Visibility.Visible;
                JugadorDos.Visibility = Visibility.Hidden;

                FinTurno1.Visibility = Visibility.Visible;
                EmpiezaT1.Visibility = Visibility.Visible;
                BarraTableroj1.Visibility = Visibility.Visible;
                BarraTableroj2.Visibility = Visibility.Visible;
                Tableroj1.Visibility = Visibility.Visible;
                Tableroj2.Visibility = Visibility.Visible;
                r2 = 1;
                r22 = 1;
                int t = MyV.QuienParte(Heroes[0], Heroes[1], MJugador1, MJugador2);
            }
        }

        private void Druid_Click(object sender, RoutedEventArgs e)
        {
            if (JugadorUno.Visibility == Visibility.Visible && eligioheroe == 0)
            {
                Druida Jugador1 = new Druida(30, 0, "Druida", 0, 0, 0, 0, 0);
                Heroes.Add(Jugador1);
                Druid.Visibility = Visibility.Hidden;
                JugadorUno.Visibility = Visibility.Hidden;
                JugadorDos.Visibility = Visibility.Visible;
                r1 = 2;
                r11 = 2;
            }
            else
            {
                Druida Jugador2 = new Druida(30, 0, "Druida", 0, 0, 0, 0, 0);
                Heroes.Add(Jugador2);
                eligioheroe = 1;
                EligeHeroes.Visibility = Visibility.Hidden;
                Guerrero.Visibility = Visibility.Hidden;
                Chaman.Visibility = Visibility.Hidden;
                Brujo.Visibility = Visibility.Hidden;
                Picaro.Visibility = Visibility.Hidden;
                Priest.Visibility = Visibility.Hidden;
                Cazador.Visibility = Visibility.Hidden;
                Druid.Visibility = Visibility.Hidden;
                Paladin.Visibility = Visibility.Hidden;
                Mago.Visibility = Visibility.Hidden;
                Tablero.Visibility = Visibility.Visible;
                JugadorUno.Visibility = Visibility.Visible;
                JugadorDos.Visibility = Visibility.Hidden;

                FinTurno1.Visibility = Visibility.Visible;
                EmpiezaT1.Visibility = Visibility.Visible;
                BarraTableroj1.Visibility = Visibility.Visible;
                BarraTableroj2.Visibility = Visibility.Visible;
                Tableroj1.Visibility = Visibility.Visible;
                Tableroj2.Visibility = Visibility.Visible;
                r2 = 2;
                r22 = 2;
                int t = MyV.QuienParte(Heroes[0], Heroes[1], MJugador1, MJugador2);
            }
        }

        private void Cazador_Click(object sender, RoutedEventArgs e)
        {
            if (JugadorUno.Visibility == Visibility.Visible && eligioheroe == 0)
            {
                Hunter Jugador1 = new Hunter(30, 0, "Hunter", 0, 0, 0, 0, 0);
                Heroes.Add(Jugador1);
                Cazador.Visibility = Visibility.Hidden;
                JugadorUno.Visibility = Visibility.Hidden;
                JugadorDos.Visibility = Visibility.Visible;
                r1 = 3;
                r11 = 3;
            }
            else
            {
                Hunter Jugador2 = new Hunter(30, 0, "Hunter", 0, 0, 0, 0, 0);
                Heroes.Add(Jugador2);
                eligioheroe = 1;
                EligeHeroes.Visibility = Visibility.Hidden;
                Guerrero.Visibility = Visibility.Hidden;
                Chaman.Visibility = Visibility.Hidden;
                Brujo.Visibility = Visibility.Hidden;
                Picaro.Visibility = Visibility.Hidden;
                Priest.Visibility = Visibility.Hidden;
                Cazador.Visibility = Visibility.Hidden;
                Druid.Visibility = Visibility.Hidden;
                Paladin.Visibility = Visibility.Hidden;
                Mago.Visibility = Visibility.Hidden;
                Tablero.Visibility = Visibility.Visible;
                JugadorUno.Visibility = Visibility.Visible;
                JugadorDos.Visibility = Visibility.Hidden;

                FinTurno1.Visibility = Visibility.Visible;
                EmpiezaT1.Visibility = Visibility.Visible;
                BarraTableroj1.Visibility = Visibility.Visible;
                BarraTableroj2.Visibility = Visibility.Visible;
                Tableroj1.Visibility = Visibility.Visible;
                Tableroj2.Visibility = Visibility.Visible;
                r2 = 3;
                r22 = 3;
                int t = MyV.QuienParte(Heroes[0], Heroes[1], MJugador1, MJugador2);
            }
        }

        private void Priest_Click(object sender, RoutedEventArgs e)
        {
            if (JugadorUno.Visibility == Visibility.Visible && eligioheroe == 0)
            {
                Sacerdote Jugador1 = new Sacerdote(30, 0, "Sacerdote", 0, 0, 0, 0, 0);
                Heroes.Add(Jugador1);
                Priest.Visibility = Visibility.Hidden;
                JugadorUno.Visibility = Visibility.Hidden;
                JugadorDos.Visibility = Visibility.Visible;
                r1 = 4;
                r11 = 4;
            }
            else
            {
                Sacerdote Jugador2 = new Sacerdote(30, 0, "Sacerdote", 0, 0, 0, 0, 0);
                Heroes.Add(Jugador2);
                eligioheroe = 1;
                EligeHeroes.Visibility = Visibility.Hidden;
                Guerrero.Visibility = Visibility.Hidden;
                Chaman.Visibility = Visibility.Hidden;
                Brujo.Visibility = Visibility.Hidden;
                Picaro.Visibility = Visibility.Hidden;
                Priest.Visibility = Visibility.Hidden;
                Cazador.Visibility = Visibility.Hidden;
                Druid.Visibility = Visibility.Hidden;
                Paladin.Visibility = Visibility.Hidden;
                Mago.Visibility = Visibility.Hidden;
                Tablero.Visibility = Visibility.Visible;
                JugadorUno.Visibility = Visibility.Visible;
                JugadorDos.Visibility = Visibility.Hidden;

                FinTurno1.Visibility = Visibility.Visible;
                EmpiezaT1.Visibility = Visibility.Visible;
                BarraTableroj1.Visibility = Visibility.Visible;
                BarraTableroj2.Visibility = Visibility.Visible;
                Tableroj1.Visibility = Visibility.Visible;
                Tableroj2.Visibility = Visibility.Visible;
                r2 = 4;
                r22 = 4;
                int t = MyV.QuienParte(Heroes[0], Heroes[1], MJugador1, MJugador2);
            }
        }

        private void Picaro_Click(object sender, RoutedEventArgs e)
        {
            if (JugadorUno.Visibility == Visibility.Visible && eligioheroe == 0)
            {
                Picaro Jugador1 = new Picaro(30, 0, "Picaro", 0, 0, 0, 0, 0);
                Heroes.Add(Jugador1);
                Picaro.Visibility = Visibility.Hidden;
                JugadorUno.Visibility = Visibility.Hidden;
                JugadorDos.Visibility = Visibility.Visible;
                r1 = 5;
                r11 = 5;
            }
            else
            {
                Picaro Jugador2 = new Picaro(30, 0, "Picaro", 0, 0, 0, 0, 0);
                Heroes.Add(Jugador2);
                eligioheroe = 1;
                EligeHeroes.Visibility = Visibility.Hidden;
                Guerrero.Visibility = Visibility.Hidden;
                Chaman.Visibility = Visibility.Hidden;
                Brujo.Visibility = Visibility.Hidden;
                Picaro.Visibility = Visibility.Hidden;
                Priest.Visibility = Visibility.Hidden;
                Cazador.Visibility = Visibility.Hidden;
                Druid.Visibility = Visibility.Hidden;
                Paladin.Visibility = Visibility.Hidden;
                Mago.Visibility = Visibility.Hidden;
                Tablero.Visibility = Visibility.Visible;
                JugadorUno.Visibility = Visibility.Visible;
                JugadorDos.Visibility = Visibility.Hidden;

                FinTurno1.Visibility = Visibility.Visible;
                EmpiezaT1.Visibility = Visibility.Visible;
                BarraTableroj1.Visibility = Visibility.Visible;
                BarraTableroj2.Visibility = Visibility.Visible;
                Tableroj1.Visibility = Visibility.Visible;
                Tableroj2.Visibility = Visibility.Visible;
                r2 = 5;
                r22 = 5;
                int t = MyV.QuienParte(Heroes[0], Heroes[1], MJugador1, MJugador2);
            }

        }

        private void Brujo_Click(object sender, RoutedEventArgs e)
        {
            if (JugadorUno.Visibility == Visibility.Visible && eligioheroe == 0)
            {
                Brujo Jugador1 = new Brujo(30, 0, "Brujo", 0, 0, 0, 0, 0);
                Heroes.Add(Jugador1);
                Brujo.Visibility = Visibility.Hidden;
                JugadorUno.Visibility = Visibility.Hidden;
                JugadorDos.Visibility = Visibility.Visible;
                r1 = 6;
                r11 = 6;
            }
            else
            {
                Brujo Jugador2 = new Brujo(30, 0, "Brujo", 0, 0, 0, 0, 0);
                Heroes.Add(Jugador2);
                eligioheroe = 1;
                EligeHeroes.Visibility = Visibility.Hidden;
                Guerrero.Visibility = Visibility.Hidden;
                Chaman.Visibility = Visibility.Hidden;
                Brujo.Visibility = Visibility.Hidden;
                Picaro.Visibility = Visibility.Hidden;
                Priest.Visibility = Visibility.Hidden;
                Cazador.Visibility = Visibility.Hidden;
                Druid.Visibility = Visibility.Hidden;
                Paladin.Visibility = Visibility.Hidden;
                Mago.Visibility = Visibility.Hidden;
                Tablero.Visibility = Visibility.Visible;
                JugadorUno.Visibility = Visibility.Visible;
                JugadorDos.Visibility = Visibility.Hidden;

                FinTurno1.Visibility = Visibility.Visible;
                EmpiezaT1.Visibility = Visibility.Visible;
                BarraTableroj1.Visibility = Visibility.Visible;
                BarraTableroj2.Visibility = Visibility.Visible;
                Tableroj1.Visibility = Visibility.Visible;
                Tableroj2.Visibility = Visibility.Visible;
                r2 = 6;
                r22 = 6;
                int t = MyV.QuienParte(Heroes[0], Heroes[1], MJugador1, MJugador2);
            }


        }

        private void Mago_Click(object sender, RoutedEventArgs e)
        {
            if (JugadorUno.Visibility == Visibility.Visible && eligioheroe == 0)
            {
                Mago Jugador1 = new Mago(30, 0, "Mago", 0, 0, 0, 0, 0);
                Heroes.Add(Jugador1);
                Mago.Visibility = Visibility.Hidden;
                JugadorUno.Visibility = Visibility.Hidden;
                JugadorDos.Visibility = Visibility.Visible;
                r1 = 7;
                r11 = 7;
            }
            else
            {
                Mago Jugador2 = new Mago(30, 0, "Mago", 0, 0, 0, 0, 0);
                Heroes.Add(Jugador2);
                eligioheroe = 1;
                EligeHeroes.Visibility = Visibility.Hidden;
                Guerrero.Visibility = Visibility.Hidden;
                Chaman.Visibility = Visibility.Hidden;
                Brujo.Visibility = Visibility.Hidden;
                Picaro.Visibility = Visibility.Hidden;
                Priest.Visibility = Visibility.Hidden;
                Cazador.Visibility = Visibility.Hidden;
                Druid.Visibility = Visibility.Hidden;
                Paladin.Visibility = Visibility.Hidden;
                Mago.Visibility = Visibility.Hidden;
                Tablero.Visibility = Visibility.Visible;
                JugadorUno.Visibility = Visibility.Visible;
                JugadorDos.Visibility = Visibility.Hidden;

                FinTurno1.Visibility = Visibility.Visible;
                EmpiezaT1.Visibility = Visibility.Visible;
                BarraTableroj1.Visibility = Visibility.Visible;
                BarraTableroj2.Visibility = Visibility.Visible;
                Tableroj1.Visibility = Visibility.Visible;
                Tableroj2.Visibility = Visibility.Visible;
                r2 = 7;
                r22 = 7;
                int t = MyV.QuienParte(Heroes[0], Heroes[1], MJugador1, MJugador2);

            }


        }

        private void Chaman_Click(object sender, RoutedEventArgs e)
        {
            if (JugadorUno.Visibility == Visibility.Visible && eligioheroe == 0)
            {
                Chaman Jugador1 = new Chaman(30, 0, "Chaman", 0, 0, 0, 0, 0);
                Minions Totem1 = new Minions("Totem", 1, "Totem1", "Totem", 1, 1, 1, 0, 0);
                Minions Totem2 = new Minions("Totem", 1, "Totem2", "Totem", 0, 2, 1, 0, 0);
                Minions Totem3 = new Minions("Totem", 1, "Totem3", "Totem", 0, 2, 1, 0, 0);
                Minions Totem4 = new Minions("Totem", 1, "Totem4", "Totem", 0, 2, 1, 0, 0);
                Jugador1.Miespeciales.Add(Totem1);
                Jugador1.Miespeciales.Add(Totem2);
                Jugador1.Miespeciales.Add(Totem3);
                Jugador1.Miespeciales.Add(Totem4);
                Heroes.Add(Jugador1);
                Chaman.Visibility = Visibility.Hidden;
                JugadorUno.Visibility = Visibility.Hidden;
                JugadorDos.Visibility = Visibility.Visible;

                r1 = 8;
                r11 = 8;
            }
            else
            {
                Chaman Jugador2 = new Chaman(30, 0, "Chaman", 0, 0, 0, 0, 0);
                Minions Totem1 = new Minions("Totem", 1, "Totem1", "Totem", 1, 1, 1, 0, 0);
                Minions Totem2 = new Minions("Totem", 1, "Totem2", "Totem", 0, 2, 1, 0, 0);
                Minions Totem3 = new Minions("Totem", 1, "Totem3", "Totem", 0, 2, 1, 0, 0);
                Minions Totem4 = new Minions("Totem", 1, "Totem4", "Totem", 0, 2, 1, 0, 0);
                Jugador2.Miespeciales.Add(Totem1);
                Jugador2.Miespeciales.Add(Totem2);
                Jugador2.Miespeciales.Add(Totem3);
                Jugador2.Miespeciales.Add(Totem4);
                Heroes.Add(Jugador2);
                eligioheroe = 1;
                EligeHeroes.Visibility = Visibility.Hidden;
                Guerrero.Visibility = Visibility.Hidden;
                Chaman.Visibility = Visibility.Hidden;
                Brujo.Visibility = Visibility.Hidden;
                Picaro.Visibility = Visibility.Hidden;
                Priest.Visibility = Visibility.Hidden;
                Cazador.Visibility = Visibility.Hidden;
                Druid.Visibility = Visibility.Hidden;
                Paladin.Visibility = Visibility.Hidden;
                Mago.Visibility = Visibility.Hidden;
                Tablero.Visibility = Visibility.Visible;
                JugadorUno.Visibility = Visibility.Visible;
                JugadorDos.Visibility = Visibility.Hidden;

                FinTurno1.Visibility = Visibility.Visible;
                EmpiezaT1.Visibility = Visibility.Visible;
                BarraTableroj1.Visibility = Visibility.Visible;
                BarraTableroj2.Visibility = Visibility.Visible;
                Tableroj1.Visibility = Visibility.Visible;
                Tableroj2.Visibility = Visibility.Visible;
                r2 = 8;
                r22 = 8;
                int t = MyV.QuienParte(Heroes[0], Heroes[1], MJugador1, MJugador2);
            }


        }

        private void Guerrero_Click(object sender, RoutedEventArgs e)
        {
            if (JugadorUno.Visibility == Visibility.Visible && eligioheroe == 0)
            {
                Warrior Jugador1 = new Warrior(30, 0, "Warrior", 0, 0, 0, 0, 0); ;
                Heroes.Add(Jugador1);
                Guerrero.Visibility = Visibility.Hidden;
                JugadorUno.Visibility = Visibility.Hidden;
                JugadorDos.Visibility = Visibility.Visible;
                r1 = 9;
                r11 = 9;
            }
            else
            {
                Warrior Jugador2 = new Warrior(30, 0, "Warrior", 0, 0, 0, 0, 0); ;
                Heroes.Add(Jugador2);
                eligioheroe = 1;
                EligeHeroes.Visibility = Visibility.Hidden;
                Guerrero.Visibility = Visibility.Hidden;
                Chaman.Visibility = Visibility.Hidden;
                Brujo.Visibility = Visibility.Hidden;
                Picaro.Visibility = Visibility.Hidden;
                Priest.Visibility = Visibility.Hidden;
                Cazador.Visibility = Visibility.Hidden;
                Druid.Visibility = Visibility.Hidden;
                Paladin.Visibility = Visibility.Hidden;
                Mago.Visibility = Visibility.Hidden;
                Tablero.Visibility = Visibility.Visible;
                JugadorUno.Visibility = Visibility.Visible;
                JugadorDos.Visibility = Visibility.Hidden;
                BarraTableroj1.Visibility = Visibility.Visible;
                BarraTableroj2.Visibility = Visibility.Visible;
                Tableroj1.Visibility = Visibility.Visible;
                Tableroj2.Visibility = Visibility.Visible;


                FinTurno1.Visibility = Visibility.Visible;
                EmpiezaT1.Visibility = Visibility.Visible;
                r2 = 9;
                r22 = 9;

                int t = MyV.QuienParte(Heroes[0], Heroes[1], MJugador1, MJugador2);
            }


        }

        private void nombre1_KeyPressed(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Usuario jug1 = new Usuario(0001, 10, "nombre1");

                nombrej1.Text = "Nombre Jugador 2: ";
                nombre2.Visibility = Visibility.Visible;
                JugadorUno.Visibility = Visibility.Hidden;
                JugadorDos.Visibility = Visibility.Hidden;
                HabilidadHeroe.Visibility = Visibility.Hidden;
                
            }
        }

        private void nombre2_KeyPressed(object sender, KeyEventArgs e)
        {
            nombre1.Visibility = Visibility.Hidden;
            if (e.Key == Key.Enter)
            {

                Usuario jug2 = new Usuario(0002, 10, "nombre2");
                nombre1.Text = nombre1.Text;

                nombre1.Visibility = Visibility.Hidden;
                nombrej1.Visibility = Visibility.Hidden;
                nombre2.Visibility = Visibility.Hidden;
                JugadorUno.Text = nombre1.Text;
                JugadorDos.Text = nombre2.Text;
                JugadorUno.Visibility = Visibility.Visible;
                JugadorDos.Visibility = Visibility.Hidden;
                EligeHeroes.Visibility = Visibility.Visible;
            }
        }



        private void FinTurno1_Click(object sender, RoutedEventArgs e)
        {
            jugs.Pasar(Heroes[0]);
            foreach (Minions i in Heroes[0].Tablero1)
            {
                i.Seleccionada = 0;
            }
            foreach (Minions i in Heroes[1].Tablero1)
            {
                i.Seleccionada = 0;
            }
            JugadorDos.Visibility = Visibility.Hidden;
            JugadorUno.Visibility = Visibility.Hidden;
            Mano.Visibility = Visibility.Hidden;
            BarraMano.Visibility = Visibility.Hidden;
            cantmana.Visibility = Visibility.Hidden;
            FinTurno1.Visibility = Visibility.Hidden;
            FinTurno2.Visibility = Visibility.Visible;
            EmpiezaT2.Visibility = Visibility.Visible;
            EmpiezaT1.Visibility = Visibility.Hidden;
            Manaj1.Visibility = Visibility.Hidden;
            Atacar.Visibility = Visibility.Hidden;
            HabilidadHeroe.Visibility = Visibility.Hidden;
            if (r1 == 1) { paladinjugador.Visibility = Visibility.Hidden; }
            else if (r1 == 2) { druidajugador.Visibility = Visibility.Hidden; }
            else if (r1 == 3) { cazadorjugador.Visibility = Visibility.Hidden; }
            else if (r1 == 4) { sacerdotejugador.Visibility = Visibility.Hidden; }
            else if (r1 == 5) { picarojugador.Visibility = Visibility.Hidden; }
            else if (r1 == 6) { brujojugador.Visibility = Visibility.Hidden; }
            else if (r1 == 7) { magojugador.Visibility = Visibility.Hidden; }
            else if (r1 == 8) { chamanjugador.Visibility = Visibility.Hidden; }
            else { guerrerojugador.Visibility = Visibility.Hidden; }
            if (r22 == 1) { otropaladin.Visibility = Visibility.Hidden; }
            else if (r22 == 2) { otrodruida.Visibility = Visibility.Hidden; }
            else if (r22 == 3) { otrocazador.Visibility = Visibility.Hidden; }
            else if (r22 == 4) { otrosacerdote.Visibility = Visibility.Hidden; }
            else if (r22 == 5) { otropicaro.Visibility = Visibility.Hidden; }
            else if (r22 == 6) { otrobrujo.Visibility = Visibility.Hidden; }
            else if (r22 == 7) { otromago.Visibility = Visibility.Hidden; }
            else if (r22 == 8) { otrochaman.Visibility = Visibility.Hidden; }
            else { otroguerrero.Visibility = Visibility.Hidden; }
            foreach (Minions i in Heroes[0].mano)
            {
                if (i.NombreCarta == "Wisp1")
                {
                    Wisp1.Visibility = Visibility.Hidden;

                }
                if (i.NombreCarta == "Wisp2")
                {
                    Wisp2.Visibility = Visibility.Hidden;
                }
                if (i.NombreCarta == "Wisp3")
                {
                    Wisp1.Visibility = Visibility.Hidden;
                }
                if (i.NombreCarta == "Murloc1")
                {
                    Murloc1.Visibility = Visibility.Hidden;
                }
                if (i.NombreCarta == "Murloc2")
                {
                    Murloc2.Visibility = Visibility.Hidden;
                }
                if (i.NombreCarta == "Murloc3")
                {
                    Murloc3.Visibility = Visibility.Hidden;
                }
                if (i.NombreCarta == "Oasis1")
                {
                    Oasis1.Visibility = Visibility.Hidden;
                }
                if (i.NombreCarta == "Oasis2")
                {
                    Oasis2.Visibility = Visibility.Hidden;
                }
                if (i.NombreCarta == "Oasis3")
                {
                    Oasis3.Visibility = Visibility.Hidden;
                }
                if (i.NombreCarta == "Corehound1")
                {
                    Corehound1.Visibility = Visibility.Hidden;
                }
                if (i.NombreCarta == "Corehound2")
                {
                    Corehound2.Visibility = Visibility.Hidden;
                }
                if (i.NombreCarta == "Corehound3")
                {
                    Corehound3.Visibility = Visibility.Hidden;
                }
                if (i.NombreCarta == "River1")
                {
                    River1.Visibility = Visibility.Hidden;
                }
                if (i.NombreCarta == "River2")
                {
                    River2.Visibility = Visibility.Hidden;
                }
                if (i.NombreCarta == "River3")
                {
                    River3.Visibility = Visibility.Hidden;
                }

                if (i.NombreCarta == "Bloodfen1")
                {
                    Bloodfen1.Visibility = Visibility.Hidden;
                }
                if (i.NombreCarta == "Bloodfen2")
                {
                    Bloodfen2.Visibility = Visibility.Hidden;
                }
                if (i.NombreCarta == "Bloodfen3")
                {
                    Bloodfen3.Visibility = Visibility.Hidden;
                }
                if (i.NombreCarta == "Magma1")
                {
                    Magma1.Visibility = Visibility.Hidden;
                }
                if (i.NombreCarta == "Magma2")
                {
                    Magma2.Visibility = Visibility.Hidden;
                }
                if (i.NombreCarta == "Magma3")
                {
                    Magma3.Visibility = Visibility.Hidden;
                }
                if (i.NombreCarta == "Chillwind1")
                {
                    Chillwind1.Visibility = Visibility.Hidden;

                }
                if (i.NombreCarta == "Chillwind2")
                {
                    Chillwind2.Visibility = Visibility.Hidden;

                }
                if (i.NombreCarta == "Chillwind3")
                {
                    Chillwind3.Visibility = Visibility.Hidden;

                }
                if (i.NombreCarta == "War1")
                {
                    War1.Visibility = Visibility.Hidden;

                }
                if (i.NombreCarta == "War2")
                {
                    War2.Visibility = Visibility.Hidden;

                }
                if (i.NombreCarta == "War3")
                {
                    War3.Visibility = Visibility.Hidden;

                }
                if (i.NombreCarta == "Boulderfist1")
                {
                    Boulderfist1.Visibility = Visibility.Hidden;
                }
                if (i.NombreCarta == "Boulderfist2")
                {
                    Boulderfist2.Visibility = Visibility.Hidden;
                }
                if (i.NombreCarta == "Boulderfist3")
                {
                    Boulderfist3.Visibility = Visibility.Hidden;
                }
            }


        }

        private void EmpiezaT1_Click(object sender, RoutedEventArgs e)
        {
            jugando = 0;

            JugadorUno.Visibility = Visibility.Visible;
            JugadorDos.Visibility = Visibility.Hidden;
            jugs.Jugars(Heroes[0], MJugador1);
            string va = Convert.ToString(Heroes[0].Mana);
            cantmana.Text = va;
            Manaj1.Value = Heroes[0].Mana;

            cantmana.Visibility = Visibility.Visible;
            Mano.Visibility = Visibility.Visible;
            BarraMano.Visibility = Visibility.Visible;
            Manaj1.Visibility = Visibility.Visible;
            Atacar.Visibility = Visibility.Visible;
            Manaj1.Value = Heroes[0].Mana;
            HabilidadHeroe.Visibility = Visibility.Visible;
            
            if (r1 == 1) { paladinjugador.Visibility = Visibility.Visible; }
            else if (r1 == 2) { druidajugador.Visibility = Visibility.Visible; }
            else if (r1 == 3) { cazadorjugador.Visibility = Visibility.Visible; }
            else if (r1 == 4) { sacerdotejugador.Visibility = Visibility.Visible; }
            else if (r1 == 5) { picarojugador.Visibility = Visibility.Visible; }
            else if (r1 == 6) { brujojugador.Visibility = Visibility.Visible; }
            else if (r1 == 7) { magojugador.Visibility = Visibility.Visible; }
            else if (r1 == 8) { chamanjugador.Visibility = Visibility.Visible; }
            else { guerrerojugador.Visibility = Visibility.Visible; }
            if (r22 == 1) { otropaladin.Visibility = Visibility.Visible; }
            else if (r22 == 2) { otrodruida.Visibility = Visibility.Visible; }
            else if (r22 == 3) { otrocazador.Visibility = Visibility.Visible; }
            else if (r22 == 4) { otrosacerdote.Visibility = Visibility.Visible; }
            else if (r22 == 5) { otropicaro.Visibility = Visibility.Visible; }
            else if (r22 == 6) { otrobrujo.Visibility = Visibility.Visible; }
            else if (r22 == 7) { otromago.Visibility = Visibility.Visible; }
            else if (r22 == 8) { otrochaman.Visibility = Visibility.Visible; }
            else { otroguerrero.Visibility = Visibility.Visible; }

            foreach (Minions i in Heroes[0].mano)
            {
                if (i.NombreCarta == "Wisp1")
                {

                    Wisp1.Margin = new Thickness(0, 0, 0, 0);
                    Wisp1.Visibility = Visibility.Visible;


                }
                if (i.NombreCarta == "Wisp2")
                {

                    Wisp2.Margin = new Thickness(0, 0, 0, 0);
                    Wisp2.Visibility = Visibility.Visible;

                }
                if (i.NombreCarta == "Wisp3")
                {

                    Wisp3.Margin = new Thickness(0, 0, 0, 0);
                    Wisp3.Visibility = Visibility.Visible;

                }
                if (i.NombreCarta == "Murloc1")
                {

                    Murloc1.Margin = new Thickness(0, 0, 0, 0);
                    Murloc1.Visibility = Visibility.Visible;

                }
                if (i.NombreCarta == "Murloc2")
                {

                    Murloc2.Margin = new Thickness(0, 0, 0, 0);
                    Murloc2.Visibility = Visibility.Visible;


                }
                if (i.NombreCarta == "Murloc3")
                {

                    Murloc3.Margin = new Thickness(0, 0, 0, 0);
                    Murloc3.Visibility = Visibility.Visible;

                }
                if (i.NombreCarta == "Oasis1")
                {

                    Oasis1.Margin = new Thickness(0, 0, 0, 0);
                    Oasis1.Visibility = Visibility.Visible;
                }
                if (i.NombreCarta == "Oasis2")
                {

                    Oasis2.Margin = new Thickness(0, 0, 0, 0);
                    Oasis2.Visibility = Visibility.Visible;
                }
                if (i.NombreCarta == "Oasis3")
                {

                    Oasis3.Margin = new Thickness(0, 0, 0, 0);
                    Oasis3.Visibility = Visibility.Visible;
                }
                if (i.NombreCarta == "Corehound1")
                {

                    Corehound1.Margin = new Thickness(0, 0, 0, 0);
                    Corehound1.Visibility = Visibility.Visible;
                }
                if (i.NombreCarta == "Corehound2")
                {

                    Corehound2.Margin = new Thickness(0, 0, 0, 0);
                    Corehound2.Visibility = Visibility.Visible;
                }
                if (i.NombreCarta == "Corehound3")
                {

                    Corehound3.Margin = new Thickness(0, 0, 0, 0);
                    Corehound3.Visibility = Visibility.Visible;
                }
                if (i.NombreCarta == "River1")
                {

                    River1.Margin = new Thickness(0, 0, 0, 0);
                    River1.Visibility = Visibility.Visible;
                }
                if (i.NombreCarta == "River2")
                {

                    River2.Margin = new Thickness(0, 0, 0, 0);
                    River2.Visibility = Visibility.Visible;
                }
                if (i.NombreCarta == "River3")
                {
                    River3.Margin = new Thickness(0, 0, 0, 0);
                    River3.Visibility = Visibility.Visible;
                }

                if (i.NombreCarta == "Bloodfen1")
                {

                    Bloodfen1.Margin = new Thickness(0, 0, 0, 0);
                    Bloodfen1.Visibility = Visibility.Visible;

                }
                if (i.NombreCarta == "Bloodfen2")
                {

                    Bloodfen2.Margin = new Thickness(0, 0, 0, 0);
                    Bloodfen2.Visibility = Visibility.Visible;

                }
                if (i.NombreCarta == "Bloodfen3")
                {

                    Bloodfen3.Margin = new Thickness(0, 0, 0, 0);
                    Bloodfen3.Visibility = Visibility.Visible;

                }

                if (i.NombreCarta == "Magma1")
                {

                    Magma1.Margin = new Thickness(0, 0, 0, 0);
                    Magma1.Visibility = Visibility.Visible;
                }
                if (i.NombreCarta == "Magma2")
                {

                    Magma2.Margin = new Thickness(0, 0, 0, 0);
                    Magma2.Visibility = Visibility.Visible;
                }
                if (i.NombreCarta == "Magma3")
                {

                    Magma3.Margin = new Thickness(0, 0, 0, 0);
                    Magma3.Visibility = Visibility.Visible;
                }
                if (i.NombreCarta == "Chillwind1")
                {

                    Chillwind1.Margin = new Thickness(0, 0, 0, 0);
                    Chillwind1.Visibility = Visibility.Visible;

                }
                if (i.NombreCarta == "Chillwind2")
                {

                    Chillwind2.Margin = new Thickness(0, 0, 0, 0);
                    Chillwind2.Visibility = Visibility.Visible;

                }
                if (i.NombreCarta == "Chillwind3")
                {

                    Chillwind3.Margin = new Thickness(0, 0, 0, 0);
                    Chillwind3.Visibility = Visibility.Visible;

                }
                if (i.NombreCarta == "War1")
                {

                    War1.Margin = new Thickness(0, 0, 0, 0);
                    War1.Visibility = Visibility.Visible;

                }
                if (i.NombreCarta == "War2")
                {
                    War2.Margin = new Thickness(0, 0, 0, 0);
                    War2.Visibility = Visibility.Visible;

                }
                if (i.NombreCarta == "War3")
                {

                    War3.Margin = new Thickness(0, 0, 0, 0);
                    War3.Visibility = Visibility.Visible;

                }
                if (i.NombreCarta == "Boulderfist1")
                {

                    Boulderfist1.Margin = new Thickness(0, 0, 0, 0);
                    Boulderfist1.Visibility = Visibility.Visible;
                }
                if (i.NombreCarta == "Boulderfist2")
                {

                    Boulderfist2.Margin = new Thickness(0, 0, 0, 0);
                    Boulderfist2.Visibility = Visibility.Visible;
                }
                if (i.NombreCarta == "Boulderfist3")
                {

                    Boulderfist1.Margin = new Thickness(0, 0, 0, 0);
                    Boulderfist3.Visibility = Visibility.Visible;
                }
                EmpiezaT1.Visibility = Visibility.Hidden;
            }
        }

        private void EmpiezaT2_Click(object sender, RoutedEventArgs e)
        {
            jugando = 1;
             cantmana.Visibility = Visibility.Visible;
            string va = Convert.ToString(Heroes[1].Mana);
            cantmana.Text = va;
            JugadorDos.Visibility = Visibility.Visible;
            JugadorUno.Visibility = Visibility.Hidden;
            Mano.Visibility = Visibility.Visible;
            BarraMano.Visibility = Visibility.Visible;
            jugs.Jugars(Heroes[1], MJugador2);
            Manaj2.Visibility = Visibility.Visible;
            Manaj2.Value = Heroes[1].Mana;
            HabilidadHeroe.Visibility = Visibility.Visible;
            Atacar.Visibility = Visibility.Visible;
            if (r2 == 1) { paladinjugador.Visibility = Visibility.Visible; }
            else if (r2 == 2) { druidajugador.Visibility = Visibility.Visible; }
            else if (r2 == 3) { cazadorjugador.Visibility = Visibility.Visible; }
            else if (r2 == 4) { sacerdotejugador.Visibility = Visibility.Visible; }
            else if (r2 == 5) { picarojugador.Visibility = Visibility.Visible; }
            else if (r2 == 6) { brujojugador.Visibility = Visibility.Visible; }
            else if (r2 == 7) { magojugador.Visibility = Visibility.Visible; }
            else if (r2 == 8) { chamanjugador.Visibility = Visibility.Visible; }
            else { guerrerojugador.Visibility = Visibility.Visible; }
            if (r11 == 1) { otropaladin.Visibility = Visibility.Visible; }
            else if (r11 == 2) { otrodruida.Visibility = Visibility.Visible; }

            else if (r11 == 3) { otrocazador.Visibility = Visibility.Visible; }
            else if (r11 == 4) { otrosacerdote.Visibility = Visibility.Visible; }
            else if (r11 == 5) { otropicaro.Visibility = Visibility.Visible; }
            else if (r11 == 6) { otrobrujo.Visibility = Visibility.Visible; }
            else if (r11 == 7) { otromago.Visibility = Visibility.Visible; }
            else if (r11 == 8) { otrochaman.Visibility = Visibility.Visible; }
            else { otroguerrero.Visibility = Visibility.Visible; }
            foreach (Minions i in Heroes[1].mano)
            {
                if (i.NombreCarta == "Wisp1")
                {

                    Wisp1.Margin = new Thickness(0, 0, 0, 0);
                    Wisp1.Visibility = Visibility.Visible;


                }
                if (i.NombreCarta == "Wisp2")
                {

                    Wisp2.Margin = new Thickness(0, 0, 0, 0);
                    Wisp2.Visibility = Visibility.Visible;

                }
                if (i.NombreCarta == "Wisp3")
                {

                    Wisp3.Margin = new Thickness(0, 0, 0, 0);
                    Wisp3.Visibility = Visibility.Visible;

                }
                if (i.NombreCarta == "Murloc1")
                {

                    Murloc1.Margin = new Thickness(0, 0, 0, 0);
                    Murloc1.Visibility = Visibility.Visible;

                }
                if (i.NombreCarta == "Murloc2")
                {

                    Murloc2.Margin = new Thickness(0, 0, 0, 0);
                    Murloc2.Visibility = Visibility.Visible;


                }
                if (i.NombreCarta == "Murloc3")
                {

                    Murloc3.Margin = new Thickness(0, 0, 0, 0);
                    Murloc3.Visibility = Visibility.Visible;

                }
                if (i.NombreCarta == "Oasis1")
                {

                    Oasis1.Margin = new Thickness(0, 0, 0, 0);
                    Oasis1.Visibility = Visibility.Visible;
                }
                if (i.NombreCarta == "Oasis2")
                {

                    Oasis2.Margin = new Thickness(0, 0, 0, 0);
                    Oasis2.Visibility = Visibility.Visible;
                }
                if (i.NombreCarta == "Oasis3")
                {

                    Oasis3.Margin = new Thickness(0, 0, 0, 0);
                    Oasis3.Visibility = Visibility.Visible;
                }
                if (i.NombreCarta == "Corehound1")
                {

                    Corehound1.Margin = new Thickness(0, 0, 0, 0);
                    Corehound1.Visibility = Visibility.Visible;
                }
                if (i.NombreCarta == "Corehound2")
                {

                    Corehound2.Margin = new Thickness(0, 0, 0, 0);
                    Corehound2.Visibility = Visibility.Visible;
                }
                if (i.NombreCarta == "Corehound3")
                {

                    Corehound3.Margin = new Thickness(0, 0, 0, 0);
                    Corehound3.Visibility = Visibility.Visible;
                }
                if (i.NombreCarta == "River1")
                {

                    River1.Margin = new Thickness(0, 0, 0, 0);
                    River1.Visibility = Visibility.Visible;
                }
                if (i.NombreCarta == "River2")
                {

                    River2.Margin = new Thickness(0, 0, 0, 0);
                    River2.Visibility = Visibility.Visible;
                }
                if (i.NombreCarta == "River3")
                {
                    River3.Margin = new Thickness(0, 0, 0, 0);
                    River3.Visibility = Visibility.Visible;
                }

                if (i.NombreCarta == "Bloodfen1")
                {

                    Bloodfen1.Margin = new Thickness(0, 0, 0, 0);
                    Bloodfen1.Visibility = Visibility.Visible;

                }
                if (i.NombreCarta == "Bloodfen2")
                {

                    Bloodfen2.Margin = new Thickness(0, 0, 0, 0);
                    Bloodfen2.Visibility = Visibility.Visible;

                }
                if (i.NombreCarta == "Bloodfen3")
                {

                    Bloodfen3.Margin = new Thickness(0, 0, 0, 0);
                    Bloodfen3.Visibility = Visibility.Visible;

                }

                if (i.NombreCarta == "Magma1")
                {

                    Magma1.Margin = new Thickness(0, 0, 0, 0);
                    Magma1.Visibility = Visibility.Visible;
                }
                if (i.NombreCarta == "Magma2")
                {

                    Magma2.Margin = new Thickness(0, 0, 0, 0);
                    Magma2.Visibility = Visibility.Visible;
                }
                if (i.NombreCarta == "Magma3")
                {

                    Magma3.Margin = new Thickness(0, 0, 0, 0);
                    Magma3.Visibility = Visibility.Visible;
                }
                if (i.NombreCarta == "Chillwind1")
                {

                    Chillwind1.Margin = new Thickness(0, 0, 0, 0);
                    Chillwind1.Visibility = Visibility.Visible;

                }
                if (i.NombreCarta == "Chillwind2")
                {

                    Chillwind2.Margin = new Thickness(0, 0, 0, 0);
                    Chillwind2.Visibility = Visibility.Visible;

                }
                if (i.NombreCarta == "Chillwind3")
                {

                    Chillwind3.Margin = new Thickness(0, 0, 0, 0);
                    Chillwind3.Visibility = Visibility.Visible;

                }
                if (i.NombreCarta == "War1")
                {

                    War1.Margin = new Thickness(0, 0, 0, 0);
                    War1.Visibility = Visibility.Visible;

                }
                if (i.NombreCarta == "War2")
                {
                    War2.Margin = new Thickness(0, 0, 0, 0);
                    War2.Visibility = Visibility.Visible;

                }
                if (i.NombreCarta == "War3")
                {

                    War3.Margin = new Thickness(0, 0, 0, 0);
                    War3.Visibility = Visibility.Visible;

                }
                if (i.NombreCarta == "Boulderfist1")
                {

                    Boulderfist1.Margin = new Thickness(0, 0, 0, 0);
                    Boulderfist1.Visibility = Visibility.Visible;
                }
                if (i.NombreCarta == "Boulderfist2")
                {

                    Boulderfist2.Margin = new Thickness(0, 0, 0, 0);
                    Boulderfist2.Visibility = Visibility.Visible;
                }
                if (i.NombreCarta == "Boulderfist3")
                {

                    Boulderfist1.Margin = new Thickness(0, 0, 0, 0);
                    Boulderfist3.Visibility = Visibility.Visible;
                }

                EmpiezaT2.Visibility = Visibility.Hidden;
            }
        }

        private void FinTurno2_Click(object sender, RoutedEventArgs e)
        {
            jugs.Pasar(Heroes[1]);
            cantmana.Visibility = Visibility.Hidden;
            foreach (Minions i in Heroes[0].Tablero1)
            {
                i.Seleccionada = 0;
            }
            foreach (Minions i in Heroes[1].Tablero1)
            {
                i.Seleccionada = 0;
            }
            JugadorUno.Visibility = Visibility.Hidden;
            JugadorDos.Visibility = Visibility.Hidden;
            Mano.Visibility = Visibility.Hidden;
            BarraMano.Visibility = Visibility.Hidden;
            FinTurno2.Visibility = Visibility.Hidden;
            FinTurno1.Visibility = Visibility.Visible;
            EmpiezaT1.Visibility = Visibility.Visible;
            EmpiezaT2.Visibility = Visibility.Hidden;
            Manaj2.Visibility = Visibility.Hidden;
            Atacar.Visibility = Visibility.Hidden;
            HabilidadHeroe.Visibility = Visibility.Hidden;
            if (r2 == 1) { paladinjugador.Visibility = Visibility.Hidden; }
            else if (r2 == 2) { druidajugador.Visibility = Visibility.Hidden; }
            else if (r2 == 3) { cazadorjugador.Visibility = Visibility.Hidden; }
            else if (r2 == 4) { sacerdotejugador.Visibility = Visibility.Hidden; }
            else if (r2 == 5) { picarojugador.Visibility = Visibility.Hidden; }
            else if (r2 == 6) { brujojugador.Visibility = Visibility.Hidden; }
            else if (r2 == 7) { magojugador.Visibility = Visibility.Hidden; }
            else if (r2 == 8) { chamanjugador.Visibility = Visibility.Hidden; }
            else { guerrerojugador.Visibility = Visibility.Hidden; }
            if (r11 == 1) { otropaladin.Visibility = Visibility.Hidden; }
            else if (r11 == 2) { otrodruida.Visibility = Visibility.Hidden; }
            else if (r11 == 3) { otrocazador.Visibility = Visibility.Hidden; }
            else if (r11 == 4) { otrosacerdote.Visibility = Visibility.Hidden; }
            else if (r11 == 5) { otropicaro.Visibility = Visibility.Hidden; }
            else if (r11 == 6) { otrobrujo.Visibility = Visibility.Hidden; }
            else if (r11 == 7) { otromago.Visibility = Visibility.Hidden; }
            else if (r11 == 8) { otrochaman.Visibility = Visibility.Hidden; }
            else { otroguerrero.Visibility = Visibility.Hidden; }
            foreach (Minions i in Heroes[1].mano)
            {
                if (i.NombreCarta == "Wisp1")
                {
                    Wisp1.Visibility = Visibility.Hidden;

                }
                if (i.NombreCarta == "Wisp2")
                {
                    Wisp2.Visibility = Visibility.Hidden;
                }
                if (i.NombreCarta == "Wisp3")
                {
                    Wisp1.Visibility = Visibility.Hidden;
                }
                if (i.NombreCarta == "Murloc1")
                {
                    Murloc1.Visibility = Visibility.Hidden;
                }
                if (i.NombreCarta == "Murloc2")
                {
                    Murloc2.Visibility = Visibility.Hidden;
                }
                if (i.NombreCarta == "Murloc3")
                {
                    Murloc3.Visibility = Visibility.Hidden;
                }
                if (i.NombreCarta == "Oasis1")
                {
                    Oasis1.Visibility = Visibility.Hidden;
                }
                if (i.NombreCarta == "Oasis2")
                {
                    Oasis2.Visibility = Visibility.Hidden;
                }
                if (i.NombreCarta == "Oasis3")
                {
                    Oasis3.Visibility = Visibility.Hidden;
                }
                if (i.NombreCarta == "Corehound1")
                {
                    Corehound1.Visibility = Visibility.Hidden;
                }
                if (i.NombreCarta == "Corehound2")
                {
                    Corehound2.Visibility = Visibility.Hidden;
                }
                if (i.NombreCarta == "Corehound3")
                {
                    Corehound3.Visibility = Visibility.Hidden;
                }
                if (i.NombreCarta == "River1")
                {
                    River1.Visibility = Visibility.Hidden;
                }
                if (i.NombreCarta == "River2")
                {
                    River2.Visibility = Visibility.Hidden;
                }
                if (i.NombreCarta == "River3")
                {
                    River3.Visibility = Visibility.Hidden;
                }

                if (i.NombreCarta == "Bloodfen1")
                {
                    Bloodfen1.Visibility = Visibility.Hidden;
                }
                if (i.NombreCarta == "Bloodfen2")
                {
                    Bloodfen2.Visibility = Visibility.Hidden;
                }
                if (i.NombreCarta == "Bloodfen3")
                {
                    Bloodfen3.Visibility = Visibility.Hidden;
                }
                if (i.NombreCarta == "Magma1")
                {
                    Magma1.Visibility = Visibility.Hidden;
                }
                if (i.NombreCarta == "Magma2")
                {
                    Magma2.Visibility = Visibility.Hidden;
                }
                if (i.NombreCarta == "Magma3")
                {
                    Magma3.Visibility = Visibility.Hidden;
                }
                if (i.NombreCarta == "Chillwind1")
                {
                    Chillwind1.Visibility = Visibility.Hidden;

                }
                if (i.NombreCarta == "Chillwind2")
                {
                    Chillwind2.Visibility = Visibility.Hidden;

                }
                if (i.NombreCarta == "Chillwind3")
                {
                    Chillwind3.Visibility = Visibility.Hidden;

                }
                if (i.NombreCarta == "War1")
                {
                    War1.Visibility = Visibility.Hidden;

                }
                if (i.NombreCarta == "War2")
                {
                    War2.Visibility = Visibility.Hidden;

                }
                if (i.NombreCarta == "War3")
                {
                    War3.Visibility = Visibility.Hidden;

                }
                if (i.NombreCarta == "Boulderfist1")
                {
                    Boulderfist1.Visibility = Visibility.Hidden;
                }
                if (i.NombreCarta == "Boulderfist2")
                {
                    Boulderfist2.Visibility = Visibility.Hidden;
                }
                if (i.NombreCarta == "Boulderfist3")
                {
                    Boulderfist3.Visibility = Visibility.Hidden;
                }

            }



        }

        private void Wisp3_Click(object sender, RoutedEventArgs e)
        {
            if (jugando == 0)
            {
                if (Heroes[0].mano.Contains(wisp3))
                {
                    if (jugs.jugarcartar(Heroes[0], wisp3) == 1)
                    {
                        jugs.jugarcartar(Heroes[0], wisp3);
                        Wisp3.Visibility = Visibility.Hidden;
                        Wisp3j1.Visibility = Visibility.Visible;
                        Manaj1.Value = Heroes[0].Mana;
                        string va = Convert.ToString(Heroes[0].Mana);
                        cantmana.Text = va;
                    }
                }
                else
                {
                    if (wisp3.Seleccionada == 0)
                    { wisp3.Seleccionada = 1;
                        
                    }
                    else { wisp3.Seleccionada = 0; }
                }

                
            }
            else
            {
                if (Heroes[1].mano.Contains(wisp3))
                {

                    if (jugs.jugarcartar(Heroes[1], wisp3) == 1)
                    {
                        jugs.jugarcartar(Heroes[1], wisp3);
                        Wisp3.Visibility = Visibility.Hidden;
                        Wisp3j2.Visibility = Visibility.Visible;
                        Manaj2.Value = Heroes[1].Mana;
                    }
                }
                else
                {
                    if (wisp3.Seleccionada == 0)
                    { wisp3.Seleccionada = 1; }
                    else { wisp3.Seleccionada = 0; }
                }
            }
        }

        private void Bloodfen2_Click(object sender, RoutedEventArgs e)
        {
            if (jugando == 0)
            {
                if (Heroes[0].mano.Contains(bloodfen2))
                {
                    if (jugs.jugarcartar(Heroes[0], bloodfen2) == 1)
                    {
                        jugs.jugarcartar(Heroes[0], bloodfen2);
                        Bloodfen2.Visibility = Visibility.Hidden;
                        Bloodfen2j1.Visibility = Visibility.Visible;
                        Manaj1.Value = Heroes[0].Mana;
                    }
                }
                else
                {
                    if (bloodfen2.Seleccionada == 0)
                    { bloodfen2.Seleccionada = 1; }
                    else { bloodfen2.Seleccionada = 0; }
                }

                
            }
            else
            {
                if (Heroes[1].mano.Contains(bloodfen2))
                {

                    if (jugs.jugarcartar(Heroes[1], bloodfen2) == 1)
                    {
                        jugs.jugarcartar(Heroes[1], bloodfen2);
                        Bloodfen2.Visibility = Visibility.Hidden;
                        Bloodfen2j2.Visibility = Visibility.Visible;
                        Manaj2.Value = Heroes[1].Mana;
                    }
                }
                else
                {
                    if (bloodfen2.Seleccionada == 0)
                    { bloodfen2.Seleccionada = 1; }
                    else { bloodfen2.Seleccionada = 0; }
                }
            }

        }

        private void Wisp1_Click(object sender, RoutedEventArgs e)
        {
            if (jugando == 0)
            {
                if (Heroes[0].mano.Contains(wisp1))
                {
                    if (jugs.jugarcartar(Heroes[0], wisp1) == 1)
                    {
                       jugs.jugarcartar(Heroes[0], wisp1);
                        Wisp1.Visibility = Visibility.Hidden;
                        Wisp1.Visibility = Visibility.Visible;
                        Manaj1.Value = Heroes[0].Mana;
                    }
                }
                else
                {
                    if (wisp1.Seleccionada == 0)
                    { wisp1.Seleccionada = 1; }
                    else { wisp1.Seleccionada = 0; }
                }

                
            }
            else
            {
                if (Heroes[1].mano.Contains(wisp1))
                {

                    if (jugs.jugarcartar(Heroes[1], wisp1) == 1)
                    {
                        jugs.jugarcartar(Heroes[1], wisp1);
                        Wisp1.Visibility = Visibility.Hidden;
                        Wisp1j2.Visibility = Visibility.Visible;
                        Manaj2.Value = Heroes[1].Mana;
                    }
                }
                else
                {
                    if (wisp1.Seleccionada == 0)
                    { wisp1.Seleccionada = 1; }
                    else { wisp1.Seleccionada = 0; }
                }
            }

        }

        private void Wisp2_Click(object sender, RoutedEventArgs e)
        {
            if (jugando == 0)
            {
                if (Heroes[0].mano.Contains(wisp2))
                {
                    if (jugs.jugarcartar(Heroes[0], wisp2) == 1)
                    {
                        jugs.jugarcartar(Heroes[0], wisp2);
                        Wisp2.Visibility = Visibility.Hidden;
                        Wisp2j1.Visibility = Visibility.Visible;
                        Manaj1.Value = Heroes[0].Mana;
                    }
                }
                else
                {
                    if (wisp2.Seleccionada == 0)
                    { wisp2.Seleccionada = 1; }
                    else { wisp2.Seleccionada = 0; }
                }

                

            }
            else
            {
                if (Heroes[1].mano.Contains(wisp2))
                {

                    if (jugs.jugarcartar(Heroes[1], wisp2) == 1)
                    {
                        jugs.jugarcartar(Heroes[1], wisp2);
                        Wisp2.Visibility = Visibility.Hidden;
                        Wisp2j2.Visibility = Visibility.Visible;
                        Manaj2.Value = Heroes[1].Mana;
                    }
                }
                else
                {
                    if (wisp2.Seleccionada == 0)
                    { wisp2.Seleccionada = 1; }
                    else { wisp2.Seleccionada = 0; }
                }
            }

        }

        private void Bloodfen1_Click(object sender, RoutedEventArgs e)
        {
            if (jugando == 0)
            {
                if (Heroes[0].mano.Contains(bloodfen1))
                {
                    if (jugs.jugarcartar(Heroes[0], bloodfen1) == 1)
                    {
                        jugs.jugarcartar(Heroes[0], bloodfen1);
                        Bloodfen1.Visibility = Visibility.Hidden;
                        Bloodfen1j1.Visibility = Visibility.Visible;
                        Manaj1.Value = Heroes[0].Mana;
                    }
                }
                else
                {
                    if (bloodfen1.Seleccionada == 0)
                    { bloodfen1.Seleccionada = 1; }
                    else { bloodfen1.Seleccionada = 0; }
                }

                

            }
            else
            {
                if (Heroes[1].mano.Contains(bloodfen1))
                {

                    if (jugs.jugarcartar(Heroes[1], bloodfen1) == 1)
                    {
                        jugs.jugarcartar(Heroes[1], bloodfen1);
                        Bloodfen1.Visibility = Visibility.Hidden;
                        Bloodfen1j2.Visibility = Visibility.Visible;
                        Manaj2.Value = Heroes[1].Mana;
                    }
                }
                else
                {
                    if (bloodfen1.Seleccionada == 0)
                    { bloodfen1.Seleccionada = 1; }
                    else { bloodfen1.Seleccionada = 0; }
                }
            }

        }

        private void Bloodfen3_Click(object sender, RoutedEventArgs e)
        {
            if (jugando == 0)
            {
                if (Heroes[0].mano.Contains(bloodfen3))
                {
                    if (jugs.jugarcartar(Heroes[0], bloodfen3) == 1)
                    {
                        jugs.jugarcartar(Heroes[0], bloodfen3);
                        Bloodfen3.Visibility = Visibility.Hidden;
                        Bloodfen3j1.Visibility = Visibility.Visible;
                        Manaj1.Value = Heroes[0].Mana;
                    }
                }
                else
                {
                    if (bloodfen3.Seleccionada == 0)
                    { bloodfen3.Seleccionada = 1; }
                    else { bloodfen3.Seleccionada = 0; }
                }

                
            }
            else
            {
                if (Heroes[1].mano.Contains(bloodfen3))
                {

                    if (jugs.jugarcartar(Heroes[1], bloodfen3) == 1)
                    {
                        jugs.jugarcartar(Heroes[1], bloodfen3);
                        Bloodfen3.Visibility = Visibility.Hidden;
                        Bloodfen3j2.Visibility = Visibility.Visible;
                        Manaj2.Value = Heroes[1].Mana;
                    }
                }
                else
                {
                    if (bloodfen3.Seleccionada == 0)
                    { bloodfen3.Seleccionada = 1; }
                    else { bloodfen3.Seleccionada = 0; }
                }
            }
        }

        private void Boulderfist1_Click(object sender, RoutedEventArgs e)
        {
            if (jugando == 0)
            {
                if (Heroes[0].mano.Contains(boulderfist1))
                {
                    if (jugs.jugarcartar(Heroes[0], boulderfist1) == 1)
                    {
                        jugs.jugarcartar(Heroes[0], boulderfist1);
                        Boulderfist1.Visibility = Visibility.Hidden;
                        Boulderfist1j1.Visibility = Visibility.Visible;
                        Manaj1.Value = Heroes[0].Mana;
                    }
                }
                else
                {
                    if (boulderfist1.Seleccionada == 0)
                    { boulderfist1.Seleccionada = 1; }
                    else { boulderfist1.Seleccionada = 0; }
                }

                
            }
            else
            {
                if (Heroes[1].mano.Contains(boulderfist1))
                {

                    if (jugs.jugarcartar(Heroes[1], boulderfist1) == 1)
                    {
                        jugs.jugarcartar(Heroes[1], boulderfist1);
                        Boulderfist1.Visibility = Visibility.Hidden;
                        Boulderfist1j2.Visibility = Visibility.Visible;
                        Manaj2.Value = Heroes[1].Mana;
                    }
                }
                else
                {
                    if (boulderfist1.Seleccionada == 0)
                    { boulderfist1.Seleccionada = 1; }
                    else { boulderfist1.Seleccionada = 0; }
                }
            }
        }

        private void Boulderfist2_Click(object sender, RoutedEventArgs e)
        {
            if (jugando == 0)
            {
                if (Heroes[0].mano.Contains(boulderfist2))
                {
                    if (jugs.jugarcartar(Heroes[0], boulderfist2) == 1)
                    {
                        jugs.jugarcartar(Heroes[0], boulderfist2);
                        Boulderfist2.Visibility = Visibility.Hidden;
                        Boulderfist2j1.Visibility = Visibility.Visible;
                        Manaj1.Value = Heroes[0].Mana;
                    }
                }
                else
                {
                    if (boulderfist2.Seleccionada == 0)
                    { boulderfist2.Seleccionada = 1; }
                    else { boulderfist2.Seleccionada = 0; }
                }

                
            }
            else
            {
                if (Heroes[1].mano.Contains(boulderfist2))
                {

                    if (jugs.jugarcartar(Heroes[1], boulderfist2) == 1)
                    {
                        jugs.jugarcartar(Heroes[1], boulderfist2);
                        Boulderfist2.Visibility = Visibility.Hidden;
                        Boulderfist2j2.Visibility = Visibility.Visible;
                        Manaj2.Value = Heroes[1].Mana;
                    }
                }
                else
                {
                    if (boulderfist2.Seleccionada == 0)
                    { boulderfist2.Seleccionada = 1; }
                    else { boulderfist2.Seleccionada = 0; }
                }
            }
        }

        private void Boulderfist3_Click(object sender, RoutedEventArgs e)
        {
            if (jugando == 0)
            {
                if (Heroes[0].mano.Contains(boulderfist3))
                {
                    if (jugs.jugarcartar(Heroes[0], boulderfist3) == 1)
                    {
                        jugs.jugarcartar(Heroes[0], boulderfist3);
                        Boulderfist3.Visibility = Visibility.Hidden;
                        Boulderfist3j1.Visibility = Visibility.Visible;
                        Manaj1.Value = Heroes[0].Mana;
                    }
                }
                else
                {
                    if (boulderfist3.Seleccionada == 0)
                    { boulderfist3.Seleccionada = 1; }
                    else { boulderfist3.Seleccionada = 0; }
                }

                
            }
            else
            {
                if (Heroes[1].mano.Contains(boulderfist3))
                {

                    if (jugs.jugarcartar(Heroes[1], boulderfist3) == 1)
                    {
                        jugs.jugarcartar(Heroes[1], boulderfist3);
                        Boulderfist3.Visibility = Visibility.Hidden;
                        Boulderfist3j2.Visibility = Visibility.Visible;
                        Manaj2.Value = Heroes[1].Mana;
                    }
                }
                else
                {
                    if (boulderfist3.Seleccionada == 0)
                    { boulderfist3.Seleccionada = 1; }
                    else { boulderfist3.Seleccionada = 0; }
                }
            }
        }

        private void Chillwind1_Click(object sender, RoutedEventArgs e)
        {
            if (jugando == 0)
            {
                if (Heroes[0].mano.Contains(chillwind1))
                {
                    if (jugs.jugarcartar(Heroes[0], chillwind1) == 1)
                    {
                        jugs.jugarcartar(Heroes[0], chillwind1);
                        Chillwind1.Visibility = Visibility.Hidden;
                        Chillwind1j1.Visibility = Visibility.Visible;
                        Manaj1.Value = Heroes[0].Mana;
                    }
                }
                else
                {
                    if (chillwind1.Seleccionada == 0)
                    { chillwind1.Seleccionada = 1; }
                    else { chillwind1.Seleccionada = 0; }
                }

                
            }
            else
            {
                if (Heroes[1].mano.Contains(chillwind1))
                {

                    if (jugs.jugarcartar(Heroes[1], chillwind1) == 1)
                    {
                        jugs.jugarcartar(Heroes[1], chillwind1);
                        Chillwind1.Visibility = Visibility.Hidden;
                        Chillwind1j2.Visibility = Visibility.Visible;
                        Manaj2.Value = Heroes[1].Mana;
                    }
                }
                else
                {
                    if (chillwind1.Seleccionada == 0)
                    { chillwind1.Seleccionada = 1; }
                    else { chillwind1.Seleccionada = 0; }
                }
            }
        }

        private void Chillwind2_Click(object sender, RoutedEventArgs e)
        {
            if (jugando == 0)
            {
                if (Heroes[0].mano.Contains(chillwind2))
                {
                    if (jugs.jugarcartar(Heroes[0], chillwind2) == 1)
                    {
                        jugs.jugarcartar(Heroes[0], chillwind2);
                        Chillwind2.Visibility = Visibility.Hidden;
                        Chillwind2j1.Visibility = Visibility.Visible;
                        Manaj1.Value = Heroes[0].Mana;
                    }
                }
                else
                {
                    if (chillwind2.Seleccionada == 0)
                    { chillwind2.Seleccionada = 1; }
                    else { chillwind2.Seleccionada = 0; }
                }

                
            }
            else
            {
                if (Heroes[1].mano.Contains(chillwind2))
                {

                    if (jugs.jugarcartar(Heroes[1], chillwind2) == 1)
                    {
                        jugs.jugarcartar(Heroes[1], chillwind2);
                        Chillwind2.Visibility = Visibility.Hidden;
                        Chillwind2j2.Visibility = Visibility.Visible;
                        Manaj2.Value = Heroes[1].Mana;
                    }
                }
                else
                {
                    if (chillwind2.Seleccionada == 0)
                    { chillwind2.Seleccionada = 1; }
                    else { chillwind2.Seleccionada = 0; }
                }
            }
        }

        private void Chillwind3_Click(object sender, RoutedEventArgs e)
        {
            if (jugando == 0)
            {
                if (Heroes[0].mano.Contains(chillwind3))
                {
                    if (jugs.jugarcartar(Heroes[0], chillwind3) == 1)
                    {
                        jugs.jugarcartar(Heroes[0], chillwind3);
                        Chillwind3.Visibility = Visibility.Hidden;
                        Chillwind3j1.Visibility = Visibility.Visible;
                        Manaj1.Value = Heroes[0].Mana;
                    }
                }
                else
                {
                    if (chillwind3.Seleccionada == 0)
                    { chillwind3.Seleccionada = 1; }
                    else { chillwind3.Seleccionada = 0; }
                }

                
            }
            else
            {
                if (Heroes[1].mano.Contains(chillwind3))
                {

                    if (jugs.jugarcartar(Heroes[1], chillwind3) == 1)
                    {
                        jugs.jugarcartar(Heroes[1], chillwind3);
                        Chillwind3.Visibility = Visibility.Hidden;
                        Chillwind3j2.Visibility = Visibility.Visible;
                        Manaj2.Value = Heroes[1].Mana;
                    }
                }
                else
                {
                    if (chillwind3.Seleccionada == 0)
                    { chillwind3.Seleccionada = 1; }
                    else { chillwind3.Seleccionada = 0; }
                }
            }
        }

        private void Corehound1_Click(object sender, RoutedEventArgs e)
        {
            if (jugando == 0)
            {
                if (Heroes[0].mano.Contains(core1))
                {
                    if (jugs.jugarcartar(Heroes[0], core1) == 1)
                    {
                        jugs.jugarcartar(Heroes[0], core1);

                        Corehound1.Visibility = Visibility.Hidden;
                        Corehound1j1.Visibility = Visibility.Visible;
                        Manaj1.Value = Heroes[0].Mana;
                    }
                }
                else
                {
                    if (core1.Seleccionada == 0)
                    { core1.Seleccionada = 1; }
                    else { core1.Seleccionada = 0; }
                }

                
            }
            else
            {
                if (Heroes[1].mano.Contains(core1))
                {

                    if (jugs.jugarcartar(Heroes[1], core1) == 1)
                    {
                        jugs.jugarcartar(Heroes[1], core1);
                        Corehound1.Visibility = Visibility.Hidden;
                        Corehound1j2.Visibility = Visibility.Visible;
                        Manaj2.Value = Heroes[1].Mana;
                    }
                }
                else
                {
                    if (core1.Seleccionada == 0)
                    { core1.Seleccionada = 1; }
                    else { core1.Seleccionada = 0; }
                }
            }
        }

        private void Corehound2_Click(object sender, RoutedEventArgs e)
        {
            if (jugando == 0)
            {

                if (Heroes[0].mano.Contains(core2))
                {
                    if (jugs.jugarcartar(Heroes[0], core2) == 1)
                    {
                        jugs.jugarcartar(Heroes[0], core2);
                        Corehound2.Visibility = Visibility.Hidden;
                        Corehound2j1.Visibility = Visibility.Visible;
                        Manaj1.Value = Heroes[0].Mana;
                    }
                }
                else
                {
                    if (core2.Seleccionada == 0)
                    { core2.Seleccionada = 1; }
                    else { core2.Seleccionada = 0; }
                }

                   
                
            }
            else
            {
                if (Heroes[1].mano.Contains(core2))
                {

                    if (jugs.jugarcartar(Heroes[1], core2) == 1)
                    {
                        jugs.jugarcartar(Heroes[1], core2);
                        Corehound2.Visibility = Visibility.Hidden;
                        Corehound2j2.Visibility = Visibility.Visible;
                        Manaj2.Value = Heroes[1].Mana;
                    }
                }
                else
                {
                    if (core2.Seleccionada == 0)
                    { core2.Seleccionada = 1; }
                    else { core2.Seleccionada = 0; }
                }
            }
        }

        private void Corehound3_Click(object sender, RoutedEventArgs e)
        {
            if (jugando == 0)
            {
                if (Heroes[0].mano.Contains(core3))
                {
                    if (jugs.jugarcartar(Heroes[0], core3) == 1)
                    {
                        jugs.jugarcartar(Heroes[0], core3);
                        Corehound3.Visibility = Visibility.Hidden;
                        Corehound3j1.Visibility = Visibility.Visible;
                        Manaj1.Value = Heroes[0].Mana;
                    }
                }
                else
                {
                    if (core3.Seleccionada == 0)
                    { core3.Seleccionada = 1; }
                    else { core3.Seleccionada = 0; }
                }

                
            }
            else
            {
                if (Heroes[1].mano.Contains(core3))
                {

                    if (jugs.jugarcartar(Heroes[1], core3) == 1)
                    {
                        jugs.jugarcartar(Heroes[1], core3);
                        Corehound3.Visibility = Visibility.Hidden;
                        Corehound3j2.Visibility = Visibility.Visible;
                        Manaj2.Value = Heroes[1].Mana;
                    }
                }
                else
                {
                    if (core3.Seleccionada == 0)
                    { core3.Seleccionada = 1; }
                    else { core3.Seleccionada = 0; }
                }
            }
        }

        private void Magma1_Click(object sender, RoutedEventArgs e)
        {
            if (jugando == 0)
            {
                if (Heroes[0].mano.Contains(magma1))
                {
                    if (jugs.jugarcartar(Heroes[0], magma1) == 1)
                    {
                        jugs.jugarcartar(Heroes[0], magma1);
                        Magma1.Visibility = Visibility.Hidden;
                        Magma1j1.Visibility = Visibility.Visible;
                        Manaj1.Value = Heroes[0].Mana;
                    }
                }
                else
                {
                    if (magma1.Seleccionada == 0)
                    { magma1.Seleccionada = 1; }
                    else { magma1.Seleccionada = 0; }
                }

               
            }
            else
            {
                if (Heroes[1].mano.Contains(magma1))
                {

                    if (jugs.jugarcartar(Heroes[1], magma1) == 1)
                    {
                        jugs.jugarcartar(Heroes[1], magma1);
                        Magma1.Visibility = Visibility.Hidden;
                        Magma1j2.Visibility = Visibility.Visible;
                        Manaj2.Value = Heroes[1].Mana;
                    }
                }
                else
                {
                    if (magma1.Seleccionada == 0)
                    { magma1.Seleccionada = 1; }
                    else { magma1.Seleccionada = 0; }
                }
            }
        }

        private void Magma2_Click(object sender, RoutedEventArgs e)
        {
            if (jugando == 0)
            {
                if (Heroes[0].mano.Contains(magma2))
                {
                    if (jugs.jugarcartar(Heroes[0], magma2) == 1)
                    {
                        jugs.jugarcartar(Heroes[0], magma2);
                        Magma2.Visibility = Visibility.Hidden;
                        Magma2j1.Visibility = Visibility.Visible;
                        Manaj1.Value = Heroes[0].Mana;
                    }
                }
                else
                {
                    if (magma2.Seleccionada == 0)
                    { magma2.Seleccionada = 1; }
                    else { magma2.Seleccionada = 0; }
                }

                
            }
            else
            {
                if (Heroes[1].mano.Contains(magma2))
                {

                    if (jugs.jugarcartar(Heroes[1], magma2) == 1)
                    {
                        jugs.jugarcartar(Heroes[1], magma2);
                        Magma2.Visibility = Visibility.Hidden;
                        Magma2j2.Visibility = Visibility.Visible;
                        Manaj2.Value = Heroes[1].Mana;
                    }
                }
                else
                {
                    if (magma2.Seleccionada == 0)
                    { magma2.Seleccionada = 1; }
                    else { magma2.Seleccionada = 0; }
                }
            }
        }

        private void Magma3_Click(object sender, RoutedEventArgs e)
        {
            if (jugando == 0)
            {
                if (Heroes[0].mano.Contains(magma3))
                {
                    if (jugs.jugarcartar(Heroes[0], magma3) == 1)
                    {
                        jugs.jugarcartar(Heroes[0], magma3);
                        Magma3.Visibility = Visibility.Hidden;
                        Magma3j1.Visibility = Visibility.Visible;
                        Manaj1.Value = Heroes[0].Mana;
                    }
                }
                else
                {
                    if (magma3.Seleccionada == 0)
                    { magma3.Seleccionada = 1; }
                    else { magma3.Seleccionada = 0; }
                }

                
            }
            else
            {
                if (Heroes[1].mano.Contains(magma3))
                {

                    if (jugs.jugarcartar(Heroes[1], magma3) == 1)
                    {
                        jugs.jugarcartar(Heroes[0], magma3);
                        Magma3.Visibility = Visibility.Hidden;
                        Magma3j2.Visibility = Visibility.Visible;
                        Manaj2.Value = Heroes[1].Mana;
                    }
                }
                else
                {

                    if (magma3.Seleccionada == 0)
                    { magma3.Seleccionada = 1; }
                    else { magma3.Seleccionada = 0; }
                }
            }
        }

        private void Murloc1_Click(object sender, RoutedEventArgs e)
        {
            if (jugando == 0)
            {
                if (Heroes[0].mano.Contains(murloc1))
                {
                    if (jugs.jugarcartar(Heroes[0], murloc1) == 1)
                    {
                        jugs.jugarcartar(Heroes[0], murloc1);
                        Murloc1.Visibility = Visibility.Hidden;
                        Murloc1j1.Visibility = Visibility.Visible;
                        Manaj1.Value = Heroes[0].Mana;
                    }
                }
                else
                {
                    if (murloc1.Seleccionada == 0)
                    { murloc1.Seleccionada = 1; }
                    else { murloc1.Seleccionada = 0; }
                }

                
            }
            else
            {
                if (Heroes[1].mano.Contains(murloc1))
                {

                    if (jugs.jugarcartar(Heroes[1], murloc1) == 1)
                    {
                        jugs.jugarcartar(Heroes[1], murloc1);
                        Murloc1.Visibility = Visibility.Hidden;
                        Murloc1j2.Visibility = Visibility.Visible;
                        Manaj2.Value = Heroes[1].Mana;
                    }
                }
                else
                {
                    if (murloc1.Seleccionada == 0)
                    { murloc1.Seleccionada = 1; }
                    else { murloc1.Seleccionada = 0; }
                }
            }
        }

        private void Murloc2_Click(object sender, RoutedEventArgs e)
        {
            if (jugando == 0)
            {
                if (Heroes[0].mano.Contains(murloc2))
                {
                    if (jugs.jugarcartar(Heroes[0], murloc2) == 1)
                    {
                        jugs.jugarcartar(Heroes[0], murloc2);
                        Murloc2.Visibility = Visibility.Hidden;
                        Murloc2j1.Visibility = Visibility.Visible;
                        Manaj1.Value = Heroes[0].Mana;
                    }
                }
                else
                {
                    if (murloc2.Seleccionada == 0)
                    { murloc2.Seleccionada = 1; }
                    else { murloc2.Seleccionada = 0; }
                }

                
            }
            else
            {
                if (Heroes[1].mano.Contains(murloc2))
                {

                    if (jugs.jugarcartar(Heroes[1], murloc2) == 1)
                    {
                        jugs.jugarcartar(Heroes[1], murloc2);
                        Murloc2.Visibility = Visibility.Hidden;
                        Murloc2j2.Visibility = Visibility.Visible;
                        Manaj2.Value = Heroes[1].Mana;
                    }
                }
                else
                {
                    if (murloc2.Seleccionada == 0)
                    { murloc2.Seleccionada = 1; }
                    else { murloc2.Seleccionada = 0; }
                }
            }
        }

        private void Murloc3_Click(object sender, RoutedEventArgs e)
        {
            if (jugando == 0)
            {
                if (Heroes[0].mano.Contains(murloc3))
                {
                    if (jugs.jugarcartar(Heroes[0], murloc3) == 1)
                    {
                        jugs.jugarcartar(Heroes[0], murloc3);
                        Murloc3.Visibility = Visibility.Hidden;
                        Murloc3j1.Visibility = Visibility.Visible;
                        Manaj1.Value = Heroes[0].Mana;
                    }
                }
                else
                {
                    if (murloc3.Seleccionada == 0)
                    { murloc3.Seleccionada = 1; }
                    else { murloc3.Seleccionada = 0; }
                }

                
            }
            else
            {
                if (Heroes[1].mano.Contains(murloc3))
                {

                    if (jugs.jugarcartar(Heroes[1], murloc3) == 1)
                    {
                        jugs.jugarcartar(Heroes[1], murloc3); 
                        Murloc3.Visibility = Visibility.Hidden;
                        Murloc3j2.Visibility = Visibility.Visible;
                        Manaj2.Value = Heroes[1].Mana;
                    }
                }
                else
                {
                    if (murloc3.Seleccionada == 0)
                    { murloc3.Seleccionada = 1; }
                    else { murloc3.Seleccionada = 0; }
                }
            }
        }

        private void Oasis1_Click(object sender, RoutedEventArgs e)
        {
            if (jugando == 0)
            {
                if (Heroes[0].mano.Contains(oasis1))
                {
                    if (jugs.jugarcartar(Heroes[0], oasis1) == 1)
                    {
                        jugs.jugarcartar(Heroes[0], oasis1);
                        Oasis1.Visibility = Visibility.Hidden;
                        Oasis1j1.Visibility = Visibility.Visible;
                        Manaj1.Value = Heroes[0].Mana;
                    }
                }
                else
                {
                    if (oasis1.Seleccionada == 0)
                    {
                        oasis1.Seleccionada = 1;
                    }
                    else { oasis1.Seleccionada = 0; }
                }

            }
            else
            {
                if (Heroes[1].mano.Contains(oasis1))
                {

                    if (jugs.jugarcartar(Heroes[1], oasis1) == 1)
                    {
                        jugs.jugarcartar(Heroes[1], oasis1);
                        Oasis1.Visibility = Visibility.Hidden;
                        Oasis1j2.Visibility = Visibility.Visible;
                        Manaj2.Value = Heroes[1].Mana;
                    }
                }
                else
                {
                    if (oasis1.Seleccionada == 0)
                    { oasis1.Seleccionada = 1; }
                    else { oasis1.Seleccionada = 0; }
                }
            }
            
        }

        private void Oasis2_Click(object sender, RoutedEventArgs e)
        {
            if (jugando == 0)
            {
                if (Heroes[0].mano.Contains(oasis2))
                {
                    if (jugs.jugarcartar(Heroes[0], oasis2) == 1)
                    {
                        jugs.jugarcartar(Heroes[0], oasis2);
                        Oasis2.Visibility = Visibility.Hidden;
                        Oasis2j1.Visibility = Visibility.Visible;
                        Manaj1.Value = Heroes[0].Mana;
                    }
                }
                else
                {
                    if (oasis2.Seleccionada == 0)
                    {
                        oasis2.Seleccionada = 1;
                    }
                    else { oasis2.Seleccionada = 0; }
                }

                
            }
            else
            {
                if (Heroes[1].mano.Contains(oasis2))
                {

                    if (jugs.jugarcartar(Heroes[1], oasis2) == 1)
                    {
                        jugs.jugarcartar(Heroes[1], oasis2);
                        Oasis2.Visibility = Visibility.Hidden;
                        Oasis2j2.Visibility = Visibility.Visible;
                        Manaj2.Value = Heroes[1].Mana;
                    }
                }
                else
                {
                    if (oasis2.Seleccionada == 0)
                    { oasis2.Seleccionada = 1; }
                    else { oasis2.Seleccionada = 0; }
                }
            }
        }

        private void Oasis3_Click(object sender, RoutedEventArgs e)
        {
            if (jugando == 0)
            {
                if (Heroes[0].mano.Contains(oasis3))
                {
                    if (jugs.jugarcartar(Heroes[0], oasis3) == 1)
                    {
                        jugs.jugarcartar(Heroes[0], oasis3);
                        Oasis3.Visibility = Visibility.Hidden;
                        Oasis3j1.Visibility = Visibility.Visible;
                        Manaj1.Value = Heroes[0].Mana;
                    }
                }
                else
                {
                    if (oasis3.Seleccionada == 0)
                    {
                        oasis3.Seleccionada = 1;
                    }
                    else { oasis3.Seleccionada = 0; }
                }

                
            }
            else
            {
                if (Heroes[1].mano.Contains(oasis3))
                {

                    if (jugs.jugarcartar(Heroes[1], oasis3) == 1)
                    {
                        jugs.jugarcartar(Heroes[1], oasis3);
                        Oasis3.Visibility = Visibility.Hidden;
                        Oasis3j2.Visibility = Visibility.Visible;
                        Manaj2.Value = Heroes[1].Mana;
                    }
                }
                else
                {
                    if (oasis3.Seleccionada == 0)
                    { oasis3.Seleccionada = 1; }
                    else { oasis3.Seleccionada = 0; }
                }
            }
        }

        private void River1_Click(object sender, RoutedEventArgs e)
        {
            if (jugando == 0)
            {
                if (Heroes[0].mano.Contains(river1))
                {
                    if (jugs.jugarcartar(Heroes[0], river1) == 1)
                    {
                        jugs.jugarcartar(Heroes[0], river1);
                        River1.Visibility = Visibility.Hidden;
                        River1j1.Visibility = Visibility.Visible;
                        Manaj1.Value = Heroes[0].Mana;
                    }
                }
                else
                {
                    if (river1.Seleccionada == 0)
                    {
                        river1.Seleccionada = 1;
                    }
                    else { river1.Seleccionada = 0; }
                }

                
            }
            else
            {
                if (Heroes[1].mano.Contains(river1))
                {

                    if (jugs.jugarcartar(Heroes[1], river1) == 1)
                    {
                        jugs.jugarcartar(Heroes[1], river1);
                        River1.Visibility = Visibility.Hidden;
                        River1j2.Visibility = Visibility.Visible;
                        Manaj2.Value = Heroes[1].Mana;
                    }
                }
                else
                {
                    if (river1.Seleccionada == 0)
                    { river1.Seleccionada = 1; }
                    else { river1.Seleccionada = 0; }
                }
            }
        }

        private void River2_Click(object sender, RoutedEventArgs e)
        {
            if (jugando == 0)
            {
                if (Heroes[0].mano.Contains(river2))
                {
                    
                    if (jugs.jugarcartar(Heroes[0], river2) == 1)
                    {
                        jugs.jugarcartar(Heroes[0], river2);
                        River2.Visibility = Visibility.Hidden;
                        River2j1.Visibility = Visibility.Visible;
                        Manaj1.Value = Heroes[0].Mana;
                    }
                }

               else
                {
                    if (river2.Seleccionada == 0)
                    {
                        river2.Seleccionada = 1;
                    }
                    else { river2.Seleccionada = 0; }
                }

                
            }
            else
            {
                if (Heroes[1].mano.Contains(river2))
                {

                    if (jugs.jugarcartar(Heroes[1], river2) == 1)
                    {
                        jugs.jugarcartar(Heroes[1], river2);
                        River2.Visibility = Visibility.Hidden;
                        River2j2.Visibility = Visibility.Visible;
                        Manaj2.Value = Heroes[1].Mana;
                    }
                }
                else
                {
                    if (river2.Seleccionada == 0)
                    { river2.Seleccionada = 1; }
                    else { river2.Seleccionada = 0; }
                }
            }
        }

        private void River3_Click(object sender, RoutedEventArgs e)
        {
            if (jugando == 0)
            {
                if (Heroes[0].mano.Contains(river3))
                {
                    if (jugs.jugarcartar(Heroes[0], river3) == 1)
                    {
                        jugs.jugarcartar(Heroes[0], river3);
                        River3.Visibility = Visibility.Hidden;
                        River3j1.Visibility = Visibility.Visible;
                        Manaj1.Value = Heroes[0].Mana;
                    }
                }
                else
                {
                    if (river3.Seleccionada == 0)
                    {
                        river3.Seleccionada = 1;
                    }
                    else { river3.Seleccionada = 0; }
                }

                
            }
            else
            {
                if (Heroes[1].mano.Contains(river3))
                {

                    if (jugs.jugarcartar(Heroes[1], river3) == 1)
                    {
                        jugs.jugarcartar(Heroes[1], river3);
                        River3.Visibility = Visibility.Hidden;
                        River3j2.Visibility = Visibility.Visible;
                        Manaj2.Value = Heroes[1].Mana;
                    }
                }
                else
                {
                    if (river3.Seleccionada == 0)
                    { river3.Seleccionada = 1; }
                    else { river3.Seleccionada = 0; }
                }
            }
        }

        private void War1_Click(object sender, RoutedEventArgs e)
        {
            if (jugando == 0)
            {
                if (Heroes[0].mano.Contains(war1))
                {
                    if (jugs.jugarcartar(Heroes[0], war1) == 1)
                    {
                        jugs.jugarcartar(Heroes[0], war1);
                        War1.Visibility = Visibility.Hidden;
                        War1j1.Visibility = Visibility.Visible;
                        Manaj1.Value = Heroes[0].Mana;
                    }
                }
                else
                {
                    if (war1.Seleccionada == 0)
                    {
                        war1.Seleccionada = 1;
                    }
                    else { war1.Seleccionada = 0; }
                }

                
            }
            else
            {
                if (Heroes[1].mano.Contains(war1))
                {

                    if (jugs.jugarcartar(Heroes[1], war1) == 1)
                    {
                        jugs.jugarcartar(Heroes[1], war1);
                        War1.Visibility = Visibility.Hidden;
                        War1j2.Visibility = Visibility.Visible;
                        Manaj2.Value = Heroes[1].Mana;
                    }
                }
                else
                {
                    if (war1.Seleccionada == 0)
                    { war1.Seleccionada = 1; }
                    else { war1.Seleccionada = 0; }
                }
            }
        }

        private void War2_Click(object sender, RoutedEventArgs e)
        {
            if (jugando == 0)
            {

                if (Heroes[0].mano.Contains(war2))
                {
                    if (jugs.jugarcartar(Heroes[0], war2) == 1)
                    {
                        jugs.jugarcartar(Heroes[0], war2);
                        War2.Visibility = Visibility.Hidden;
                        War2j1.Visibility = Visibility.Visible;
                        Manaj1.Value = Heroes[0].Mana;
                    }
                }
                else
                {
                    if (war2.Seleccionada == 0)
                    {
                        war2.Seleccionada = 1;
                    }
                    else { war2.Seleccionada = 0; }
                }
            }
            else
            {
                if (Heroes[1].mano.Contains(war2))
                {

                    if (jugs.jugarcartar(Heroes[1], war2) == 1)
                    {
                        jugs.jugarcartar(Heroes[1], war2);
                        War2.Visibility = Visibility.Hidden;
                        War2j2.Visibility = Visibility.Visible;
                        Manaj2.Value = Heroes[1].Mana;
                    }
                }
                else
                {
                    if (war2.Seleccionada == 0)
                    { war2.Seleccionada = 1; }
                    else { war2.Seleccionada = 0; }
                }

            }
        }

        private void War3_Click(object sender, RoutedEventArgs e)
        {
            if (jugando == 0)
            {
                if (Heroes[0].mano.Contains(war3))
                {
                    if (jugs.jugarcartar(Heroes[0], war3) == 1)
                    {
                        jugs.jugarcartar(Heroes[0], war3);
                        War3.Visibility = Visibility.Hidden;
                        War3j1.Visibility = Visibility.Visible;
                        Manaj1.Value = Heroes[0].Mana;
                    }
                }
                else
                {
                    if (war3.Seleccionada == 0)
                    {
                        war3.Seleccionada = 1;
                    }
                    else { war3.Seleccionada = 0; }
                }

                
            }
            else
            {
                if (Heroes[1].mano.Contains(war3))
                {

                    if (jugs.jugarcartar(Heroes[1], war3) == 1)
                    {
                        jugs.jugarcartar(Heroes[1], war3);
                        War3.Visibility = Visibility.Hidden;
                        War3j2.Visibility = Visibility.Visible;
                        Manaj2.Value = Heroes[1].Mana;
                    }
                }
                else
                {
                    if (war3.Seleccionada == 0)
                    { war3.Seleccionada = 1; }
                    else { war3.Seleccionada = 0; }
                }
            }
        }

        private void Atacar_Click(object sender, RoutedEventArgs e)
        {
            int con = 0;
            if (jugando == 0)
            {
                foreach (Minions ad in Heroes[0].Tablero1)
                {

                    if (ad.Seleccionada == 1)

                    {

                        foreach (Minions af in Heroes[1].Tablero1)
                        {
                            if (af.Seleccionada == 1)
                            {

                                ad.RestarVidaMs(ad, af, Heroes[0].Tablero1, Heroes[1].Tablero1);
                                MessageBox.Show(Convert.ToString(Heroes[0].Tablero1.Count()));
                                MessageBox.Show(Convert.ToString(Heroes[1].Tablero1.Count()));
                                MessageBox.Show("Atacaste");

                                con = 1;
                                break;
                            }
                        }
                    }
                    if (con == 1) { break; }
                }


            }
            else
            {
                foreach (Minions ad in Heroes[1].Tablero1)
                {
                    if (ad.Seleccionada == 1)
                    {

                        foreach (Minions af in Heroes[0].Tablero1)
                        {
                            if (af.Seleccionada == 1)
                            {

                                ad.RestarVidaMs(ad, af, Heroes[1].Tablero1, Heroes[0].Tablero1);

                                MessageBox.Show("Atacaste");
                                con = 1;
                                break;
                            }
                        }
                        if (con == 1)
                        {
                            break;
                        }
                    }
                }

            }
            MessageBox.Show(Convert.ToString(Heroes[0].Tablero1.Count()));
            MessageBox.Show(Convert.ToString(Heroes[1].Tablero1.Count()));
            if (Heroes[0].Tablero1.Count() != 0)
            {
                foreach (Minions i in Heroes[0].Tablero1)
                {
                    if (i.NombreCarta == "Wisp1")
                    {

                        Wisp1j1.Margin = new Thickness(0, 0, 0, 0);
                        Wisp1j1.Visibility = Visibility.Visible;


                    }
                    else { Wisp1j1.Visibility = Visibility.Hidden; }
                    if (i.NombreCarta == "Wisp2")
                    {

                        Wisp2j1.Margin = new Thickness(0, 0, 0, 0);
                        Wisp2j1.Visibility = Visibility.Visible;

                    }
                    else { Wisp2j1.Visibility = Visibility.Hidden; }
                    if (i.NombreCarta == "Wisp3")
                    {

                        Wisp3j1.Margin = new Thickness(0, 0, 0, 0);
                        Wisp3j1.Visibility = Visibility.Visible;

                    }
                    else { Wisp3j1.Visibility = Visibility.Hidden; }
                    if (i.NombreCarta == "Murloc1")
                    {

                        Murloc1.Margin = new Thickness(0, 0, 0, 0);
                        Murloc1j1.Visibility = Visibility.Visible;

                    }
                    else { Murloc1j1.Visibility = Visibility.Hidden; }
                    if (i.NombreCarta == "Murloc2")
                    {

                        Murloc2.Margin = new Thickness(0, 0, 0, 0);
                        Murloc2j1.Visibility = Visibility.Visible;


                    }
                    else { Murloc2j1.Visibility = Visibility.Hidden; }
                    if (i.NombreCarta == "Murloc3")
                    {

                        Murloc3.Margin = new Thickness(0, 0, 0, 0);
                        Murloc3j1.Visibility = Visibility.Visible;

                    }
                    else { Murloc3j1.Visibility = Visibility.Hidden; }
                    if (i.NombreCarta == "Oasis1")
                    {

                        Oasis1.Margin = new Thickness(0, 0, 0, 0);
                        Oasis1j1.Visibility = Visibility.Visible;
                    }
                    else { Oasis1j1.Visibility = Visibility.Hidden; }
                    if (i.NombreCarta == "Oasis2")
                    {

                        Oasis2.Margin = new Thickness(0, 0, 0, 0);
                        Oasis2j1.Visibility = Visibility.Visible;
                    }
                    else { Oasis2j1.Visibility = Visibility.Hidden; }
                    if (i.NombreCarta == "Oasis3")
                    {

                        Oasis3.Margin = new Thickness(0, 0, 0, 0);
                        Oasis3j1.Visibility = Visibility.Visible;
                    }
                    else { Oasis3j1.Visibility = Visibility.Hidden; }
                    if (i.NombreCarta == "Corehound1")
                    {

                        Corehound1.Margin = new Thickness(0, 0, 0, 0);
                        Corehound1j1.Visibility = Visibility.Visible;
                    }
                    else { Corehound1j1.Visibility = Visibility.Hidden; }
                    if (i.NombreCarta == "Corehound2")
                    {

                        Corehound2.Margin = new Thickness(0, 0, 0, 0);
                        Corehound2j1.Visibility = Visibility.Visible;
                    }
                    else { Corehound2j1.Visibility = Visibility.Hidden; }
                    if (i.NombreCarta == "Corehound3")
                    {

                        Corehound3.Margin = new Thickness(0, 0, 0, 0);
                        Corehound3j1.Visibility = Visibility.Visible;
                    }
                    else { Corehound3j1.Visibility = Visibility.Hidden; }
                    if (i.NombreCarta == "River1")
                    {

                        River1j1.Margin = new Thickness(0, 0, 0, 0);
                        River1j1.Visibility = Visibility.Visible;
                    }
                    else { River1j1.Visibility = Visibility.Hidden; }
                    if (i.NombreCarta == "River2")
                    {

                        River2j1.Margin = new Thickness(0, 0, 0, 0);
                        River2j1.Visibility = Visibility.Visible;
                    }
                    else { River2j1.Visibility = Visibility.Hidden; }
                    if (i.NombreCarta == "River3")
                    {
                        River3j1.Margin = new Thickness(0, 0, 0, 0);
                        River3j1.Visibility = Visibility.Visible;
                    }
                    else { River3j1.Visibility = Visibility.Hidden; }

                    if (i.NombreCarta == "Bloodfen1")
                    {

                        Bloodfen1j1.Margin = new Thickness(0, 0, 0, 0);
                        Bloodfen1j1.Visibility = Visibility.Visible;

                    }
                    else { Bloodfen1j1.Visibility = Visibility.Hidden; }
                    if (i.NombreCarta == "Bloodfen2")
                    {

                        Bloodfen2j1.Margin = new Thickness(0, 0, 0, 0);
                        Bloodfen2j1.Visibility = Visibility.Visible;

                    }
                    else { Bloodfen2j1.Visibility = Visibility.Hidden; }
                    if (i.NombreCarta == "Bloodfen3")
                    {

                        Bloodfen3j1.Margin = new Thickness(0, 0, 0, 0);
                        Bloodfen3j1.Visibility = Visibility.Visible;

                    }
                    else { Bloodfen3j1.Visibility = Visibility.Hidden; }
                    if (i.NombreCarta == "Magma1")
                    {

                        Magma1j1.Margin = new Thickness(0, 0, 0, 0);
                        Magma1j1.Visibility = Visibility.Visible;
                    }
                    else { Magma1j1.Visibility = Visibility.Hidden; }
                    if (i.NombreCarta == "Magma2")
                    {

                        Magma2j1.Margin = new Thickness(0, 0, 0, 0);
                        Magma2j1.Visibility = Visibility.Visible;
                    }
                    else { Magma2j1.Visibility = Visibility.Hidden; }
                    if (i.NombreCarta == "Magma3")
                    {

                        Magma3j1.Margin = new Thickness(0, 0, 0, 0);
                        Magma3j1.Visibility = Visibility.Visible;
                    }
                    else { Magma3j1.Visibility = Visibility.Hidden; }
                    if (i.NombreCarta == "Chillwind1")
                    {

                        Chillwind1j1.Margin = new Thickness(0, 0, 0, 0);
                        Chillwind1j1.Visibility = Visibility.Visible;

                    }
                    else { Chillwind1j1.Visibility = Visibility.Hidden; }
                    if (i.NombreCarta == "Chillwind2")
                    {

                        Chillwind2j1.Margin = new Thickness(0, 0, 0, 0);
                        Chillwind2j1.Visibility = Visibility.Visible;

                    }
                    else { Chillwind2j1.Visibility = Visibility.Hidden; }
                    if (i.NombreCarta == "Chillwind3")
                    {

                        Chillwind3j1.Margin = new Thickness(0, 0, 0, 0);
                        Chillwind3j1.Visibility = Visibility.Visible;

                    }
                    else { Chillwind3j1.Visibility = Visibility.Hidden; }
                    if (i.NombreCarta == "War1")
                    {

                        War1j1.Margin = new Thickness(0, 0, 0, 0);
                        War1j1.Visibility = Visibility.Visible;

                    }
                    else { War1j1.Visibility = Visibility.Hidden; }
                    if (i.NombreCarta == "War2")
                    {
                        War2j1.Margin = new Thickness(0, 0, 0, 0);
                        War2j1.Visibility = Visibility.Visible;

                    }
                    else { War2j1.Visibility = Visibility.Hidden; }
                    if (i.NombreCarta == "War3")
                    {

                        War3j1.Margin = new Thickness(0, 0, 0, 0);
                        War3j1.Visibility = Visibility.Visible;


                    }
                    else { War3j1.Visibility = Visibility.Hidden; }
                    if (i.NombreCarta == "Boulderfist1")
                    {

                        Boulderfist1j1.Margin = new Thickness(0, 0, 0, 0);
                        Boulderfist1j1.Visibility = Visibility.Visible;
                    }
                    else { Boulderfist1j1.Visibility = Visibility.Hidden; }
                    if (i.NombreCarta == "Boulderfist2")
                    {

                        Boulderfist2j1.Margin = new Thickness(0, 0, 0, 0);
                        Boulderfist2j1.Visibility = Visibility.Visible;
                    }
                    else { Boulderfist2j1.Visibility = Visibility.Hidden; }
                    if (i.NombreCarta == "Boulderfist3")
                    {

                        Boulderfist3j1.Margin = new Thickness(0, 0, 0, 0);
                        Boulderfist3j1.Visibility = Visibility.Visible;
                    }
                    else { Boulderfist3j1.Visibility = Visibility.Hidden; }
                }
            }
            else {
                Wisp1j1.Visibility = Visibility.Hidden; 
                Wisp2j1.Visibility = Visibility.Hidden; 
                Wisp3j1.Visibility = Visibility.Hidden;
                Murloc1j1.Visibility = Visibility.Hidden;
                Murloc2j1.Visibility = Visibility.Hidden;
                Murloc3j1.Visibility = Visibility.Hidden;
                Bloodfen1j1.Visibility = Visibility.Hidden;
                Bloodfen2j1.Visibility = Visibility.Hidden;
                Bloodfen3j1.Visibility = Visibility.Hidden;
                River1j1.Visibility = Visibility.Hidden;
                River2j1.Visibility = Visibility.Hidden;
                River3j1.Visibility = Visibility.Hidden;
                Magma2j1.Visibility = Visibility.Hidden;
                Magma1j1.Visibility = Visibility.Hidden;
                Magma3j1.Visibility = Visibility.Hidden;
                Chillwind1j1.Visibility = Visibility.Hidden;
                Chillwind2j1.Visibility = Visibility.Hidden;
                Chillwind3j1.Visibility = Visibility.Hidden;
                Oasis1j1.Visibility = Visibility.Hidden;
                Oasis2j1.Visibility = Visibility.Hidden;
                Oasis3j1.Visibility = Visibility.Hidden;
                Boulderfist1j1.Visibility = Visibility.Hidden;
                Boulderfist2j1.Visibility = Visibility.Hidden;
                Boulderfist3j1.Visibility = Visibility.Hidden;
                War1j1.Visibility = Visibility.Hidden; 
                War2j1.Visibility = Visibility.Hidden;
                War3j1.Visibility = Visibility.Hidden;
                Corehound1j1.Visibility = Visibility.Hidden;
                Corehound2j1.Visibility = Visibility.Hidden;
                Corehound3j1.Visibility = Visibility.Hidden;



            }

            if ((Heroes[1].Tablero1.Count() != 0))
                {
                foreach (Minions i in Heroes[1].Tablero1)
                {
                    if (i.NombreCarta == "Wisp1")
                    {

                        Wisp1j2.Margin = new Thickness(0, 0, 0, 0);
                        Wisp1j2.Visibility = Visibility.Visible;


                    }
                    else { Wisp1j2.Visibility = Visibility.Hidden; }
                    if (i.NombreCarta == "Wisp2")
                    {

                        Wisp2j2.Margin = new Thickness(0, 0, 0, 0);
                        Wisp2j2.Visibility = Visibility.Visible;

                    }
                    else { Wisp2j2.Visibility = Visibility.Hidden; }
                    if (i.NombreCarta == "Wisp3")
                    {

                        Wisp3j2.Margin = new Thickness(0, 0, 0, 0);
                        Wisp3j2.Visibility = Visibility.Visible;

                    }
                    else { Wisp3j2.Visibility = Visibility.Hidden; }
                    if (i.NombreCarta == "Murloc1")
                    {

                        Murloc1.Margin = new Thickness(0, 0, 0, 0);
                        Murloc1j2.Visibility = Visibility.Visible;

                    }
                    else { Murloc1j2.Visibility = Visibility.Hidden; }
                    if (i.NombreCarta == "Murloc2")
                    {

                        Murloc2.Margin = new Thickness(0, 0, 0, 0);
                        Murloc2j2.Visibility = Visibility.Visible;
                    }
                    else { Murloc2j2.Visibility = Visibility.Hidden; }
                    if (i.NombreCarta == "Murloc3")
                    {

                        Murloc3.Margin = new Thickness(0, 0, 0, 0);
                        Murloc3j2.Visibility = Visibility.Visible;

                    }
                    else { Murloc3j2.Visibility = Visibility.Hidden; }
                    if (i.NombreCarta == "Oasis1")
                    {

                        Oasis1.Margin = new Thickness(0, 0, 0, 0);
                        Oasis1j2.Visibility = Visibility.Visible;
                    }
                    else { Oasis1j2.Visibility = Visibility.Hidden; }
                    if (i.NombreCarta == "Oasis2")
                    {

                        Oasis2.Margin = new Thickness(0, 0, 0, 0);
                        Oasis2j2.Visibility = Visibility.Visible;
                    }
                    else { Oasis2j2.Visibility = Visibility.Hidden; }
                    if (i.NombreCarta == "Oasis3")
                    {

                        Oasis3.Margin = new Thickness(0, 0, 0, 0);
                        Oasis3j2.Visibility = Visibility.Visible;
                    }
                    else { Oasis3j2.Visibility = Visibility.Hidden; }
                    if (i.NombreCarta == "Corehound1")
                    {

                        Corehound1.Margin = new Thickness(0, 0, 0, 0);
                        Corehound1j2.Visibility = Visibility.Visible;
                    }
                    else { Corehound1j2.Visibility = Visibility.Hidden; }
                    if (i.NombreCarta == "Corehound2")
                    {

                        Corehound2.Margin = new Thickness(0, 0, 0, 0);
                        Corehound2j2.Visibility = Visibility.Visible;
                    }
                    else { Corehound2j2.Visibility = Visibility.Hidden; }
                    if (i.NombreCarta == "Corehound3")
                    {

                        Corehound3.Margin = new Thickness(0, 0, 0, 0);
                        Corehound3j2.Visibility = Visibility.Visible;
                    }
                    else { Corehound3j2.Visibility = Visibility.Hidden; }
                    if (i.NombreCarta == "River1")
                    {

                        River1j1.Margin = new Thickness(0, 0, 0, 0);
                        River1j2.Visibility = Visibility.Visible;
                    }
                    else { River1j2.Visibility = Visibility.Hidden; }
                    if (i.NombreCarta == "River2")
                    {

                        River2j1.Margin = new Thickness(0, 0, 0, 0);
                        River2j2.Visibility = Visibility.Visible;
                    }
                    else { River2j2.Visibility = Visibility.Hidden; }
                    if (i.NombreCarta == "River3")
                    {
                        River3j1.Margin = new Thickness(0, 0, 0, 0);
                        River3j2.Visibility = Visibility.Visible;
                    }
                    else { River3j2.Visibility = Visibility.Hidden; }
                    if (i.NombreCarta == "Bloodfen1")
                    {

                        Bloodfen1j1.Margin = new Thickness(0, 0, 0, 0);
                        Bloodfen1j2.Visibility = Visibility.Visible;

                    }
                    else { Bloodfen1j2.Visibility = Visibility.Hidden; }
                    if (i.NombreCarta == "Bloodfen2")
                    {

                        Bloodfen2j1.Margin = new Thickness(0, 0, 0, 0);
                        Bloodfen2j2.Visibility = Visibility.Visible;

                    }
                    else { Bloodfen2j2.Visibility = Visibility.Hidden; }
                    if (i.NombreCarta == "Bloodfen3")
                    {

                        Bloodfen3j1.Margin = new Thickness(0, 0, 0, 0);
                        Bloodfen3j2.Visibility = Visibility.Visible;

                    }
                    else { Bloodfen3j2.Visibility = Visibility.Hidden; }
                    if (i.NombreCarta == "Magma1")
                    {

                        Magma1j1.Margin = new Thickness(0, 0, 0, 0);
                        Magma1j2.Visibility = Visibility.Visible;
                    }
                    else { Magma1j2.Visibility = Visibility.Hidden; }
                    if (i.NombreCarta == "Magma2")
                    {

                        Magma2j1.Margin = new Thickness(0, 0, 0, 0);
                        Magma2j2.Visibility = Visibility.Visible;
                    }
                    else { Magma2j2.Visibility = Visibility.Hidden; }
                    if (i.NombreCarta == "Magma3")
                    {

                        Magma3j1.Margin = new Thickness(0, 0, 0, 0);
                        Magma3j2.Visibility = Visibility.Visible;
                    }
                    else { Magma3j2.Visibility = Visibility.Hidden; }
                    if (i.NombreCarta == "Chillwind1")
                    {

                        Chillwind1j1.Margin = new Thickness(0, 0, 0, 0);
                        Chillwind1j2.Visibility = Visibility.Visible;

                    }
                    else { Chillwind1j2.Visibility = Visibility.Hidden; }
                    if (i.NombreCarta == "Chillwind2")
                    {

                        Chillwind2j1.Margin = new Thickness(0, 0, 0, 0);
                        Chillwind2j2.Visibility = Visibility.Visible;

                    }
                    else { Chillwind2j2.Visibility = Visibility.Hidden; }
                    if (i.NombreCarta == "Chillwind3")
                    {

                        Chillwind3j1.Margin = new Thickness(0, 0, 0, 0);
                        Chillwind3j2.Visibility = Visibility.Visible;

                    }
                    else { Chillwind3j2.Visibility = Visibility.Hidden; }
                    if (i.NombreCarta == "War1")
                    {

                        War1j1.Margin = new Thickness(0, 0, 0, 0);
                        War1j2.Visibility = Visibility.Visible;

                    }
                    else { War1j2.Visibility = Visibility.Hidden; }
                    if (i.NombreCarta == "War2")
                    {
                        War2j1.Margin = new Thickness(0, 0, 0, 0);
                        War2j2.Visibility = Visibility.Visible;

                    }
                    else { War2j2.Visibility = Visibility.Hidden; }
                    if (i.NombreCarta == "War3")
                    {

                        War3j1.Margin = new Thickness(0, 0, 0, 0);
                        War3j2.Visibility = Visibility.Visible;

                    }
                    else { War3j2.Visibility = Visibility.Hidden; }
                    if (i.NombreCarta == "Boulderfist1")
                    {

                        Boulderfist1j1.Margin = new Thickness(0, 0, 0, 0);
                        Boulderfist1j2.Visibility = Visibility.Visible;
                    }
                    else { Boulderfist1j2.Visibility = Visibility.Hidden; }
                    if (i.NombreCarta == "Boulderfist2")
                    {

                        Boulderfist2j1.Margin = new Thickness(0, 0, 0, 0);
                        Boulderfist2j2.Visibility = Visibility.Visible;
                    }
                    else { Boulderfist3j2.Visibility = Visibility.Hidden; }
                    if (i.NombreCarta == "Boulderfist3")
                    {

                        Boulderfist3j1.Margin = new Thickness(0, 0, 0, 0);
                        Boulderfist3j2.Visibility = Visibility.Visible;
                    }
                    else { Boulderfist3j2.Visibility = Visibility.Hidden; }
                }
            }
            else {
                Wisp1j2.Visibility = Visibility.Hidden;
                Wisp2j2.Visibility = Visibility.Hidden;
                Wisp3j2.Visibility = Visibility.Hidden;
                Murloc1j2.Visibility = Visibility.Hidden;
                Murloc2j2.Visibility = Visibility.Hidden;
                Murloc3j2.Visibility = Visibility.Hidden;
                Bloodfen1j2.Visibility = Visibility.Hidden;
                Bloodfen2j2.Visibility = Visibility.Hidden;
                Bloodfen3j2.Visibility = Visibility.Hidden;
                River1j2.Visibility = Visibility.Hidden;
                River2j2.Visibility = Visibility.Hidden;
                River3j2.Visibility = Visibility.Hidden;
                Magma2j2.Visibility = Visibility.Hidden;
                Magma1j2.Visibility = Visibility.Hidden;
                Magma3j2.Visibility = Visibility.Hidden;
                Chillwind1j2.Visibility = Visibility.Hidden;
                Chillwind2j2.Visibility = Visibility.Hidden;
                Chillwind3j2.Visibility = Visibility.Hidden;
                Oasis1j2.Visibility = Visibility.Hidden;
                Oasis2j2.Visibility = Visibility.Hidden;
                Oasis3j2.Visibility = Visibility.Hidden;
                Boulderfist1j2.Visibility = Visibility.Hidden;
                Boulderfist2j2.Visibility = Visibility.Hidden;
                Boulderfist3j2.Visibility = Visibility.Hidden;
                War1j2.Visibility = Visibility.Hidden;
                War2j2.Visibility = Visibility.Hidden;
                War3j2.Visibility = Visibility.Hidden;
                Corehound1j2.Visibility = Visibility.Hidden;
                Corehound2j2.Visibility = Visibility.Hidden;
                Corehound3j2.Visibility = Visibility.Hidden;

            }
        }


        private void HabilidadHeroe_Click(object sender, RoutedEventArgs e)
        {
            if (jugando == 0)
            {
                if (Heroes[0].Nombre == "Paladin") { Heroes[0].Habilidad(Heroes[0]); }
                else if (Heroes[0].Nombre == "Druida") { Heroes[0].Habilidad(Heroes[0]); }
                else if (Heroes[0].Nombre == "Cazador") { Heroes[0].Habilidad(Heroes[0]); }
                else if (Heroes[0].Nombre == "Hunter") { Heroes[0].Habilidad(Heroes[0]); }
                else if (Heroes[0].Nombre == "Sacerdote") { Heroes[0].Habilidad(Heroes[0]); }
                else if (Heroes[0].Nombre == "Picaro") { Heroes[0].Habilidad(Heroes[0]); }
                else if (Heroes[0].Nombre == "Brujo") { Heroes[0].Habilidad(Heroes[0]); }
                else if (Heroes[0].Nombre == "Mago") { Heroes[0].Habilidad(Heroes[0]); }
                else if (Heroes[0].Nombre == "Chaman") { Heroes[0].Habilidad(Heroes[0]); }
                else { Heroes[0].Habilidad(Heroes[0]); }

            }
            else
            {
                if (Heroes[0].Nombre == "Paladin") { Heroes[0].Habilidad(Heroes[0]); }
                else if (Heroes[0].Nombre == "Druida") { Heroes[0].Habilidad(Heroes[0]); }
                else if (Heroes[0].Nombre == "Cazador") { Heroes[0].Habilidad(Heroes[0]); }
                else if (Heroes[0].Nombre == "Hunter") { Heroes[0].Habilidad(Heroes[0]); }
                else if (Heroes[0].Nombre == "Sacerdote") { Heroes[0].Habilidad(Heroes[0]); }
                else if (Heroes[0].Nombre == "Picaro") { Heroes[0].Habilidad(Heroes[0]); }
                else if (Heroes[0].Nombre == "Brujo") { Heroes[0].Habilidad(Heroes[0]); }
                else if (Heroes[0].Nombre == "Mago") { Heroes[0].Habilidad(Heroes[0]); }
                else if (Heroes[0].Nombre == "Chaman") { Heroes[0].Habilidad(Heroes[0]); }
                else { Heroes[0].Habilidad(Heroes[0]); }
            }
           

        }
    }
}

