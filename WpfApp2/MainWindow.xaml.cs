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

namespace WpfApp2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            Hechizo moneda = new Hechizo(null, 0, "Moneda");
            Minions Paladin = new Minions("Classic", 0, "Paladin", null, 1, 1, 1, 0);
            Minions wisp1 = new Minions("Classic", 0, "Wisp1", null, 1, 1, 1, 0);
            MJugador1.mazo1.Add(wisp1);
            MJugador2.mazo1.Add(wisp1);

            Minions wisp2 = new Minions("Classic", 0, "Wisp2", null, 1, 1, 1, 0);
            MJugador1.mazo1.Add(wisp2);
            MJugador2.mazo1.Add(wisp2);
            Minions wisp3 = new Minions("Classic", 0, "Wisp3", null, 1, 1, 1, 0);
            MJugador1.mazo1.Add(wisp3);
            MJugador2.mazo1.Add(wisp3);

            Minions murloc1 = new Minions("Basic", 1, "Murloc1", "Murloc", 1, 2, 1, 0);
            MJugador1.mazo1.Add(murloc1);
            MJugador2.mazo1.Add(murloc1);
            Minions murloc2 = new Minions("Basic", 1, "Murloc2", "Murloc", 1, 2, 1, 0);
            MJugador1.mazo1.Add(murloc2);
            MJugador2.mazo1.Add(murloc2);
            Minions murloc3 = new Minions("Basic", 1, "Murloc3", "Murloc", 1, 2, 1, 0);
            MJugador1.mazo1.Add(murloc3);
            MJugador2.mazo1.Add(murloc3);


            Minions bloodfen1 = new Minions("Basic", 2, "Bloodfen1", "Beast", 2, 3, 1, 0);
            MJugador1.mazo1.Add(bloodfen1);
            MJugador2.mazo1.Add(bloodfen1);
            Minions bloodfen2 = new Minions("Basic", 2, "Bloodfen2", "Beast", 2, 3, 1, 0);
            MJugador1.mazo1.Add(bloodfen2);
            MJugador2.mazo1.Add(bloodfen2);
            Minions bloodfen3 = new Minions("Basic", 2, "Bloodfen3", "Beast", 2, 3, 1, 0);
            MJugador1.mazo1.Add(bloodfen3);
            MJugador2.mazo1.Add(bloodfen3);

            Minions river1 = new Minions("Basic", 2, "River1", " Beast", 3, 2, 1, 0);
            MJugador1.mazo1.Add(river1);
            MJugador2.mazo1.Add(river1);
            Minions river2 = new Minions("Basic", 2, "River2", " Beast", 3, 2, 1, 0);
            MJugador1.mazo1.Add(river2);
            MJugador2.mazo1.Add(river2);
            Minions river3 = new Minions("Basic", 2, "River3", " Beast", 3, 2, 1, 0);
            MJugador1.mazo1.Add(river3);
            MJugador2.mazo1.Add(river3);

            Minions magma1 = new Minions("Basic", 3, "Magma1", "Elemental", 1, 5, 1, 0);
            MJugador1.mazo1.Add(magma1);
            MJugador2.mazo1.Add(magma1);
            Minions magma2 = new Minions("Basic", 3, "Magma2", "Elemental", 1, 5, 1, 0);
            MJugador1.mazo1.Add(magma2);
            MJugador2.mazo1.Add(magma2);
            Minions magma3 = new Minions("Basic", 3, "Magma3", "Elemental", 1, 5, 1, 0);
            MJugador1.mazo1.Add(magma3);
            MJugador2.mazo1.Add(magma3);

            Minions chillwind1 = new Minions("Basic", 4, "Chillwind1", null, 5, 4, 1, 0);
            MJugador1.mazo1.Add(chillwind1);
            MJugador2.mazo1.Add(chillwind1);
            Minions chillwind2 = new Minions("Basic", 4, "Chillwind2", null, 5, 4, 1, 0);
            MJugador1.mazo1.Add(chillwind2);
            MJugador2.mazo1.Add(chillwind2);
            Minions chillwind3 = new Minions("Basic", 4, "Chillwind3", null, 5, 4, 1, 0);
            MJugador1.mazo1.Add(chillwind3);
            MJugador2.mazo1.Add(chillwind3);

            Minions oasis1 = new Minions("Basic", 4, "Oasis1", "Beast", 7, 2, 1, 0);
            MJugador1.mazo1.Add(oasis1);
            MJugador2.mazo1.Add(oasis1);
            Minions oasis2 = new Minions("Basic", 4, "Oasis2", "Beast", 7, 2, 1, 0);
            MJugador1.mazo1.Add(oasis2);
            MJugador2.mazo1.Add(oasis2);
            Minions oasis3 = new Minions("Basic", 4, "Oasis3", "Beast", 7, 2, 1, 0);
            MJugador1.mazo1.Add(oasis3);
            MJugador2.mazo1.Add(oasis3);

            Minions boulderfist1 = new Minions("Basic", 6, "Boulderfist1", null, 7, 6, 1, 0);
            MJugador1.mazo1.Add(boulderfist1);
            MJugador2.mazo1.Add(boulderfist1);
            Minions boulderfist2 = new Minions("Basic", 6, "Boulderfist2", null, 7, 6, 1, 0);
            MJugador1.mazo1.Add(boulderfist2);
            MJugador2.mazo1.Add(boulderfist2);
            Minions boulderfist3 = new Minions("Basic", 6, "Boulderfist3", null, 7, 6, 1, 0);
            MJugador1.mazo1.Add(boulderfist3);
            MJugador2.mazo1.Add(boulderfist3);


            Minions war1 = new Minions("Basic", 7, "War1", null, 7, 7, 1, 0);
            MJugador1.mazo1.Add(war1);
            MJugador2.mazo1.Add(war1);
            Minions war2 = new Minions("Basic", 7, "War2", null, 7, 7, 1, 0);
            MJugador1.mazo1.Add(war2);
            MJugador2.mazo1.Add(war2);
            Minions war3 = new Minions("Basic", 7, "War3", null, 7, 7, 1, 0);
            MJugador1.mazo1.Add(war3);
            MJugador2.mazo1.Add(war3);

            Minions core1 = new Minions("Basic", 7, "Corehound1", "Beast", 5, 9, 1, 0);
            MJugador1.mazo1.Add(core1);
            MJugador2.mazo1.Add(core1);
            Minions core2 = new Minions("Basic", 7, "Corehound2", "Beast", 5, 9, 1, 0);
            MJugador1.mazo1.Add(core2);
            MJugador2.mazo1.Add(core2);
            Minions core3 = new Minions("Basic", 7, "Corehound3", "Beast", 5, 9, 1, 0);
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


        private void Paladin_Click(object sender, RoutedEventArgs e)
        {
            if (JugadorUno.Visibility == Visibility.Visible && eligioheroe == 0)
            {
                Paladin Jugador1 = new Paladin(30, 0, "Paladin", 0, 0, 0, 0, 0);
                Heroes.Add(Jugador1);
                Minions Pala = new Minions("Paladin", 0, "Paladin", "Guerrero", 1, 1, 1, 0);
                Jugador1.Miespeciales.Add(Pala);
                Paladin.Visibility = Visibility.Hidden;
                JugadorUno.Visibility = Visibility.Hidden;
                JugadorDos.Visibility = Visibility.Visible;
            }
            else
            {
                Paladin Jugador2 = new Paladin(30, 0, "Paladin", 0, 0, 0, 0, 0);
                Heroes.Add(Jugador2);
                Minions Pala = new Minions("Paladin", 0, "Paladin", "Guerrero", 1, 1, 1, 0);
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
                Manaj1.Visibility = Visibility.Visible;
                FinTurno1.Visibility = Visibility.Visible;
                EmpiezaT1.Visibility = Visibility.Visible;
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
                Manaj1.Visibility = Visibility.Visible;
                FinTurno1.Visibility = Visibility.Visible;
                EmpiezaT1.Visibility = Visibility.Visible;
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
                Manaj1.Visibility = Visibility.Visible;
                FinTurno1.Visibility = Visibility.Visible;
                EmpiezaT1.Visibility = Visibility.Visible;
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
                Manaj1.Visibility = Visibility.Visible;
                FinTurno1.Visibility = Visibility.Visible;
                EmpiezaT1.Visibility = Visibility.Visible;
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
                Manaj1.Visibility = Visibility.Visible;
                FinTurno1.Visibility = Visibility.Visible;
                EmpiezaT1.Visibility = Visibility.Visible;
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
                Manaj1.Visibility = Visibility.Visible;
                FinTurno1.Visibility = Visibility.Visible;
                EmpiezaT1.Visibility = Visibility.Visible;
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
                Manaj1.Visibility = Visibility.Visible;
                FinTurno1.Visibility = Visibility.Visible;
                EmpiezaT1.Visibility = Visibility.Visible;
                int t = MyV.QuienParte(Heroes[0], Heroes[1], MJugador1, MJugador2);

            }


        }

        private void Chaman_Click(object sender, RoutedEventArgs e)
        {
            if (JugadorUno.Visibility == Visibility.Visible && eligioheroe == 0)
            {
                Chaman Jugador1 = new Chaman(30, 0, "Chaman", 0, 0, 0, 0, 0);
                Minions Totem1 = new Minions("Totem", 1, "Totem1", "Totem", 1, 1, 1, 0);
                Minions Totem2 = new Minions("Totem", 1, "Totem2", "Totem", 0, 2, 1, 0);
                Minions Totem3 = new Minions("Totem", 1, "Totem3", "Totem", 0, 2, 1, 0);
                Minions Totem4 = new Minions("Totem", 1, "Totem4", "Totem", 0, 2, 1, 0);
                Jugador1.Miespeciales.Add(Totem1);
                Jugador1.Miespeciales.Add(Totem2);
                Jugador1.Miespeciales.Add(Totem3);
                Jugador1.Miespeciales.Add(Totem4);
                Heroes.Add(Jugador1);
                Chaman.Visibility = Visibility.Hidden;
                JugadorUno.Visibility = Visibility.Hidden;
                JugadorDos.Visibility = Visibility.Visible;
                Manaj1.Visibility = Visibility.Visible;
            }
            else
            {
                Chaman Jugador2 = new Chaman(30, 0, "Chaman", 0, 0, 0, 0, 0);
                Minions Totem1 = new Minions("Totem", 1, "Totem1", "Totem", 1, 1, 1, 0);
                Minions Totem2 = new Minions("Totem", 1, "Totem2", "Totem", 0, 2, 1, 0);
                Minions Totem3 = new Minions("Totem", 1, "Totem3", "Totem", 0, 2, 1, 0);
                Minions Totem4 = new Minions("Totem", 1, "Totem4", "Totem", 0, 2, 1, 0);
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
                Manaj1.Visibility = Visibility.Visible;
                FinTurno1.Visibility = Visibility.Visible;
                EmpiezaT1.Visibility = Visibility.Visible;
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
                Manaj1.Visibility = Visibility.Visible;
                FinTurno1.Visibility = Visibility.Visible;
                EmpiezaT1.Visibility = Visibility.Visible;
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
                EligeHeroes.Visibility = Visibility.Visible;
            }
        }

        private void Manaj1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

            Manaj1.Value = Heroes[0].Mana;

        }

        private void Manaj2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Manaj2.Value = Heroes[1].Mana;
        }

        private void FinTurno1_Click(object sender, RoutedEventArgs e)
        {
            jugs.Pasar(Heroes[0]);
            Mano.Visibility = Visibility.Hidden;
            BarraMano.Visibility = Visibility.Hidden;
            FinTurno1.Visibility = Visibility.Hidden;
            FinTurno2.Visibility = Visibility.Visible;
            EmpiezaT2.Visibility = Visibility.Visible;
            EmpiezaT1.Visibility = Visibility.Hidden;
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
            jugs.Jugars(Heroes[0], MJugador1);
            Mano.Visibility = Visibility.Visible;
            BarraMano.Visibility = Visibility.Visible;
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
            Mano.Visibility = Visibility.Visible;
            BarraMano.Visibility = Visibility.Visible;
            jugs.Jugars(Heroes[1], MJugador2);
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
            Mano.Visibility = Visibility.Hidden;
            BarraMano.Visibility = Visibility.Hidden;
            FinTurno2.Visibility = Visibility.Hidden;
            FinTurno1.Visibility = Visibility.Visible;
            EmpiezaT1.Visibility = Visibility.Visible;
            EmpiezaT2.Visibility = Visibility.Hidden;
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

        }

        private void Bloodfen2_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

