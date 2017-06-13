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
            Minions wisp1 = new Minions("Classic", 0, "Wisp", null, 1, 1, 1, 0);
            MJugador1.mazo1.Add(wisp1);
            MJugador2.mazo1.Add(wisp1);

            Minions wisp2 = new Minions("Classic", 0, "Wisp", null, 1, 1, 1, 0);
            MJugador1.mazo1.Add(wisp2);
            MJugador2.mazo1.Add(wisp2);
            Minions wisp3 = new Minions("Classic", 0, "Wisp", null, 1, 1, 1, 0);
            MJugador1.mazo1.Add(wisp3);
            MJugador2.mazo1.Add(wisp3);

            Minions murloc1 = new Minions("Basic", 1, "Murloc Raider", "Murloc", 1, 2, 1, 0);
            MJugador1.mazo1.Add(murloc1);
            MJugador2.mazo1.Add(murloc1);
            Minions murloc2 = new Minions("Basic", 1, "Murloc Raider", "Murloc", 1, 2, 1, 0);
            MJugador1.mazo1.Add(murloc2);
            MJugador2.mazo1.Add(murloc2);
            Minions murloc3 = new Minions("Basic", 1, "Murloc Raider", "Murloc", 1, 2, 1, 0);
            MJugador1.mazo1.Add(murloc3);
            MJugador2.mazo1.Add(murloc3);


            Minions bloodfen1 = new Minions("Basic", 2, "Bloodfen Raptor", "Beast", 2, 3, 1, 0);
            MJugador1.mazo1.Add(bloodfen1);
            MJugador2.mazo1.Add(bloodfen1);
            Minions bloodfen2 = new Minions("Basic", 2, "Bloodfen Raptor", "Beast", 2, 3, 1, 0);
            MJugador1.mazo1.Add(bloodfen2);
            MJugador2.mazo1.Add(bloodfen2);
            Minions bloodfen3 = new Minions("Basic", 2, "Bloodfen Raptor", "Beast", 2, 3, 1, 0);
            MJugador1.mazo1.Add(bloodfen3);
            MJugador2.mazo1.Add(bloodfen3);

            Minions river1 = new Minions("Basic", 2, "River Crocolisk", " Beast", 3, 2, 1, 0);
            MJugador1.mazo1.Add(river1);
            MJugador2.mazo1.Add(river1);
            Minions river2 = new Minions("Basic", 2, "River Crocolisk", " Beast", 3, 2, 1, 0);
            MJugador1.mazo1.Add(river2);
            MJugador2.mazo1.Add(river2);
            Minions river3 = new Minions("Basic", 2, "River Crocolisk", " Beast", 3, 2, 1, 0);
            MJugador1.mazo1.Add(river3);
            MJugador2.mazo1.Add(river3);

            Minions magma1 = new Minions("Basic", 3, "Magma Rager", "Elemental", 1, 5, 1, 0);
            MJugador1.mazo1.Add(magma1);
            MJugador2.mazo1.Add(magma1);
            Minions magma2 = new Minions("Basic", 3, "Magma Rager", "Elemental", 1, 5, 1, 0);
            MJugador1.mazo1.Add(magma2);
            MJugador2.mazo1.Add(magma2);
            Minions magma3 = new Minions("Basic", 3, "Magma Rager", "Elemental", 1, 5, 1, 0);
            MJugador1.mazo1.Add(magma3);
            MJugador2.mazo1.Add(magma3);

            Minions chillwind1 = new Minions("Basic", 4, "Chillwind Yeti", null, 5, 4, 1, 0);
            MJugador1.mazo1.Add(chillwind1);
            MJugador2.mazo1.Add(chillwind1);
            Minions chillwind2 = new Minions("Basic", 4, "Chillwind Yeti", null, 5, 4, 1, 0);
            MJugador1.mazo1.Add(chillwind2);
            MJugador2.mazo1.Add(chillwind2);
            Minions chillwind3 = new Minions("Basic", 4, "Chillwind Yeti", null, 5, 4, 1, 0);
            MJugador1.mazo1.Add(chillwind3);
            MJugador2.mazo1.Add(chillwind3);

            Minions oasis1 = new Minions("Basic", 4, "Oasis Snapjaw", "Beast", 7, 2, 1, 0);
            MJugador1.mazo1.Add(oasis1);
            MJugador2.mazo1.Add(oasis1);
            Minions oasis2 = new Minions("Basic", 4, "Oasis Snapjaw", "Beast", 7, 2, 1, 0);
            MJugador1.mazo1.Add(oasis2);
            MJugador2.mazo1.Add(oasis2);
            Minions oasis3 = new Minions("Basic", 4, "Oasis Snapjaw", "Beast", 7, 2, 1, 0);
            MJugador1.mazo1.Add(oasis3);
            MJugador2.mazo1.Add(oasis3);

            Minions boulderfist1 = new Minions("Basic", 6, "Boulderfist Ogre", null, 7, 6, 1, 0);
            MJugador1.mazo1.Add(boulderfist1);
            MJugador2.mazo1.Add(boulderfist1);
            Minions boulderfist2 = new Minions("Basic", 6, "Boulderfist Ogre", null, 7, 6, 1, 0);
            MJugador1.mazo1.Add(boulderfist2);
            MJugador2.mazo1.Add(boulderfist2);
            Minions boulderfist3 = new Minions("Basic", 6, "Boulderfist Ogre", null, 7, 6, 1, 0);
            MJugador1.mazo1.Add(boulderfist3);
            MJugador2.mazo1.Add(boulderfist3);


            Minions war1 = new Minions("Basic", 7, "War Golem", null, 7, 7, 1, 0);
            MJugador1.mazo1.Add(war1);
            MJugador2.mazo1.Add(war1);
            Minions war2 = new Minions("Basic", 7, "War Golem", null, 7, 7, 1, 0);
            MJugador1.mazo1.Add(war2);
            MJugador2.mazo1.Add(war2);
            Minions war3 = new Minions("Basic", 7, "War Golem", null, 7, 7, 1, 0);
            MJugador1.mazo1.Add(war3);
            MJugador2.mazo1.Add(war3);

            Minions core1 = new Minions("Basic", 7, "Core Hound", "Beast", 5, 9, 1, 0);
            MJugador1.mazo1.Add(core1);
            MJugador2.mazo1.Add(core1);
            Minions core2 = new Minions("Basic", 7, "Core Hound", "Beast", 5, 9, 1, 0);
            MJugador1.mazo1.Add(core2);
            MJugador2.mazo1.Add(core2);
            Minions core3 = new Minions("Basic", 7, "Core Hound", "Beast", 5, 9, 1, 0);
            MJugador1.mazo1.Add(core3);
            MJugador2.mazo1.Add(core3);
            MJugador1.shuffle();
            MJugador2.shuffle();
            InitializeComponent();
            Program MyV = new Program();
            Jugar jugs = new Jugar();
            int t = MyV.QuienParte(Heroes[0], Heroes[1], MJugador1, MJugador2, moneda);
            while (true)
            {
                if (t == 0)
                {
                    jugs.Jugars(Heroes[0], MJugador1);
                    //Poner visibilidad de las cartas
                    while (true)
                    {
                        if (parar == 1) { break; }
                    }

        }
                else
                {
                   jugs.Jugars(Heroes[1], MJugador2);
                    while (true)
                    {
                        if (parar == 1) { break; }
                    }
                }

                if (t == 0)
                { t = 1; }
                else
                {
                    t = 0;
                }
            }

        }
        Mazo MJugador1 = new Mazo();
        Mazo MJugador2 = new Mazo();
        List<Heroe> Heroes = new List<Heroe>();
        
        int eligioheroe = 0;
        int parar = 0;
        
        private void Paladin_Click(object sender, RoutedEventArgs e)
        {
            if (JugadorUno.Visibility == Visibility.Visible && eligioheroe == 0) {
                Paladin Jugador1 = new Paladin(30, 0, "Paladin", 0, 0, 0, 0, 0);
                Heroes.Add(Jugador1);
                Minions Pala = new Minions("Paladin", 0, "Paladin", "Guerrero", 1, 1, 1, 0);
                Jugador1.Miespeciales.Add(Pala);
                Paladin.Visibility = Visibility.Hidden;
                JugadorUno.Visibility = Visibility.Hidden;
                JugadorDos.Visibility = Visibility.Visible;
            }
            else {
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
            }
        }

        private void Druid_Click(object sender, RoutedEventArgs e)
        {
            if (JugadorUno.Visibility == Visibility.Visible && eligioheroe == 0) {
                Druida Jugador1 = new Druida(30, 0, "Druida", 0, 0, 0, 0, 0);
                Heroes.Add(Jugador1);
                Druid.Visibility = Visibility.Hidden;
                JugadorUno.Visibility = Visibility.Hidden;
                JugadorDos.Visibility = Visibility.Visible;
            }
            else {
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
            }
        }

        private void Cazador_Click(object sender, RoutedEventArgs e)
        {
            if (JugadorUno.Visibility == Visibility.Visible && eligioheroe == 0) {
                Hunter Jugador1 = new Hunter(30, 0, "Hunter", 0, 0, 0, 0, 0);
                Heroes.Add(Jugador1);
                Cazador.Visibility = Visibility.Hidden;
                JugadorUno.Visibility = Visibility.Hidden;
                JugadorDos.Visibility = Visibility.Visible;
            }
            else {
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
            }
        }

        private void Priest_Click(object sender, RoutedEventArgs e)
        {
            if (JugadorUno.Visibility == Visibility.Visible && eligioheroe == 0) {
                Sacerdote Jugador1 = new Sacerdote(30, 0, "Sacerdote", 0, 0, 0, 0, 0);
                Heroes.Add(Jugador1);
                Priest.Visibility = Visibility.Hidden;
                JugadorUno.Visibility = Visibility.Hidden;
                JugadorDos.Visibility = Visibility.Visible;
            }
            else {
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
            }
        }

        private void Picaro_Click(object sender, RoutedEventArgs e)
        {
            if (JugadorUno.Visibility == Visibility.Visible && eligioheroe == 0) {
                Picaro Jugador1 = new Picaro(30, 0, "Picaro", 0, 0, 0, 0, 0);
                Heroes.Add(Jugador1);
                Picaro.Visibility = Visibility.Hidden;
                JugadorUno.Visibility = Visibility.Hidden;
                JugadorDos.Visibility = Visibility.Visible;
            }
            else {
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
            }
           
        }

        private void Brujo_Click(object sender, RoutedEventArgs e)
        {
            if (JugadorUno.Visibility == Visibility.Visible && eligioheroe == 0) {
                Brujo Jugador1 = new Brujo(30, 0, "Brujo", 0, 0, 0, 0, 0);
                Heroes.Add(Jugador1);
                Brujo.Visibility = Visibility.Hidden;
                JugadorUno.Visibility = Visibility.Hidden;
                JugadorDos.Visibility = Visibility.Visible;
            }
            else {
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

            }
           

        }

        private void Chaman_Click(object sender, RoutedEventArgs e)
        {
            if (JugadorUno.Visibility == Visibility.Visible && eligioheroe == 0) {
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
            else {
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
            }
           

        }

        private void Guerrero_Click(object sender, RoutedEventArgs e)
        {
            if (JugadorUno.Visibility == Visibility.Visible && eligioheroe == 0) {
                Warrior Jugador1 = new Warrior(30, 0, "Warrior", 0, 0, 0, 0, 0); ;
                Heroes.Add(Jugador1);
                Guerrero.Visibility = Visibility.Hidden;
                JugadorUno.Visibility = Visibility.Hidden;
                JugadorDos.Visibility = Visibility.Visible;
            }
            else {
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
            }
           

        }
        
        private void nombre1_KeyPressed(object sender, KeyEventArgs e)
        {
            if (e.Key==Key.Enter)
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
            
            Manaj1.Value= Heroes[0].Mana;

        }

       private void Manaj2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Manaj2.Value = Heroes[1].Mana;
        }

        private void Robar_Click(object sender, RoutedEventArgs e)
        {

        }

        
    }
}
