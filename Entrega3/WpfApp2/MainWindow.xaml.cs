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
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

  

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

        Minions Pala = new Minions("Paladin", 0, "Paladin", "Guerrero", 1, 1, 1, 0, 0);
        Minions Totem11 = new Minions("Totem", 1, "Totem1", "Totem", 0, 2, 1, 0, 0);
       
        Minions Totem20 = new Minions("Totem", 1, "Totem2", "Totem", 0, 2, 1, 0, 0);
        Minions Totem30 = new Minions("Totem", 1, "Totem3", "Totem", 0, 2, 1, 0, 0);
        Minions Totem40 = new Minions("Totem", 1, "Totem4", "Totem", 0, 2, 1, 0, 0);



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

        BinaryFormatter bf = new BinaryFormatter();




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
                Paladin Jugador1 = new Paladin(30, 0, "Paladin", 0, 0, 0, 0, 0);
                Heroes.Add(Jugador1);
                
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

                BarraTableroj1.Visibility = Visibility.Visible;
                BarraTableroj2.Visibility = Visibility.Visible;
                Tableroj1.Visibility = Visibility.Visible;
                Tableroj2.Visibility = Visibility.Visible;
                Guardar.Visibility = Visibility.Visible;
                Manaj1.Visibility = Visibility.Visible;


                r2 = 1;
                r22 = 1;
                int t = MyV.QuienParte(Heroes[0], Heroes[1], MJugador1, MJugador2);
                AtacarHeroe.Visibility = Visibility.Visible;
                jugando = 0;

                JugadorUno.Visibility = Visibility.Visible;
                JugadorDos.Visibility = Visibility.Hidden;
                jugs.Jugars(Heroes[0], MJugador1);
                string va = Convert.ToString(Heroes[0].Mana);
                cantmana.Text = va;
                Manaj1.Value = Heroes[0].Mana;
                Rendirse.Visibility = Visibility.Visible;

                cantmana.Visibility = Visibility.Visible;
                Mano.Visibility = Visibility.Visible;
                BarraMano.Visibility = Visibility.Visible;
                Manaj1.Visibility = Visibility.Visible;
                Atacar.Visibility = Visibility.Visible;
                Manaj1.Value = Heroes[0].Mana;
                HabilidadHeroe.Visibility = Visibility.Visible;
                vidaheroejug.Visibility = Visibility.Visible;
                string f = Convert.ToString(Heroes[0].Vida);
                vidaheroejug.Text = "Heroe: " + Heroes[0].Nombre + "\n" + "Vida: " + f;

                Vidaheroenojug.Visibility = Visibility.Visible;
                string d = Convert.ToString(Heroes[1].Vida);
                Vidaheroenojug.Text = "Heroe: " + Heroes[1].Nombre + "\n" + "Vida: " + d;

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

                }
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

                BarraTableroj1.Visibility = Visibility.Visible;
                BarraTableroj2.Visibility = Visibility.Visible;
                Tableroj1.Visibility = Visibility.Visible;
                Tableroj2.Visibility = Visibility.Visible;
                Guardar.Visibility = Visibility.Visible;
                vidaheroejug.Visibility = Visibility.Visible;
                string f = Convert.ToString(Heroes[0].Vida);
                vidaheroejug.Text = "Heroe: " + Heroes[0].Nombre + "\n" + "Vida: " + f;

                Vidaheroenojug.Visibility = Visibility.Visible;
                string d = Convert.ToString(Heroes[1].Vida);
                Vidaheroenojug.Text = "Heroe: " + Heroes[1].Nombre + "\n" + "Vida: " + d;
                r2 = 2;
                r22 = 2;
                int t = MyV.QuienParte(Heroes[0], Heroes[1], MJugador1, MJugador2);

                jugando = 0;
                AtacarHeroe.Visibility = Visibility.Visible;
                JugadorUno.Visibility = Visibility.Visible;
                JugadorDos.Visibility = Visibility.Hidden;
                jugs.Jugars(Heroes[0], MJugador1);
                string va = Convert.ToString(Heroes[0].Mana);
                cantmana.Text = va;
                Manaj1.Value = Heroes[0].Mana;
                Rendirse.Visibility = Visibility.Visible;

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

                }
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
                AtacarHeroe.Visibility = Visibility.Visible;
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


                BarraTableroj1.Visibility = Visibility.Visible;
                BarraTableroj2.Visibility = Visibility.Visible;
                Tableroj1.Visibility = Visibility.Visible;
                Tableroj2.Visibility = Visibility.Visible;
                Guardar.Visibility = Visibility.Visible;
                r2 = 3;
                r22 = 3;
                int t = MyV.QuienParte(Heroes[0], Heroes[1], MJugador1, MJugador2);
                vidaheroejug.Visibility = Visibility.Visible;
                string f = Convert.ToString(Heroes[0].Vida);
                vidaheroejug.Text = "Heroe: " + Heroes[0].Nombre + "\n" + "Vida: " + f;

                Vidaheroenojug.Visibility = Visibility.Visible;
                string d = Convert.ToString(Heroes[1].Vida);
                Vidaheroenojug.Text = "Heroe: " + Heroes[1].Nombre + "\n" + "Vida: " + d;

                jugando = 0;

                JugadorUno.Visibility = Visibility.Visible;
                JugadorDos.Visibility = Visibility.Hidden;
                jugs.Jugars(Heroes[0], MJugador1);
                string va = Convert.ToString(Heroes[0].Mana);
                cantmana.Text = va;
                Manaj1.Value = Heroes[0].Mana;
                Rendirse.Visibility = Visibility.Visible;

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

                }
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
                AtacarHeroe.Visibility = Visibility.Visible;
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

                BarraTableroj1.Visibility = Visibility.Visible;
                BarraTableroj2.Visibility = Visibility.Visible;
                Tableroj1.Visibility = Visibility.Visible;
                Tableroj2.Visibility = Visibility.Visible;
                Guardar.Visibility = Visibility.Visible;
                r2 = 4;
                r22 = 4;
                int t = MyV.QuienParte(Heroes[0], Heroes[1], MJugador1, MJugador2);

                jugando = 0;

                vidaheroejug.Visibility = Visibility.Visible;
                string f = Convert.ToString(Heroes[0].Vida);
                vidaheroejug.Text = "Heroe: " + Heroes[0].Nombre + "\n" + "Vida: " + f;

                Vidaheroenojug.Visibility = Visibility.Visible;
                string d = Convert.ToString(Heroes[1].Vida);
                Vidaheroenojug.Text = "Heroe: " + Heroes[1].Nombre + "\n" + "Vida: " + d;

                JugadorUno.Visibility = Visibility.Visible;
                JugadorDos.Visibility = Visibility.Hidden;
                jugs.Jugars(Heroes[0], MJugador1);
                string va = Convert.ToString(Heroes[0].Mana);
                cantmana.Text = va;
                Manaj1.Value = Heroes[0].Mana;
                Rendirse.Visibility = Visibility.Visible;

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

                }
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
                AtacarHeroe.Visibility = Visibility.Visible;
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

                BarraTableroj1.Visibility = Visibility.Visible;
                BarraTableroj2.Visibility = Visibility.Visible;
                Tableroj1.Visibility = Visibility.Visible;
                Tableroj2.Visibility = Visibility.Visible;
                Guardar.Visibility = Visibility.Visible;
                r2 = 5;
                r22 = 5;
                int t = MyV.QuienParte(Heroes[0], Heroes[1], MJugador1, MJugador2);

                vidaheroejug.Visibility = Visibility.Visible;
                string f = Convert.ToString(Heroes[0].Vida);
                vidaheroejug.Text = "Heroe: " + Heroes[0].Nombre + "\n" + "Vida: " + f;

                Vidaheroenojug.Visibility = Visibility.Visible;
                string d = Convert.ToString(Heroes[1].Vida);
                Vidaheroenojug.Text = "Heroe: " + Heroes[1].Nombre + "\n" + "Vida: " + d;

                jugando = 0;

                JugadorUno.Visibility = Visibility.Visible;
                JugadorDos.Visibility = Visibility.Hidden;
                jugs.Jugars(Heroes[0], MJugador1);
                string va = Convert.ToString(Heroes[0].Mana);
                cantmana.Text = va;
                Manaj1.Value = Heroes[0].Mana;
                Rendirse.Visibility = Visibility.Visible;

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

                }
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
                AtacarHeroe.Visibility = Visibility.Visible;
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

                BarraTableroj1.Visibility = Visibility.Visible;
                BarraTableroj2.Visibility = Visibility.Visible;
                Tableroj1.Visibility = Visibility.Visible;
                Tableroj2.Visibility = Visibility.Visible;
                Guardar.Visibility = Visibility.Visible;
                r2 = 6;
                r22 = 6;
                int t = MyV.QuienParte(Heroes[0], Heroes[1], MJugador1, MJugador2);

                vidaheroejug.Visibility = Visibility.Visible;
                string f = Convert.ToString(Heroes[0].Vida);
                vidaheroejug.Text = "Heroe: " + Heroes[0].Nombre + "\n" + "Vida: " + f;

                Vidaheroenojug.Visibility = Visibility.Visible;
                string d = Convert.ToString(Heroes[1].Vida);
                Vidaheroenojug.Text = "Heroe: " + Heroes[1].Nombre + "\n" + "Vida: " + d;

                jugando = 0;

                JugadorUno.Visibility = Visibility.Visible;
                JugadorDos.Visibility = Visibility.Hidden;
                jugs.Jugars(Heroes[0], MJugador1);
                string va = Convert.ToString(Heroes[0].Mana);
                cantmana.Text = va;
                Manaj1.Value = Heroes[0].Mana;
                Rendirse.Visibility = Visibility.Visible;

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

                }
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
                AtacarHeroe.Visibility = Visibility.Visible;
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

                BarraTableroj1.Visibility = Visibility.Visible;
                BarraTableroj2.Visibility = Visibility.Visible;
                Tableroj1.Visibility = Visibility.Visible;
                Tableroj2.Visibility = Visibility.Visible;
                Guardar.Visibility = Visibility.Visible;
                r2 = 7;
                r22 = 7;
                int t = MyV.QuienParte(Heroes[0], Heroes[1], MJugador1, MJugador2);

                vidaheroejug.Visibility = Visibility.Visible;
                string f = Convert.ToString(Heroes[0].Vida);
                vidaheroejug.Text = "Heroe: " + Heroes[0].Nombre + "\n" + "Vida: " + f;

                Vidaheroenojug.Visibility = Visibility.Visible;
                string d = Convert.ToString(Heroes[1].Vida);
                Vidaheroenojug.Text = "Heroe: " + Heroes[1].Nombre + "\n" + "Vida: " + d;

                jugando = 0;

                JugadorUno.Visibility = Visibility.Visible;
                JugadorDos.Visibility = Visibility.Hidden;
                jugs.Jugars(Heroes[0], MJugador1);
                string va = Convert.ToString(Heroes[0].Mana);
                cantmana.Text = va;
                Manaj1.Value = Heroes[0].Mana;
                Rendirse.Visibility = Visibility.Visible;

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

                }
            }


        }

        private void Chaman_Click(object sender, RoutedEventArgs e)
        {
            if (JugadorUno.Visibility == Visibility.Visible && eligioheroe == 0)
            {
                AtacarHeroe.Visibility = Visibility.Visible;
                Chaman Jugador1 = new Chaman(30, 0, "Chaman", 0, 0, 0, 0, 0);
                Jugador1.Miespeciales.Add(Totem11);
                Jugador1.Miespeciales.Add(Totem20);
                Jugador1.Miespeciales.Add(Totem30);
                Jugador1.Miespeciales.Add(Totem40);
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
                
                Jugador2.Miespeciales.Add(Totem11);
                Jugador2.Miespeciales.Add(Totem20);
                Jugador2.Miespeciales.Add(Totem30);
                Jugador2.Miespeciales.Add(Totem40);
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

                BarraTableroj1.Visibility = Visibility.Visible;
                BarraTableroj2.Visibility = Visibility.Visible;
                Tableroj1.Visibility = Visibility.Visible;
                Tableroj2.Visibility = Visibility.Visible;
                Guardar.Visibility = Visibility.Visible;
                r2 = 8;
                r22 = 8;
                int t = MyV.QuienParte(Heroes[0], Heroes[1], MJugador1, MJugador2);

                vidaheroejug.Visibility = Visibility.Visible;
                string f = Convert.ToString(Heroes[0].Vida);
                vidaheroejug.Text = "Heroe: " + Heroes[0].Nombre + "\n" + "Vida: " + f;

                Vidaheroenojug.Visibility = Visibility.Visible;
                string d = Convert.ToString(Heroes[1].Vida);
                Vidaheroenojug.Text = "Heroe: " + Heroes[1].Nombre + "\n" + "Vida: " + d;

                jugando = 0;

                JugadorUno.Visibility = Visibility.Visible;
                JugadorDos.Visibility = Visibility.Hidden;
                jugs.Jugars(Heroes[0], MJugador1);
                string va = Convert.ToString(Heroes[0].Mana);
                cantmana.Text = va;
                Manaj1.Value = Heroes[0].Mana;
                Rendirse.Visibility = Visibility.Visible;

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

                }
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
                AtacarHeroe.Visibility = Visibility.Visible;
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

                Guardar.Visibility = Visibility.Visible;
                r2 = 9;
                r22 = 9;

                int t = MyV.QuienParte(Heroes[0], Heroes[1], MJugador1, MJugador2);

                vidaheroejug.Visibility = Visibility.Visible;
                string f = Convert.ToString(Heroes[0].Vida);
                vidaheroejug.Text = "Heroe: " + Heroes[0].Nombre + "\n" + "Vida: " + f;

                Vidaheroenojug.Visibility = Visibility.Visible;
                string d = Convert.ToString(Heroes[1].Vida);
                Vidaheroenojug.Text = "Heroe: " + Heroes[1].Nombre + "\n" + "Vida: " + d;

                jugando = 0;

                JugadorUno.Visibility = Visibility.Visible;
                JugadorDos.Visibility = Visibility.Hidden;
                jugs.Jugars(Heroes[0], MJugador1);
                string va = Convert.ToString(Heroes[0].Mana);
                cantmana.Text = va;
                Manaj1.Value = Heroes[0].Mana;
                Rendirse.Visibility = Visibility.Visible;

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

                }
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
            BarraTableroj1.Margin = new Thickness(142, 166, 156, 424);
            BarraTableroj2.Margin = new Thickness(142, 358, 157, 247);
            foreach (Minions y in Heroes[0].Tablero1)
            {
                y.NDT = 0;
            }


            foreach (Minions y in Heroes[1].Tablero1)
            {
                y.NDT = 0;
            }



            info.Visibility = Visibility.Hidden;
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

            Manaj1.Visibility = Visibility.Hidden;
            Atacar.Visibility = Visibility.Hidden;
            Rendirse.Visibility = Visibility.Hidden;
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

            jugando = 1;
            jugs.Jugars(Heroes[1], MJugador2);
            cantmana.Visibility = Visibility.Visible;
            string v = Convert.ToString(Heroes[1].Mana);
            cantmana.Text = v;
            JugadorDos.Visibility = Visibility.Visible;
            JugadorUno.Visibility = Visibility.Hidden;
            Mano.Visibility = Visibility.Visible;
            BarraMano.Visibility = Visibility.Visible;
            Manaj2.Value = Heroes[1].Mana;
            Manaj2.Visibility = Visibility.Visible;
            HabilidadHeroe.Visibility = Visibility.Visible;
            Atacar.Visibility = Visibility.Visible;
            Rendirse.Visibility = Visibility.Visible;

            vidaheroejug.Visibility = Visibility.Visible;
            string f = Convert.ToString(Heroes[1].Vida);
            vidaheroejug.Text = "Heroe: " + Heroes[1].Nombre + "\n" + "Vida: " + f;

            Vidaheroenojug.Visibility = Visibility.Visible;
            string d = Convert.ToString(Heroes[0].Vida);
            Vidaheroenojug.Text = "Heroe: " + Heroes[0].Nombre + "\n" + "Vida: " + d;

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


            }




        }


        private void FinTurno2_Click(object sender, RoutedEventArgs e)
        {
            BarraTableroj1.Margin = new Thickness(142, 358, 157, 247);
            BarraTableroj2.Margin = new Thickness(142, 166, 156, 424);
            foreach (Minions y in Heroes[1].Tablero1)
            {
                y.NDT = 0;
            }
            foreach (Minions y in Heroes[0].Tablero1)
            {
                y.NDT = 0;
            }
            jugs.Pasar(Heroes[1]);
            info.Visibility = Visibility.Hidden;
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

            Manaj2.Visibility = Visibility.Hidden;
            Atacar.Visibility = Visibility.Hidden;
            Rendirse.Visibility = Visibility.Hidden;
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

            jugando = 0;

            JugadorUno.Visibility = Visibility.Visible;
            JugadorDos.Visibility = Visibility.Hidden;
            jugs.Jugars(Heroes[0], MJugador1);
            string va = Convert.ToString(Heroes[0].Mana);
            cantmana.Text = va;
            Manaj1.Value = Heroes[0].Mana;
            Rendirse.Visibility = Visibility.Visible;

            cantmana.Visibility = Visibility.Visible;
            Mano.Visibility = Visibility.Visible;
            BarraMano.Visibility = Visibility.Visible;
            Manaj1.Visibility = Visibility.Visible;
            Atacar.Visibility = Visibility.Visible;
            Manaj1.Value = Heroes[0].Mana;
            HabilidadHeroe.Visibility = Visibility.Visible;

            vidaheroejug.Visibility = Visibility.Visible;
            string f = Convert.ToString(Heroes[0].Vida);
            vidaheroejug.Text = "Heroe: " + Heroes[0].Nombre + "\n" + "Vida: " + f;

            Vidaheroenojug.Visibility = Visibility.Visible;
            string d = Convert.ToString(Heroes[1].Vida);
            Vidaheroenojug.Text = "Heroe: " + Heroes[1].Nombre + "\n" + "Vida: " + d;



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

                        Wisp3.Visibility = Visibility.Hidden;
                        Wisp3j1.Visibility = Visibility.Visible;
                        Manaj1.Value = Heroes[0].Mana;
                        string va = Convert.ToString(Heroes[0].Mana);
                        cantmana.Text = va;
                    }
                }



            }
            else
            {
                if (Heroes[1].mano.Contains(wisp3))
                {

                    if (jugs.jugarcartar(Heroes[1], wisp3) == 1)
                    {

                        Wisp3.Visibility = Visibility.Hidden;
                        Wisp3j2.Visibility = Visibility.Visible;
                        Manaj2.Value = Heroes[1].Mana;
                        string v = Convert.ToString(Heroes[1].Mana);
                        cantmana.Text = v;

                    }
                }

            }
        }
        private void Wisp3_Clickj1(object sender, RoutedEventArgs e)
        {

            if (wisp3.Seleccionada == 0)
            {
                wisp3.Seleccionada = 1;
                Wisp3j1.BorderBrush = new SolidColorBrush(Colors.Gold);
                foreach (Minions i in Heroes[0].Tablero1)
                {
                    if (i.NombreCarta != "Wisp3")
                    { i.Seleccionada = 0; }

                }

                info.Visibility = Visibility.Visible;
                info.Text = " Carta: " + wisp3.NombreCarta + "\n" + "Vida: " + wisp3.Vida + "\n";
            }
            else
            {
                wisp3.Seleccionada = 0;
                Wisp3j1.BorderBrush = new SolidColorBrush(Colors.Transparent);

            }


        }
        private void Wisp1j2_Click(object sender, RoutedEventArgs e)
        {

            if (wisp1.Seleccionada == 0)
            {
                wisp1.Seleccionada = 1;
                Wisp1j2.BorderBrush = new SolidColorBrush(Colors.Gold);
                foreach (Minions i in Heroes[1].Tablero1)
                {
                    if (i.NombreCarta != "Wisp1")
                    { i.Seleccionada = 0; }

                }

                info.Visibility = Visibility.Visible;
                info.Text = " Carta: " + wisp1.NombreCarta + "\n" + "Vida: " + wisp1.Vida + "\n";

            }
            else
            {
                wisp1.Seleccionada = 0;
                Wisp1j2.BorderBrush = new SolidColorBrush(Colors.Transparent);
            }

        }

        private void Wisp3j2_Click(object sender, RoutedEventArgs e)
        {

            if (wisp3.Seleccionada == 0)
            {
                wisp3.Seleccionada = 1;
                Wisp3j2.BorderBrush = new SolidColorBrush(Colors.Gold);
                foreach (Minions i in Heroes[1].Tablero1)
                {
                    if (i.NombreCarta != "Wisp3")
                    { i.Seleccionada = 0; }

                }

                info.Visibility = Visibility.Visible;
                info.Text = " Carta: " + wisp3.NombreCarta + "\n" + "Vida: " + wisp3.Vida + "\n";
            }
            else
            {
                wisp3.Seleccionada = 0;
                Wisp3j2.BorderBrush = new SolidColorBrush(Colors.Transparent);
            }

        }
        private void Wisp2j2_Click(object sender, RoutedEventArgs e)
        {
            if (wisp2.Seleccionada == 0)
            {
                wisp2.Seleccionada = 1;
                Wisp2j2.BorderBrush = new SolidColorBrush(Colors.Gold);
                foreach (Minions i in Heroes[1].Tablero1)
                {
                    if (i.NombreCarta != "Wisp2")
                    { i.Seleccionada = 0; }

                }

                info.Visibility = Visibility.Visible;
                info.Text = " Carta: " + wisp2.NombreCarta + "\n" + "Vida: " + wisp2.Vida + "\n";
            }
            else
            {
                wisp2.Seleccionada = 0;
                Wisp2j2.BorderBrush = new SolidColorBrush(Colors.Transparent);
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

                        Bloodfen2.Visibility = Visibility.Hidden;
                        Bloodfen2j1.Visibility = Visibility.Visible;
                        Manaj1.Value = Heroes[0].Mana;
                        string va = Convert.ToString(Heroes[0].Mana);
                        cantmana.Text = va;
                    }
                }



            }
            else
            {
                if (Heroes[1].mano.Contains(bloodfen2))
                {

                    if (jugs.jugarcartar(Heroes[1], bloodfen2) == 1)
                    {

                        Bloodfen2.Visibility = Visibility.Hidden;
                        Bloodfen2j2.Visibility = Visibility.Visible;
                        Manaj2.Value = Heroes[1].Mana;
                        string v = Convert.ToString(Heroes[1].Mana);
                        cantmana.Text = v;
                    }
                }

            }

        }
        private void Bloodfen2_Clickj1(object sender, RoutedEventArgs e)
        {

            if (bloodfen2.Seleccionada == 0)
            {
                bloodfen2.Seleccionada = 1;
                Bloodfen2j1.BorderBrush = new SolidColorBrush(Colors.Gold);
                foreach (Minions i in Heroes[0].Tablero1)
                {
                    if (i.NombreCarta != "Bloodfen2")
                    { i.Seleccionada = 0; }

                }
                info.Visibility = Visibility.Visible;
                info.Text = " Carta: " + bloodfen2.NombreCarta + "\n" + "Vida: " + bloodfen2.Vida + "\n";
            }
            else
            {
                bloodfen2.Seleccionada = 0;
                Bloodfen2j1.BorderBrush = new SolidColorBrush(Colors.Transparent);
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

                        Wisp1.Visibility = Visibility.Hidden;
                        Wisp1j1.Visibility = Visibility.Visible;
                        Manaj1.Value = Heroes[0].Mana;
                        string va = Convert.ToString(Heroes[0].Mana);
                        cantmana.Text = va;
                    }
                }



            }
            else
            {
                if (Heroes[1].mano.Contains(wisp1))
                {

                    if (jugs.jugarcartar(Heroes[1], wisp1) == 1)
                    {

                        Wisp1.Visibility = Visibility.Hidden;
                        Wisp1j2.Visibility = Visibility.Visible;
                        Manaj2.Value = Heroes[1].Mana;
                        string v = Convert.ToString(Heroes[1].Mana);
                        cantmana.Text = v;
                    }
                }

            }

        }
        private void Wisp1_Clickj1(object sender, RoutedEventArgs e)
        {

            if (wisp1.Seleccionada == 0)
            {
                wisp1.Seleccionada = 1;
                Wisp1j1.BorderBrush = new SolidColorBrush(Colors.Gold);
                foreach (Minions i in Heroes[0].Tablero1)
                {
                    if (i.NombreCarta != "Wisp1")
                    { i.Seleccionada = 0; }

                }

                info.Visibility = Visibility.Visible;
                info.Text = " Carta: " + wisp1.NombreCarta + "\n" + "Vida: " + wisp1.Vida + "\n";
            }
            else
            {
                wisp1.Seleccionada = 0;
                Wisp1j1.BorderBrush = new SolidColorBrush(Colors.Transparent);
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

                        Wisp2.Visibility = Visibility.Hidden;
                        Wisp2j1.Visibility = Visibility.Visible;
                        Manaj1.Value = Heroes[0].Mana;
                        string va = Convert.ToString(Heroes[0].Mana);
                        cantmana.Text = va;
                    }
                }




            }
            else
            {
                if (Heroes[1].mano.Contains(wisp2))
                {

                    if (jugs.jugarcartar(Heroes[1], wisp2) == 1)
                    {

                        Wisp2.Visibility = Visibility.Hidden;
                        Wisp2j2.Visibility = Visibility.Visible;
                        Manaj2.Value = Heroes[1].Mana;
                        string v = Convert.ToString(Heroes[1].Mana);
                        cantmana.Text = v;
                    }
                }

            }

        }
        private void Wisp2_Clickj1(object sender, RoutedEventArgs e)
        {

            if (wisp2.Seleccionada == 0)
            {
                wisp2.Seleccionada = 1;
                Wisp2j1.BorderBrush = new SolidColorBrush(Colors.Gold);
                foreach (Minions i in Heroes[0].Tablero1)
                {
                    if (i.NombreCarta != "Wisp2")
                    { i.Seleccionada = 0; }

                }

                info.Visibility = Visibility.Visible;
                info.Text = " Carta: " + wisp2.NombreCarta + "\n" + "Vida: " + wisp2.Vida + "\n";

            }
            else
            {
                wisp2.Seleccionada = 0;
                Wisp2j1.BorderBrush = new SolidColorBrush(Colors.Transparent);
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

                        Bloodfen1.Visibility = Visibility.Hidden;
                        Bloodfen1j1.Visibility = Visibility.Visible;
                        Manaj1.Value = Heroes[0].Mana;
                        string va = Convert.ToString(Heroes[0].Mana);
                        cantmana.Text = va;
                    }
                }



            }
            else
            {
                if (Heroes[1].mano.Contains(bloodfen1))
                {

                    if (jugs.jugarcartar(Heroes[1], bloodfen1) == 1)
                    {

                        Bloodfen1.Visibility = Visibility.Hidden;
                        Bloodfen1j2.Visibility = Visibility.Visible;
                        Manaj2.Value = Heroes[1].Mana;
                        string v = Convert.ToString(Heroes[1].Mana);
                        cantmana.Text = v;
                    }
                }


            }

        }
        private void Bloodfen1_Clickj1(object sender, RoutedEventArgs e)
        {


            if (bloodfen1.Seleccionada == 0)
            {
                bloodfen1.Seleccionada = 1;
                Bloodfen1j1.BorderBrush = new SolidColorBrush(Colors.Gold);
                foreach (Minions i in Heroes[0].Tablero1)
                {
                    if (i.NombreCarta != "Bloodfen1")
                    { i.Seleccionada = 0; }

                }
                info.Visibility = Visibility.Visible;
                info.Text = " Carta: " + bloodfen1.NombreCarta + "\n" + "Vida: " + bloodfen1.Vida + "\n";
            }
            else
            {
                bloodfen1.Seleccionada = 0;
                Bloodfen1j1.BorderBrush = new SolidColorBrush(Colors.Transparent);
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

                        Bloodfen3.Visibility = Visibility.Hidden;
                        Bloodfen3j1.Visibility = Visibility.Visible;
                        Manaj1.Value = Heroes[0].Mana;
                        string va = Convert.ToString(Heroes[0].Mana);
                        cantmana.Text = va;
                    }
                }



            }
            else
            {
                if (Heroes[1].mano.Contains(bloodfen3))
                {

                    if (jugs.jugarcartar(Heroes[1], bloodfen3) == 1)
                    {

                        Bloodfen3.Visibility = Visibility.Hidden;
                        Bloodfen3j2.Visibility = Visibility.Visible;
                        Manaj2.Value = Heroes[1].Mana;
                        string v = Convert.ToString(Heroes[1].Mana);
                        cantmana.Text = v;
                    }
                }

            }
        }
        private void Bloodfen3_Clickj1(object sender, RoutedEventArgs e)
        {

            if (bloodfen3.Seleccionada == 0)
            {
                bloodfen3.Seleccionada = 1;
                Bloodfen3j1.BorderBrush = new SolidColorBrush(Colors.Gold);
                foreach (Minions i in Heroes[0].Tablero1)
                {
                    if (i.NombreCarta != "Bloodfen3")
                    { i.Seleccionada = 0; }

                }
                info.Visibility = Visibility.Visible;
                info.Text = " Carta: " + bloodfen3.NombreCarta + "\n" + "Vida: " + bloodfen3.Vida + "\n";
            }
            else
            {
                bloodfen3.Seleccionada = 0;
                Bloodfen3j1.BorderBrush = new SolidColorBrush(Colors.Transparent);
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

                        Boulderfist1.Visibility = Visibility.Hidden;
                        Boulderfist1j1.Visibility = Visibility.Visible;
                        Manaj1.Value = Heroes[0].Mana;
                        string va = Convert.ToString(Heroes[0].Mana);
                        cantmana.Text = va;
                    }
                }



            }
            else
            {
                if (Heroes[1].mano.Contains(boulderfist1))
                {

                    if (jugs.jugarcartar(Heroes[1], boulderfist1) == 1)
                    {

                        Boulderfist1.Visibility = Visibility.Hidden;
                        Boulderfist1j2.Visibility = Visibility.Visible;
                        Manaj2.Value = Heroes[1].Mana;
                        string v = Convert.ToString(Heroes[1].Mana);
                        cantmana.Text = v;
                    }
                }

            }
        }
        private void Boulderfist1_Clickj1(object sender, RoutedEventArgs e)
        {
            if (boulderfist1.Seleccionada == 0)
            { boulderfist1.Seleccionada = 1;
                Boulderfist1j1.BorderBrush = new SolidColorBrush(Colors.Gold);
                foreach (Minions i in Heroes[0].Tablero1)
                {
                    if (i.NombreCarta != "Boulderfist1")
                    { i.Seleccionada = 0; }

                }
                info.Visibility = Visibility.Visible;
                info.Text = " Carta: " + boulderfist1.NombreCarta + "\n" + "Vida: " + boulderfist1.Vida + "\n";
            }
            else { boulderfist1.Seleccionada = 0;
                Boulderfist1j1.BorderBrush = new SolidColorBrush(Colors.Transparent);
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

                        Boulderfist2.Visibility = Visibility.Hidden;
                        Boulderfist2j1.Visibility = Visibility.Visible;
                        Manaj1.Value = Heroes[0].Mana;
                        string va = Convert.ToString(Heroes[0].Mana);
                        cantmana.Text = va;
                    }
                }



            }
            else
            {
                if (Heroes[1].mano.Contains(boulderfist2))
                {

                    if (jugs.jugarcartar(Heroes[1], boulderfist2) == 1)
                    {

                        Boulderfist2.Visibility = Visibility.Hidden;
                        Boulderfist2j2.Visibility = Visibility.Visible;
                        Manaj2.Value = Heroes[1].Mana;
                        string v = Convert.ToString(Heroes[1].Mana);
                        cantmana.Text = v;
                    }
                }

            }
        }
        private void Boulderfist2_Clickj1(object sender, RoutedEventArgs e)
        {
            if (boulderfist2.Seleccionada == 0)
            { boulderfist2.Seleccionada = 1;
                Boulderfist2j1.BorderBrush = new SolidColorBrush(Colors.Gold);
                foreach (Minions i in Heroes[0].Tablero1)
                {
                    if (i.NombreCarta != "Boulderfist2")
                    { i.Seleccionada = 0; }

                }
                info.Visibility = Visibility.Visible;
                info.Text = " Carta: " + boulderfist2.NombreCarta + "\n" + "Vida: " + boulderfist2.Vida + "\n";
            }
            else { boulderfist2.Seleccionada = 0;
                Boulderfist2j1.BorderBrush = new SolidColorBrush(Colors.Transparent);
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

                        Boulderfist3.Visibility = Visibility.Hidden;
                        Boulderfist3j1.Visibility = Visibility.Visible;
                        Manaj1.Value = Heroes[0].Mana;
                        string va = Convert.ToString(Heroes[0].Mana);
                        cantmana.Text = va;
                    }
                }



            }
            else
            {
                if (Heroes[1].mano.Contains(boulderfist3))
                {

                    if (jugs.jugarcartar(Heroes[1], boulderfist3) == 1)
                    {

                        Boulderfist3.Visibility = Visibility.Hidden;
                        Boulderfist3j2.Visibility = Visibility.Visible;
                        Manaj2.Value = Heroes[1].Mana;
                        string v = Convert.ToString(Heroes[1].Mana);
                        cantmana.Text = v;
                    }
                }
            }
        }
        private void Boulderfist3_Clickj1(object sender, RoutedEventArgs e)
        {
            if (boulderfist3.Seleccionada == 0)
            {
                boulderfist3.Seleccionada = 1;
                Boulderfist3j1.BorderBrush = new SolidColorBrush(Colors.Gold);
                foreach (Minions i in Heroes[0].Tablero1)
                {
                    if (i.NombreCarta != "Boulderfist3")
                    { i.Seleccionada = 0; }

                }
                info.Visibility = Visibility.Visible;
                info.Text = " Carta: " + boulderfist3.NombreCarta + "\n" + "Vida: " + boulderfist3.Vida + "\n";
            }
            else
            {
                boulderfist3.Seleccionada = 0;
                Boulderfist3j1.BorderBrush = new SolidColorBrush(Colors.Transparent);
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

                        Chillwind1.Visibility = Visibility.Hidden;
                        Chillwind1j1.Visibility = Visibility.Visible;
                        Manaj1.Value = Heroes[0].Mana;
                        string va = Convert.ToString(Heroes[0].Mana);
                        cantmana.Text = va;
                    }
                }



            }
            else
            {
                if (Heroes[1].mano.Contains(chillwind1))
                {

                    if (jugs.jugarcartar(Heroes[1], chillwind1) == 1)
                    {

                        Chillwind1.Visibility = Visibility.Hidden;
                        Chillwind1j2.Visibility = Visibility.Visible;
                        Manaj2.Value = Heroes[1].Mana;
                        string v = Convert.ToString(Heroes[1].Mana);
                        cantmana.Text = v;
                    }
                }


            }
        }
        private void Chillwind1_Clickj1(object sender, RoutedEventArgs e)
        {

            if (chillwind1.Seleccionada == 0)
            {
                chillwind1.Seleccionada = 1;
                Chillwind1j1.BorderBrush = new SolidColorBrush(Colors.Gold);
                foreach (Minions i in Heroes[0].Tablero1)
                {
                    if (i.NombreCarta != "Chillwind1")
                    { i.Seleccionada = 0; }

                }
                info.Visibility = Visibility.Visible;
                info.Text = " Carta: " + chillwind1.NombreCarta + "\n" + "Vida: " + chillwind1.Vida + "\n";
            }
            else
            {
                chillwind1.Seleccionada = 0;
                Chillwind1j1.BorderBrush = new SolidColorBrush(Colors.Transparent);
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

                        Chillwind2.Visibility = Visibility.Hidden;
                        Chillwind2j1.Visibility = Visibility.Visible;
                        Manaj1.Value = Heroes[0].Mana;
                        string va = Convert.ToString(Heroes[0].Mana);
                        cantmana.Text = va;
                    }
                }




            }
            else
            {
                if (Heroes[1].mano.Contains(chillwind2))
                {

                    if (jugs.jugarcartar(Heroes[1], chillwind2) == 1)
                    {

                        Chillwind2.Visibility = Visibility.Hidden;
                        Chillwind2j2.Visibility = Visibility.Visible;
                        Manaj2.Value = Heroes[1].Mana;
                        string v = Convert.ToString(Heroes[1].Mana);
                        cantmana.Text = v;
                    }
                }
            }

        }
        private void Chillwind2_Clickj1(object sender, RoutedEventArgs e)
        {

            if (chillwind2.Seleccionada == 0)
            {
                chillwind2.Seleccionada = 1;
                Chillwind2j1.BorderBrush = new SolidColorBrush(Colors.Gold);
                foreach (Minions i in Heroes[0].Tablero1)
                {
                    if (i.NombreCarta != "Chillwind2")
                    { i.Seleccionada = 0; }

                }
                info.Visibility = Visibility.Visible;
                info.Text = " Carta: " + chillwind2.NombreCarta + "\n" + "Vida: " + chillwind2.Vida + "\n";
            }
            else
            {
                chillwind2.Seleccionada = 0;
                Chillwind2j1.BorderBrush = new SolidColorBrush(Colors.Transparent);
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

                        Chillwind3.Visibility = Visibility.Hidden;
                        Chillwind3j1.Visibility = Visibility.Visible;
                        Manaj1.Value = Heroes[0].Mana;
                        string va = Convert.ToString(Heroes[0].Mana);
                        cantmana.Text = va;
                    }
                }



            }
            else
            {
                if (Heroes[1].mano.Contains(chillwind3))
                {

                    if (jugs.jugarcartar(Heroes[1], chillwind3) == 1)
                    {

                        Chillwind3.Visibility = Visibility.Hidden;
                        Chillwind3j2.Visibility = Visibility.Visible;
                        Manaj2.Value = Heroes[1].Mana;
                        string v = Convert.ToString(Heroes[1].Mana);
                        cantmana.Text = v;
                    }
                }

            }
        }
        private void Chillwind3_Clickj1(object sender, RoutedEventArgs e)
        {

            if (chillwind3.Seleccionada == 0)
            {
                chillwind3.Seleccionada = 1;
                Chillwind3j1.BorderBrush = new SolidColorBrush(Colors.Gold);
                foreach (Minions i in Heroes[0].Tablero1)
                {
                    if (i.NombreCarta != "Chillwind3")
                    { i.Seleccionada = 0; }

                }
                info.Visibility = Visibility.Visible;
                info.Text = " Carta: " + chillwind3.NombreCarta + "\n" + "Vida: " + chillwind3.Vida + "\n";
            }
            else
            {
                chillwind3.Seleccionada = 0;
                Chillwind3j1.BorderBrush = new SolidColorBrush(Colors.Gold);
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


                        Corehound1.Visibility = Visibility.Hidden;
                        Corehound1j1.Visibility = Visibility.Visible;
                        Manaj1.Value = Heroes[0].Mana;
                        string va = Convert.ToString(Heroes[0].Mana);
                        cantmana.Text = va;
                    }
                }



            }
            else
            {
                if (Heroes[1].mano.Contains(core1))
                {

                    if (jugs.jugarcartar(Heroes[1], core1) == 1)
                    {

                        Corehound1.Visibility = Visibility.Hidden;
                        Corehound1j2.Visibility = Visibility.Visible;
                        Manaj2.Value = Heroes[1].Mana;
                        string v = Convert.ToString(Heroes[1].Mana);
                        cantmana.Text = v;
                    }
                }
            }
        }
        private void Corehound1_Clickj1(object sender, RoutedEventArgs e)
        {

            if (core1.Seleccionada == 0)
            {
                core1.Seleccionada = 1;
                Corehound1j1.BorderBrush = new SolidColorBrush(Colors.Gold);
                foreach (Minions i in Heroes[0].Tablero1)
                {
                    if (i.NombreCarta != "Corehound1")
                    { i.Seleccionada = 0; }

                }
                info.Visibility = Visibility.Visible;
                info.Text = " Carta: " + core1.NombreCarta + "\n" + "Vida: " + core1.Vida + "\n";
            }
            else
            {
                core1.Seleccionada = 0;
                Corehound1j1.BorderBrush = new SolidColorBrush(Colors.Transparent);
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

                        Corehound2.Visibility = Visibility.Hidden;
                        Corehound2j1.Visibility = Visibility.Visible;
                        Manaj1.Value = Heroes[0].Mana;
                        string va = Convert.ToString(Heroes[0].Mana);
                        cantmana.Text = va;
                    }
                }




            }
            else
            {
                if (Heroes[1].mano.Contains(core2))
                {

                    if (jugs.jugarcartar(Heroes[1], core2) == 1)
                    {

                        Corehound2.Visibility = Visibility.Hidden;
                        Corehound2j2.Visibility = Visibility.Visible;
                        Manaj2.Value = Heroes[1].Mana;
                        string v = Convert.ToString(Heroes[1].Mana);
                        cantmana.Text = v;
                    }
                }

            }
        }
        private void Corehound2_Clickj1(object sender, RoutedEventArgs e)
        {

            if (core2.Seleccionada == 0)
            {
                core2.Seleccionada = 1;
                Corehound2j1.BorderBrush = new SolidColorBrush(Colors.Gold);
                foreach (Minions i in Heroes[0].Tablero1)
                {
                    if (i.NombreCarta != "Corehound2")
                    { i.Seleccionada = 0; }

                }
                info.Visibility = Visibility.Visible;
                info.Text = " Carta: " + core2.NombreCarta + "\n" + "Vida: " + core2.Vida + "\n";
            }
            else
            {
                core2.Seleccionada = 0;
                Corehound2j1.BorderBrush = new SolidColorBrush(Colors.Transparent);
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

                        Corehound3.Visibility = Visibility.Hidden;
                        Corehound3j1.Visibility = Visibility.Visible;
                        Manaj1.Value = Heroes[0].Mana;
                        string va = Convert.ToString(Heroes[0].Mana);
                        cantmana.Text = va;
                    }
                }



            }
            else
            {
                if (Heroes[1].mano.Contains(core3))
                {

                    if (jugs.jugarcartar(Heroes[1], core3) == 1)
                    {

                        Corehound3.Visibility = Visibility.Hidden;
                        Corehound3j2.Visibility = Visibility.Visible;
                        Manaj2.Value = Heroes[1].Mana;
                        string v = Convert.ToString(Heroes[1].Mana);
                        cantmana.Text = v;
                    }
                }

            }
        }
        private void Corehound3_Clickj1(object sender, RoutedEventArgs e)
        {

            if (core3.Seleccionada == 0)
            { core3.Seleccionada = 1;
                Corehound3j1.BorderBrush = new SolidColorBrush(Colors.Gold);
                foreach (Minions i in Heroes[0].Tablero1)
                {
                    if (i.NombreCarta != "Corehound3")
                    { i.Seleccionada = 0; }

                }
                info.Visibility = Visibility.Visible;
                info.Text = " Carta: " + core3.NombreCarta + "\n" + "Vida: " + core3.Vida + "\n";
            }
            else { core3.Seleccionada = 0;
                Corehound3j1.BorderBrush = new SolidColorBrush(Colors.Transparent);
            }
        }
        private void Bloodfen1j2_Click(object sender, RoutedEventArgs e)
        {


            if (bloodfen1.Seleccionada == 0)
            {
                bloodfen1.Seleccionada = 1;
                Bloodfen1j2.BorderBrush = new SolidColorBrush(Colors.Gold);
                foreach (Minions i in Heroes[1].Tablero1)
                {
                    if (i.NombreCarta != "Bloodfen1")
                    { i.Seleccionada = 0; }

                }
                info.Visibility = Visibility.Visible;
                info.Text = " Carta: " + bloodfen1.NombreCarta + "\n" + "Vida: " + bloodfen1.Vida + "\n";
            }
            else
            {
                bloodfen1.Seleccionada = 0;
                Bloodfen1j2.BorderBrush = new SolidColorBrush(Colors.Transparent);
            }

        }

        private void Bloodfen2j2_Click(object sender, RoutedEventArgs e)
        {
            if (bloodfen2.Seleccionada == 0)
            {
                bloodfen2.Seleccionada = 1;
                Bloodfen2j2.BorderBrush = new SolidColorBrush(Colors.Gold);
                foreach (Minions i in Heroes[1].Tablero1)
                {
                    if (i.NombreCarta != "Bloodfen2")
                    { i.Seleccionada = 0; }

                }
                info.Visibility = Visibility.Visible;
                info.Text = " Carta: " + bloodfen2.NombreCarta + "\n" + "Vida: " + bloodfen2.Vida + "\n";
            }
            else
            {
                bloodfen2.Seleccionada = 0;
                Bloodfen2j2.BorderBrush = new SolidColorBrush(Colors.Transparent);
            }
        }
        private void Bloodfen3j2_Click(object sender, RoutedEventArgs e)
        {
            if (bloodfen3.Seleccionada == 0)
            {
                bloodfen3.Seleccionada = 1;
                Bloodfen3j2.BorderBrush = new SolidColorBrush(Colors.Gold);
                foreach (Minions i in Heroes[1].Tablero1)
                {
                    if (i.NombreCarta != "Bloodfen3")
                    { i.Seleccionada = 0; }

                }
                info.Visibility = Visibility.Visible;
                info.Text = " Carta: " + bloodfen3.NombreCarta + "\n" + "Vida: " + bloodfen3.Vida + "\n";
            }
            else
            {
                bloodfen3.Seleccionada = 0;
                Bloodfen3j2.BorderBrush = new SolidColorBrush(Colors.Transparent);
            }

        }


        private void Boulderfist1j2_Click(object sender, RoutedEventArgs e)
        {
            if (boulderfist1.Seleccionada == 0)
            {
                boulderfist1.Seleccionada = 1;
                Boulderfist1j2.BorderBrush = new SolidColorBrush(Colors.Gold);
                foreach (Minions i in Heroes[1].Tablero1)
                {
                    if (i.NombreCarta != "Boulderfist1")
                    { i.Seleccionada = 0; }

                }
                info.Visibility = Visibility.Visible;
                info.Text = " Carta: " + boulderfist1.NombreCarta + "\n" + "Vida: " + boulderfist1.Vida + "\n";
            }
            else
            {
                boulderfist1.Seleccionada = 0;
                Boulderfist1j2.BorderBrush = new SolidColorBrush(Colors.Transparent);
            }

        }

        private void Boulderfist2j2_Click(object sender, RoutedEventArgs e)
        {

            if (boulderfist2.Seleccionada == 0)
            {
                boulderfist2.Seleccionada = 1;
                Boulderfist2j2.BorderBrush = new SolidColorBrush(Colors.Gold);
                foreach (Minions i in Heroes[1].Tablero1)
                {
                    if (i.NombreCarta != "Boulderfist2")
                    { i.Seleccionada = 0; }

                }
                info.Visibility = Visibility.Visible;
                info.Text = " Carta: " + boulderfist2.NombreCarta + "\n" + "Vida: " + boulderfist2.Vida + "\n";
            }
            else
            {
                boulderfist2.Seleccionada = 0;
                Boulderfist2j2.BorderBrush = new SolidColorBrush(Colors.Transparent);
            }

        }


        private void Boulderfist3j2_Click(object sender, RoutedEventArgs e)
        {

            if (boulderfist3.Seleccionada == 0)
            {
                boulderfist3.Seleccionada = 1;
                Boulderfist3j2.BorderBrush = new SolidColorBrush(Colors.Gold);
                foreach (Minions i in Heroes[1].Tablero1)
                {
                    if (i.NombreCarta != "Boulderfist3")
                    { i.Seleccionada = 0; }

                }
                info.Visibility = Visibility.Visible;
                info.Text = " Carta: " + boulderfist3.NombreCarta + "\n" + "Vida: " + boulderfist3.Vida + "\n";
            }
            else
            {
                boulderfist3.Seleccionada = 0;
                Boulderfist3j2.BorderBrush = new SolidColorBrush(Colors.Transparent);
            }

        }


        private void Chillwind1j2_Click(object sender, RoutedEventArgs e)
        {
            if (chillwind1.Seleccionada == 0)
            {
                chillwind1.Seleccionada = 1;
                Chillwind1j2.BorderBrush = new SolidColorBrush(Colors.Gold);
                foreach (Minions i in Heroes[1].Tablero1)
                {
                    if (i.NombreCarta != "Chillwind1")
                    { i.Seleccionada = 0; }

                }
                info.Visibility = Visibility.Visible;
                info.Text = " Carta: " + chillwind1.NombreCarta + "\n" + "Vida: " + chillwind1.Vida + "\n";
            }
            else
            {
                chillwind1.Seleccionada = 0;
                Chillwind1j2.BorderBrush = new SolidColorBrush(Colors.Transparent);
            }

        }

        private void Chillwind2j2_Click(object sender, RoutedEventArgs e)
        {
            if (chillwind2.Seleccionada == 0)
            {
                chillwind2.Seleccionada = 1;
                Chillwind2j2.BorderBrush = new SolidColorBrush(Colors.Gold);
                foreach (Minions i in Heroes[1].Tablero1)
                {
                    if (i.NombreCarta != "Chillwind2")
                    { i.Seleccionada = 0; }

                }
                info.Visibility = Visibility.Visible;
                info.Text = " Carta: " + chillwind2.NombreCarta + "\n" + "Vida: " + chillwind2.Vida + "\n";
            }
            else
            {
                chillwind2.Seleccionada = 0;
                Chillwind2j2.BorderBrush = new SolidColorBrush(Colors.Transparent);
            }

        }
        private void Chillwind3j2_Click(object sender, RoutedEventArgs e)
        {
            if (chillwind3.Seleccionada == 0)
            {
                chillwind3.Seleccionada = 1;
                Chillwind3j2.BorderBrush = new SolidColorBrush(Colors.Gold);
                foreach (Minions i in Heroes[1].Tablero1)
                {
                    if (i.NombreCarta != "Chillwind3")
                    { i.Seleccionada = 0; }

                }
                info.Visibility = Visibility.Visible;
                info.Text = " Carta: " + chillwind3.NombreCarta + "\n" + "Vida: " + chillwind3.Vida + "\n";
            }
            else
            {
                chillwind3.Seleccionada = 0;
                Chillwind3j2.BorderBrush = new SolidColorBrush(Colors.Transparent);
            }

        }

        private void Corehound1j2_Click(object sender, RoutedEventArgs e)
        {
            if (core1.Seleccionada == 0)
            {
                core1.Seleccionada = 1;
                Corehound1j2.BorderBrush = new SolidColorBrush(Colors.Gold);
                foreach (Minions i in Heroes[1].Tablero1)
                {
                    if (i.NombreCarta != "Corehound1")
                    { i.Seleccionada = 0; }

                }
                info.Visibility = Visibility.Visible;
                info.Text = " Carta: " + core1.NombreCarta + "\n" + "Vida: " + core1.Vida + "\n";
            }
            else
            {
                core1.Seleccionada = 0;
                Corehound1j2.BorderBrush = new SolidColorBrush(Colors.Transparent);
            }

        }

        private void Corehound2j2_Click(object sender, RoutedEventArgs e)
        {
            if (core2.Seleccionada == 0)
            {
                core2.Seleccionada = 1;
                Corehound2j2.BorderBrush = new SolidColorBrush(Colors.Gold);
                foreach (Minions i in Heroes[1].Tablero1)
                {
                    if (i.NombreCarta != "Corehound2")
                    { i.Seleccionada = 0; }

                }
                info.Visibility = Visibility.Visible;
                info.Text = " Carta: " + core2.NombreCarta + "\n" + "Vida: " + core2.Vida + "\n";
            }
            else
            {
                core2.Seleccionada = 0;
                Corehound2j2.BorderBrush = new SolidColorBrush(Colors.Transparent);
            }

        }


        private void Corehound3j2_Click(object sender, RoutedEventArgs e)
        {
            if (core3.Seleccionada == 0)
            {
                core3.Seleccionada = 1;
                Corehound3j2.BorderBrush = new SolidColorBrush(Colors.Gold);
                foreach (Minions i in Heroes[1].Tablero1)
                {
                    if (i.NombreCarta != "Corehound3")
                    { i.Seleccionada = 0; }

                }
                info.Visibility = Visibility.Visible;
                info.Text = " Carta: " + core3.NombreCarta + "\n" + "Vida: " + core3.Vida + "\n";
            }
            else
            {
                core3.Seleccionada = 0;
                Corehound3j2.BorderBrush = new SolidColorBrush(Colors.Transparent);
            }

        }
        private void Magma1j2_Click(object sender, RoutedEventArgs e)
        {
            if (magma1.Seleccionada == 0)
            {
                magma1.Seleccionada = 1;
                Magma1j2.BorderBrush = new SolidColorBrush(Colors.Gold);
                foreach (Minions i in Heroes[1].Tablero1)
                {
                    if (i.NombreCarta != "Magma1")
                    { i.Seleccionada = 0; }

                }
                info.Visibility = Visibility.Visible;
                info.Text = " Carta: " + magma1.NombreCarta + "\n" + "Vida: " + magma1.Vida + "\n";
            }
            else
            {
                magma1.Seleccionada = 0;
                Magma1j2.BorderBrush = new SolidColorBrush(Colors.Transparent);
            }

        }
        private void Magma2j2_Click(object sender, RoutedEventArgs e)
        {
            if (magma2.Seleccionada == 0)
            {
                magma2.Seleccionada = 1;
                Magma2j2.BorderBrush = new SolidColorBrush(Colors.Gold);
                foreach (Minions i in Heroes[1].Tablero1)
                {
                    if (i.NombreCarta != "Magma2")
                    { i.Seleccionada = 0; }

                }
                info.Visibility = Visibility.Visible;
                info.Text = " Carta: " + magma2.NombreCarta + "\n" + "Vida: " + magma2.Vida + "\n";
            }
            else
            {
                magma2.Seleccionada = 0;
                Magma2j2.BorderBrush = new SolidColorBrush(Colors.Transparent);
            }

        }

        private void Magma3j2_Click(object sender, RoutedEventArgs e)
        {

            if (magma3.Seleccionada == 0)
            {
                magma3.Seleccionada = 1;
                Magma3j2.BorderBrush = new SolidColorBrush(Colors.Gold);
                foreach (Minions i in Heroes[1].Tablero1)
                {
                    if (i.NombreCarta != "Magma3")
                    { i.Seleccionada = 0; }

                }
                info.Visibility = Visibility.Visible;
                info.Text = " Carta: " + magma3.NombreCarta + "\n" + "Vida: " + magma3.Vida + "\n";
            }
            else
            {
                magma3.Seleccionada = 0;
                Magma3j2.BorderBrush = new SolidColorBrush(Colors.Transparent);
            }

        }

        private void Murloc1j2_Click(object sender, RoutedEventArgs e)
        {
            if (murloc1.Seleccionada == 0)
            {
                murloc1.Seleccionada = 1;
                Murloc1j2.BorderBrush = new SolidColorBrush(Colors.Gold);
                foreach (Minions i in Heroes[1].Tablero1)
                {
                    if (i.NombreCarta != "Murloc1")
                    { i.Seleccionada = 0; }

                }
                info.Visibility = Visibility.Visible;
                info.Text = " Carta: " + murloc1.NombreCarta + "\n" + "Vida: " + murloc1.Vida + "\n";
            }
            else
            {
                murloc1.Seleccionada = 0;
                Murloc1j2.BorderBrush = new SolidColorBrush(Colors.Transparent);
            }

        }

        private void Murloc2j2_Click(object sender, RoutedEventArgs e)
        {
            if (murloc2.Seleccionada == 0)
            {
                murloc2.Seleccionada = 1;
                Murloc2j2.BorderBrush = new SolidColorBrush(Colors.Gold);
                foreach (Minions i in Heroes[1].Tablero1)
                {
                    if (i.NombreCarta != "Murloc2")
                    { i.Seleccionada = 0; }

                }
                info.Visibility = Visibility.Visible;
                info.Text = " Carta: " + murloc2.NombreCarta + "\n" + "Vida: " + murloc2.Vida + "\n";
            }
            else
            {
                murloc2.Seleccionada = 0;
                Murloc2j2.BorderBrush = new SolidColorBrush(Colors.Transparent);
            }

        }
        private void Murloc3j2_Click(object sender, RoutedEventArgs e)
        {
            if (murloc3.Seleccionada == 0)
            {
                murloc3.Seleccionada = 1;
                Murloc3j2.BorderBrush = new SolidColorBrush(Colors.Gold);
                foreach (Minions i in Heroes[1].Tablero1)
                {
                    if (i.NombreCarta != "Murloc3")
                    { i.Seleccionada = 0; }

                }
                info.Visibility = Visibility.Visible;
                info.Text = " Carta: " + murloc3.NombreCarta + "\n" + "Vida: " + murloc3.Vida + "\n";
            }
            else
            {
                murloc3.Seleccionada = 0;
                Murloc3j2.BorderBrush = new SolidColorBrush(Colors.Transparent);
            }

        }
        private void Oasis1j2_Click(object sender, RoutedEventArgs e)
        {
            if (oasis1.Seleccionada == 0)
            {
                oasis1.Seleccionada = 1;
                Oasis1j2.BorderBrush = new SolidColorBrush(Colors.Gold);
                foreach (Minions i in Heroes[1].Tablero1)
                {
                    if (i.NombreCarta != "Oasis1")
                    { i.Seleccionada = 0; }

                }
                info.Visibility = Visibility.Visible;
                info.Text = " Carta: " + oasis1.NombreCarta + "\n" + "Vida: " + oasis1.Vida + "\n";
            }
            else
            {
                oasis1.Seleccionada = 0;
                Oasis1j2.BorderBrush = new SolidColorBrush(Colors.Gold);
            }

        }
        private void Oasis2j2_Click(object sender, RoutedEventArgs e)
        {
            if (oasis2.Seleccionada == 0)
            {
                oasis2.Seleccionada = 1;
                Oasis2j2.BorderBrush = new SolidColorBrush(Colors.Gold);
                foreach (Minions i in Heroes[1].Tablero1)
                {
                    if (i.NombreCarta != "Oasis2")
                    { i.Seleccionada = 0; }

                }
                info.Visibility = Visibility.Visible;
                info.Text = " Carta: " + oasis2.NombreCarta + "\n" + "Vida: " + oasis2.Vida + "\n";
            }
            else
            {
                oasis2.Seleccionada = 0;
                Oasis2j2.BorderBrush = new SolidColorBrush(Colors.Transparent);
            }

        }

        private void Oasis3j2_Click(object sender, RoutedEventArgs e)
        {
            if (oasis3.Seleccionada == 0)
            {
                oasis3.Seleccionada = 1;
                Oasis3j2.BorderBrush = new SolidColorBrush(Colors.Gold);
                foreach (Minions i in Heroes[1].Tablero1)
                {
                    if (i.NombreCarta != "Oasis3")
                    { i.Seleccionada = 0; }

                }
                info.Visibility = Visibility.Visible;
                info.Text = " Carta: " + oasis3.NombreCarta + "\n" + "Vida: " + oasis3.Vida + "\n";
            }
            else
            {
                oasis3.Seleccionada = 0;
                Oasis3j2.BorderBrush = new SolidColorBrush(Colors.Transparent);
            }

        }
        private void River1j2_Click(object sender, RoutedEventArgs e)
        {
            if (river1.Seleccionada == 0)
            {
                river1.Seleccionada = 1;
                River1j2.BorderBrush = new SolidColorBrush(Colors.Gold);
                foreach (Minions i in Heroes[1].Tablero1)
                {
                    if (i.NombreCarta != "River1")
                    { i.Seleccionada = 0; }

                }
                info.Visibility = Visibility.Visible;
                info.Text = " Carta: " + river1.NombreCarta + "\n" + "Vida: " + river1.Vida + "\n";
            }
            else
            {
                river1.Seleccionada = 0;
                River1j2.BorderBrush = new SolidColorBrush(Colors.Transparent);
            }

        }
        private void River2j2_Click(object sender, RoutedEventArgs e)
        {
            if (river2.Seleccionada == 0)
            {
                river2.Seleccionada = 1;
                River2j2.BorderBrush = new SolidColorBrush(Colors.Gold);
                foreach (Minions i in Heroes[1].Tablero1)
                {
                    if (i.NombreCarta != "River2")
                    { i.Seleccionada = 0; }

                }
                info.Visibility = Visibility.Visible;
                info.Text = " Carta: " + river2.NombreCarta + "\n" + "Vida: " + river2.Vida + "\n";
            }
            else
            {
                river2.Seleccionada = 0;
                River2j2.BorderBrush = new SolidColorBrush(Colors.Transparent);
            }

        }
        private void River3j2_Click(object sender, RoutedEventArgs e)
        {
            if (river3.Seleccionada == 0)
            {
                river3.Seleccionada = 1;
                River3j2.BorderBrush = new SolidColorBrush(Colors.Gold);
                foreach (Minions i in Heroes[1].Tablero1)
                {
                    if (i.NombreCarta != "River3")
                    { i.Seleccionada = 0; }

                }
                info.Visibility = Visibility.Visible;
                info.Text = " Carta: " + river3.NombreCarta + "\n" + "Vida: " + river3.Vida + "\n";
            }
            else
            {
                river3.Seleccionada = 0;
                River3j2.BorderBrush = new SolidColorBrush(Colors.Transparent);
            }

        }
        private void War1j2_Click(object sender, RoutedEventArgs e)
        {
            if (war1.Seleccionada == 0)
            {
                war1.Seleccionada = 1;
                War1j2.BorderBrush = new SolidColorBrush(Colors.Gold);
                foreach (Minions i in Heroes[1].Tablero1)
                {
                    if (i.NombreCarta != "War1")
                    { i.Seleccionada = 0; }

                }
                info.Visibility = Visibility.Visible;
                info.Text = " Carta: " + war1.NombreCarta + "\n" + "Vida: " + war1.Vida + "\n";
            }
            else
            {
                war1.Seleccionada = 0;
                War1j2.BorderBrush = new SolidColorBrush(Colors.Transparent);
            }

        }

        private void War2j2_Click(object sender, RoutedEventArgs e)
        {
            if (war2.Seleccionada == 0)
            {
                war2.Seleccionada = 1;
                War2j2.BorderBrush = new SolidColorBrush(Colors.Gold);
                foreach (Minions i in Heroes[1].Tablero1)
                {
                    if (i.NombreCarta != "War2")
                    { i.Seleccionada = 0; }

                }
                info.Visibility = Visibility.Visible;
                info.Text = " Carta: " + war2.NombreCarta + "\n" + "Vida: " + war2.Vida + "\n";
            }
            else
            {
                war2.Seleccionada = 0;
                War2j2.BorderBrush = new SolidColorBrush(Colors.Transparent);
            }

        }

        private void War3j2_Click(object sender, RoutedEventArgs e)
        {
            if (war3.Seleccionada == 0)
            {
                war3.Seleccionada = 1;
                War3j2.BorderBrush = new SolidColorBrush(Colors.Gold);
                foreach (Minions i in Heroes[1].Tablero1)
                {
                    if (i.NombreCarta != "War3")
                    { i.Seleccionada = 0; }

                }
                info.Visibility = Visibility.Visible;
                info.Text = " Carta: " + war3.NombreCarta + "\n" + "Vida: " + war3.Vida + "\n";
            }
            else
            {
                war3.Seleccionada = 0;
                War3j2.BorderBrush = new SolidColorBrush(Colors.Transparent);
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

                        Magma1.Visibility = Visibility.Hidden;
                        Magma1j1.Visibility = Visibility.Visible;
                        Manaj1.Value = Heroes[0].Mana;
                        string va = Convert.ToString(Heroes[0].Mana);
                        cantmana.Text = va;
                    }
                }


            }
            else
            {
                if (Heroes[1].mano.Contains(magma1))
                {

                    if (jugs.jugarcartar(Heroes[1], magma1) == 1)
                    {

                        Magma1.Visibility = Visibility.Hidden;
                        Magma1j2.Visibility = Visibility.Visible;
                        Manaj2.Value = Heroes[1].Mana;
                        string v = Convert.ToString(Heroes[1].Mana);
                        cantmana.Text = v;
                    }
                }

            }
        }
        private void Magma1_Clickj1(object sender, RoutedEventArgs e)
        {

            if (magma1.Seleccionada == 0)
            {
                magma1.Seleccionada = 1;
                Magma1j1.BorderBrush = new SolidColorBrush(Colors.Gold);
                foreach (Minions i in Heroes[0].Tablero1)
                {
                    if (i.NombreCarta != "Magma1")
                    { i.Seleccionada = 0; }

                }
                info.Visibility = Visibility.Visible;
                info.Text = " Carta: " + magma1.NombreCarta + "\n" + "Vida: " + magma1.Vida + "\n";
            }
            else
            {
                magma1.Seleccionada = 0;
                Magma1j1.BorderBrush = new SolidColorBrush(Colors.Transparent);
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

                        Magma2.Visibility = Visibility.Hidden;
                        Magma2j1.Visibility = Visibility.Visible;
                        Manaj1.Value = Heroes[0].Mana;
                        string va = Convert.ToString(Heroes[0].Mana);
                        cantmana.Text = va;
                    }
                }


            }
            else
            {
                if (Heroes[1].mano.Contains(magma2))
                {

                    if (jugs.jugarcartar(Heroes[1], magma2) == 1)
                    {

                        Magma2.Visibility = Visibility.Hidden;
                        Magma2j2.Visibility = Visibility.Visible;
                        Manaj2.Value = Heroes[1].Mana;
                        string v = Convert.ToString(Heroes[1].Mana);
                        cantmana.Text = v;
                    }
                }
            }
        }
        private void Magma2_Clickj1(object sender, RoutedEventArgs e)
        {

            if (magma2.Seleccionada == 0)
            {
                magma2.Seleccionada = 1;
                Magma2j1.BorderBrush = new SolidColorBrush(Colors.Gold);
                foreach (Minions i in Heroes[0].Tablero1)
                {
                    if (i.NombreCarta != "Magma2")
                    { i.Seleccionada = 0; }

                }
                info.Visibility = Visibility.Visible;
                info.Text = " Carta: " + magma2.NombreCarta + "\n" + "Vida: " + magma2.Vida + "\n";
            }
            else
            {
                magma2.Seleccionada = 0;
                Magma2j1.BorderBrush = new SolidColorBrush(Colors.Transparent);
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

                        Magma3.Visibility = Visibility.Hidden;
                        Magma3j1.Visibility = Visibility.Visible;
                        Manaj1.Value = Heroes[0].Mana;
                        string va = Convert.ToString(Heroes[0].Mana);
                        cantmana.Text = va;
                    }
                }


            }
            else
            {
                if (Heroes[1].mano.Contains(magma3))
                {

                    if (jugs.jugarcartar(Heroes[1], magma3) == 1)
                    {

                        Magma3.Visibility = Visibility.Hidden;
                        Magma3j2.Visibility = Visibility.Visible;
                        Manaj2.Value = Heroes[1].Mana;
                        string v = Convert.ToString(Heroes[1].Mana);
                        cantmana.Text = v;
                    }
                }

            }
        }
        private void Magma3_Clickj1(object sender, RoutedEventArgs e)
        {
            if (magma3.Seleccionada == 0)
            {
                magma3.Seleccionada = 1;
                Magma3j1.BorderBrush = new SolidColorBrush(Colors.Gold);
                foreach (Minions i in Heroes[0].Tablero1)
                {
                    if (i.NombreCarta != "Magma3")
                    { i.Seleccionada = 0; }

                }
                info.Visibility = Visibility.Visible;
                info.Text = " Carta: " + magma3.NombreCarta + "\n" + "Vida: " + magma3.Vida + "\n";
            }
            else
            {
                magma3.Seleccionada = 0;
                Magma3j1.BorderBrush = new SolidColorBrush(Colors.Transparent);
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

                        Murloc1.Visibility = Visibility.Hidden;
                        Murloc1j1.Visibility = Visibility.Visible;
                        Manaj1.Value = Heroes[0].Mana;
                        string va = Convert.ToString(Heroes[0].Mana);
                        cantmana.Text = va;
                    }
                }



            }
            else
            {
                if (Heroes[1].mano.Contains(murloc1))
                {

                    if (jugs.jugarcartar(Heroes[1], murloc1) == 1)
                    {

                        Murloc1.Visibility = Visibility.Hidden;
                        Murloc1j2.Visibility = Visibility.Visible;
                        Manaj2.Value = Heroes[1].Mana;
                        string v = Convert.ToString(Heroes[1].Mana);
                        cantmana.Text = v;
                    }
                }

            }
        }
        private void Murloc1_Clickj1(object sender, RoutedEventArgs e)

        {

            if (murloc1.Seleccionada == 0)
            {
                murloc1.Seleccionada = 1;
                Murloc1j1.BorderBrush = new SolidColorBrush(Colors.Gold);
                foreach (Minions i in Heroes[0].Tablero1)
                {
                    if (i.NombreCarta != "Murloc1")
                    { i.Seleccionada = 0; }

                }
                info.Visibility = Visibility.Visible;
                info.Text = " Carta: " + murloc1.NombreCarta + "\n" + "Vida: " + murloc1.Vida + "\n";
            }
            else
            {
                murloc1.Seleccionada = 0;
                Murloc1j1.BorderBrush = new SolidColorBrush(Colors.Transparent);
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

                        Murloc2.Visibility = Visibility.Hidden;
                        Murloc2j1.Visibility = Visibility.Visible;
                        Manaj1.Value = Heroes[0].Mana;
                        string va = Convert.ToString(Heroes[0].Mana);
                        cantmana.Text = va;
                    }
                }



            }
            else
            {
                if (Heroes[1].mano.Contains(murloc2))
                {

                    if (jugs.jugarcartar(Heroes[1], murloc2) == 1)
                    {

                        Murloc2.Visibility = Visibility.Hidden;
                        Murloc2j2.Visibility = Visibility.Visible;
                        Manaj2.Value = Heroes[1].Mana;
                        string v = Convert.ToString(Heroes[1].Mana);
                        cantmana.Text = v;
                    }
                }

            }
        }
        private void Murloc2_Clickj1(object sender, RoutedEventArgs e)
        {

            if (murloc2.Seleccionada == 0)
            {
                murloc2.Seleccionada = 1;
                Murloc2j1.BorderBrush = new SolidColorBrush(Colors.Gold);
                foreach (Minions i in Heroes[0].Tablero1)
                {
                    if (i.NombreCarta != "Murloc2")
                    { i.Seleccionada = 0; }

                }
                info.Visibility = Visibility.Visible;
                info.Text = " Carta: " + murloc2.NombreCarta + "\n" + "Vida: " + murloc2.Vida + "\n";
            }
            else
            {
                murloc2.Seleccionada = 0;
                Murloc2j1.BorderBrush = new SolidColorBrush(Colors.Transparent);
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

                        Murloc3.Visibility = Visibility.Hidden;
                        Murloc3j1.Visibility = Visibility.Visible;
                        Manaj1.Value = Heroes[0].Mana;
                        string va = Convert.ToString(Heroes[0].Mana);
                        cantmana.Text = va;
                    }
                }



            }
            else
            {
                if (Heroes[1].mano.Contains(murloc3))
                {

                    if (jugs.jugarcartar(Heroes[1], murloc3) == 1)
                    {

                        Murloc3.Visibility = Visibility.Hidden;
                        Murloc3j2.Visibility = Visibility.Visible;
                        Manaj2.Value = Heroes[1].Mana;
                        string v = Convert.ToString(Heroes[1].Mana);
                        cantmana.Text = v;
                    }
                }

            }
        }
        private void Murloc3_Clickj1(object sender, RoutedEventArgs e)
        {

            if (murloc3.Seleccionada == 0)
            {
                murloc3.Seleccionada = 1;
                Murloc3j1.BorderBrush = new SolidColorBrush(Colors.Gold);
                foreach (Minions i in Heroes[0].Tablero1)
                {
                    if (i.NombreCarta != "Murloc3")
                    { i.Seleccionada = 0; }

                }
                info.Visibility = Visibility.Visible;
                info.Text = " Carta: " + murloc3.NombreCarta + "\n" + "Vida: " + murloc3.Vida + "\n";
            }
            else
            {
                murloc3.Seleccionada = 0;
                Murloc3j1.BorderBrush = new SolidColorBrush(Colors.Transparent);
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

                        Oasis1.Visibility = Visibility.Hidden;
                        Oasis1j1.Visibility = Visibility.Visible;
                        Manaj1.Value = Heroes[0].Mana;
                        string va = Convert.ToString(Heroes[0].Mana);
                        cantmana.Text = va;
                    }
                }


            }
            else
            {
                if (Heroes[1].mano.Contains(oasis1))
                {

                    if (jugs.jugarcartar(Heroes[1], oasis1) == 1)
                    {

                        Oasis1.Visibility = Visibility.Hidden;
                        Oasis1j2.Visibility = Visibility.Visible;
                        Manaj2.Value = Heroes[1].Mana;
                        string v = Convert.ToString(Heroes[1].Mana);
                        cantmana.Text = v;
                    }
                }

            }


        }
        private void Oasis1_Clickj1(object sender, RoutedEventArgs e)
        {

            if (oasis1.Seleccionada == 0)
            {
                oasis1.Seleccionada = 1;
                Oasis1j1.BorderBrush = new SolidColorBrush(Colors.Gold);
                foreach (Minions i in Heroes[0].Tablero1)
                {
                    if (i.NombreCarta != "Oasis1")
                    { i.Seleccionada = 0; }

                }
                info.Visibility = Visibility.Visible;
                info.Text = " Carta: " + oasis1.NombreCarta + "\n" + "Vida: " + oasis1.Vida + "\n";
            }
            else
            {
                oasis1.Seleccionada = 0;
                Oasis1j1.BorderBrush = new SolidColorBrush(Colors.Transparent);
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

                        Oasis2.Visibility = Visibility.Hidden;
                        Oasis2j1.Visibility = Visibility.Visible;
                        Manaj1.Value = Heroes[0].Mana;
                        string va = Convert.ToString(Heroes[0].Mana);
                        cantmana.Text = va;
                    }
                }



            }
            else
            {
                if (Heroes[1].mano.Contains(oasis2))
                {

                    if (jugs.jugarcartar(Heroes[1], oasis2) == 1)
                    {

                        Oasis2.Visibility = Visibility.Hidden;
                        Oasis2j2.Visibility = Visibility.Visible;
                        Manaj2.Value = Heroes[1].Mana;
                        string v = Convert.ToString(Heroes[1].Mana);
                        cantmana.Text = v;
                    }
                }

            }
        }
        private void Oasis2_Clickj1(object sender, RoutedEventArgs e)
        {

            if (oasis2.Seleccionada == 0)
            {
                oasis2.Seleccionada = 1;
                Oasis2j1.BorderBrush = new SolidColorBrush(Colors.Gold);
                foreach (Minions i in Heroes[0].Tablero1)
                {
                    if (i.NombreCarta != "Oasis2")
                    { i.Seleccionada = 0; }

                }
                info.Visibility = Visibility.Visible;
                info.Text = " Carta: " + oasis2.NombreCarta + "\n" + "Vida: " + oasis2.Vida + "\n";
            }
            else
            {
                oasis2.Seleccionada = 0;
                Oasis2j1.BorderBrush = new SolidColorBrush(Colors.Transparent);
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

                        Oasis3.Visibility = Visibility.Hidden;
                        Oasis3j1.Visibility = Visibility.Visible;
                        Manaj1.Value = Heroes[0].Mana;
                        string va = Convert.ToString(Heroes[0].Mana);
                        cantmana.Text = va;
                    }
                }



            }
            else
            {
                if (Heroes[1].mano.Contains(oasis3))
                {

                    if (jugs.jugarcartar(Heroes[1], oasis3) == 1)
                    {

                        Oasis3.Visibility = Visibility.Hidden;
                        Oasis3j2.Visibility = Visibility.Visible;
                        Manaj2.Value = Heroes[1].Mana;
                        string v = Convert.ToString(Heroes[1].Mana);
                        cantmana.Text = v;
                    }
                }

            }
        }
        private void Oasis3_Clickj1(object sender, RoutedEventArgs e)
        {

            if (oasis3.Seleccionada == 0)
            {
                oasis3.Seleccionada = 1;
                Oasis3j1.BorderBrush = new SolidColorBrush(Colors.Gold);
                foreach (Minions i in Heroes[0].Tablero1)
                {
                    if (i.NombreCarta != "Oasis3")
                    { i.Seleccionada = 0; }

                }

                info.Visibility = Visibility.Visible;
                info.Text = " Carta: " + oasis3.NombreCarta + "\n" + "Vida: " + oasis3.Vida + "\n";
            }
            else
            {
                oasis3.Seleccionada = 0;
                Oasis3j1.BorderBrush = new SolidColorBrush(Colors.Transparent);
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

                        River1.Visibility = Visibility.Hidden;
                        River1j1.Visibility = Visibility.Visible;
                        Manaj1.Value = Heroes[0].Mana;
                        string va = Convert.ToString(Heroes[0].Mana);
                        cantmana.Text = va;
                    }
                }


            }
            else
            {
                if (Heroes[1].mano.Contains(river1))
                {

                    if (jugs.jugarcartar(Heroes[1], river1) == 1)
                    {

                        River1.Visibility = Visibility.Hidden;
                        River1j2.Visibility = Visibility.Visible;
                        Manaj2.Value = Heroes[1].Mana;
                        string v = Convert.ToString(Heroes[1].Mana);
                        cantmana.Text = v;
                    }
                }

            }
        }
        private void River1_Clickj1(object sender, RoutedEventArgs e)
        {

            if (river1.Seleccionada == 0)
            {
                river1.Seleccionada = 1;
                River1j1.BorderBrush = new SolidColorBrush(Colors.Gold);
                foreach (Minions i in Heroes[0].Tablero1)
                {
                    if (i.NombreCarta != "River1")
                    { i.Seleccionada = 0; }

                }
                info.Visibility = Visibility.Visible;
                info.Text = " Carta: " + river1.NombreCarta + "\n" + "Vida: " + river1.Vida + "\n";
            }
            else
            {
                river1.Seleccionada = 0;
                River1j1.BorderBrush = new SolidColorBrush(Colors.Transparent);
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
                        River2.Visibility = Visibility.Hidden;
                        River2j1.Visibility = Visibility.Visible;
                        Manaj1.Value = Heroes[0].Mana;
                        string va = Convert.ToString(Heroes[0].Mana);
                        cantmana.Text = va;
                    }
                }


            }
            else
            {
                if (Heroes[1].mano.Contains(river2))
                {

                    if (jugs.jugarcartar(Heroes[1], river2) == 1)
                    {

                        River2.Visibility = Visibility.Hidden;
                        River2j2.Visibility = Visibility.Visible;
                        Manaj2.Value = Heroes[1].Mana;
                        string v = Convert.ToString(Heroes[1].Mana);
                        cantmana.Text = v;
                    }
                }

            }
        }
        private void River2_Clickj1(object sender, RoutedEventArgs e)
        {

            if (river2.Seleccionada == 0)
            {
                river2.Seleccionada = 1;
                River2j1.BorderBrush = new SolidColorBrush(Colors.Gold);
                foreach (Minions i in Heroes[0].Tablero1)
                {
                    if (i.NombreCarta != "River2")
                    { i.Seleccionada = 0; }

                }
                info.Visibility = Visibility.Visible;
                info.Text = " Carta: " + river2.NombreCarta + "\n" + "Vida: " + river2.Vida + "\n";
            }
            else
            {
                river2.Seleccionada = 0;
                River2j1.BorderBrush = new SolidColorBrush(Colors.Transparent);
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

                        River3.Visibility = Visibility.Hidden;
                        River3j1.Visibility = Visibility.Visible;
                        Manaj1.Value = Heroes[0].Mana;
                        string va = Convert.ToString(Heroes[0].Mana);
                        cantmana.Text = va;
                    }
                }



            }
            else
            {
                if (Heroes[1].mano.Contains(river3))
                {

                    if (jugs.jugarcartar(Heroes[1], river3) == 1)
                    {
                        River3.Visibility = Visibility.Hidden;
                        River3j2.Visibility = Visibility.Visible;
                        Manaj2.Value = Heroes[1].Mana;
                        string v = Convert.ToString(Heroes[1].Mana);
                        cantmana.Text = v;
                    }
                }

            }
        }
        private void River3_Clickj1(object sender, RoutedEventArgs e)
        {
            if (river3.Seleccionada == 0)
            {
                river3.Seleccionada = 1;
                River3j1.BorderBrush = new SolidColorBrush(Colors.Gold);
                foreach (Minions i in Heroes[0].Tablero1)
                {
                    if (i.NombreCarta != "River3")
                    { i.Seleccionada = 0; }

                }
                info.Visibility = Visibility.Visible;
                info.Text = " Carta: " + river3.NombreCarta + "\n" + "Vida: " + river3.Vida + "\n";
            }
            else { river3.Seleccionada = 0;
                River3j1.BorderBrush = new SolidColorBrush(Colors.Transparent);
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

                        War1.Visibility = Visibility.Hidden;
                        War1j1.Visibility = Visibility.Visible;
                        Manaj1.Value = Heroes[0].Mana;
                        string va = Convert.ToString(Heroes[0].Mana);
                        cantmana.Text = va;
                    }
                }


            }
            else
            {
                if (Heroes[1].mano.Contains(war1))
                {

                    if (jugs.jugarcartar(Heroes[1], war1) == 1)
                    {

                        War1.Visibility = Visibility.Hidden;
                        War1j2.Visibility = Visibility.Visible;
                        Manaj2.Value = Heroes[1].Mana;
                        string v = Convert.ToString(Heroes[1].Mana);
                        cantmana.Text = v;
                    }
                }

            }
        }
        private void War1_Clickj1(object sender, RoutedEventArgs e)
        {

            if (war1.Seleccionada == 0)
            {
                war1.Seleccionada = 1;
                War1j1.BorderBrush = new SolidColorBrush(Colors.Gold);
                foreach (Minions i in Heroes[0].Tablero1)
                {
                    if (i.NombreCarta != "War1")
                    { i.Seleccionada = 0; }

                }
                info.Visibility = Visibility.Visible;
                info.Text = " Carta: " + war1.NombreCarta + "\n" + "Vida: " + war1.Vida + "\n";
            }
            else
            {
                war1.Seleccionada = 0;
                War1j1.BorderBrush = new SolidColorBrush(Colors.Transparent);
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

                        War2.Visibility = Visibility.Hidden;
                        War2j1.Visibility = Visibility.Visible;
                        Manaj1.Value = Heroes[0].Mana;
                        string va = Convert.ToString(Heroes[0].Mana);
                        cantmana.Text = va;
                    }
                }

            }
            else
            {
                if (Heroes[1].mano.Contains(war2))
                {

                    if (jugs.jugarcartar(Heroes[1], war2) == 1)
                    {

                        War2.Visibility = Visibility.Hidden;
                        War2j2.Visibility = Visibility.Visible;
                        Manaj2.Value = Heroes[1].Mana;
                        string v = Convert.ToString(Heroes[1].Mana);
                        cantmana.Text = v;
                    }
                }


            }
        }
        private void War2_Clickj1(object sender, RoutedEventArgs e)
        {

            if (war2.Seleccionada == 0)
            {
                war2.Seleccionada = 1;
                War2j1.BorderBrush = new SolidColorBrush(Colors.Gold);
                foreach (Minions i in Heroes[0].Tablero1)
                {
                    if (i.NombreCarta != "War2")
                    { i.Seleccionada = 0; }

                }
                info.Visibility = Visibility.Visible;
                info.Text = " Carta: " + war2.NombreCarta + "\n" + "Vida: " + war2.Vida + "\n";
            }
            else
            {
                war2.Seleccionada = 0;
                War2j1.BorderBrush = new SolidColorBrush(Colors.Transparent);
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

                        War3.Visibility = Visibility.Hidden;
                        War3j1.Visibility = Visibility.Visible;
                        Manaj1.Value = Heroes[0].Mana;
                        string va = Convert.ToString(Heroes[0].Mana);
                        cantmana.Text = va;
                    }
                }


            }
            else
            {
                if (Heroes[1].mano.Contains(war3))
                {

                    if (jugs.jugarcartar(Heroes[1], war3) == 1)
                    {

                        War3.Visibility = Visibility.Hidden;
                        War3j2.Visibility = Visibility.Visible;
                        Manaj2.Value = Heroes[1].Mana;
                        string v = Convert.ToString(Heroes[1].Mana);
                        cantmana.Text = v;

                    }
                }

            }
        }
        private void War3_Clickj1(object sender, RoutedEventArgs e)
        {

            if (war3.Seleccionada == 0)
            {
                war3.Seleccionada = 1;
                War3j1.BorderBrush = new SolidColorBrush(Colors.Gold);
                foreach (Minions i in Heroes[0].Tablero1)
                {
                    if (i.NombreCarta != "War3")
                    { i.Seleccionada = 0; }

                }
                info.Visibility = Visibility.Visible;
                info.Text = " Carta: " + war3.NombreCarta + "\n" + "Vida: " + war3.Vida + "\n";
            }
            else
            {
                war3.Seleccionada = 0;
                War3j1.BorderBrush = new SolidColorBrush(Colors.Transparent);
            }



        }

        private void Palaj1_Click(object sender, RoutedEventArgs e)
        {
            if (Pala.Seleccionada == 0)
            {
                Pala.Seleccionada = 1;
                Palaj1.BorderBrush = new SolidColorBrush(Colors.Gold);
                foreach (Minions i in Heroes[0].Tablero1)
                {
                    if (i.NombreCarta != "Paladin")
                    { i.Seleccionada = 0; }

                }
                info.Visibility = Visibility.Visible;
                info.Text = " Carta: " + Pala.NombreCarta + "\n" + "Vida: " + Pala.Vida + "\n";
            }
            else
            {
                Pala.Seleccionada = 0;
                Palaj1.BorderBrush = new SolidColorBrush(Colors.Transparent);
            }


        }

        private void Palaj2_Click(object sender, RoutedEventArgs e)
        {
            if (Pala.Seleccionada == 0)
            {
                Pala.Seleccionada = 1;
                Palaj2.BorderBrush = new SolidColorBrush(Colors.Gold);
                foreach (Minions i in Heroes[1].Tablero1)
                {
                    if (i.NombreCarta != "Paladin")
                    { i.Seleccionada = 0; }

                }
                info.Visibility = Visibility.Visible;
                info.Text = " Carta: " + Pala.NombreCarta + "\n" + "Vida: " + Pala.Vida + "\n";
            }
            else
            {
                Pala.Seleccionada = 0;
                Palaj2.BorderBrush = new SolidColorBrush(Colors.Transparent);
            }


        }

        private void Totem1j1_Click(object sender, RoutedEventArgs e)
        {
            if (Totem11.Seleccionada == 0)
            {
                Totem11.Seleccionada = 1;
                Totem1.BorderBrush = new SolidColorBrush(Colors.Gold);
                foreach (Minions i in Heroes[0].Tablero1)
                {
                    if (i.NombreCarta != "Totem1")
                    { i.Seleccionada = 0; }

                }
                info.Visibility = Visibility.Visible;
                info.Text = " Carta: " + Totem11.NombreCarta + "\n" + "Vida: " + Totem11.Vida + "\n";
            }
            else
            {
                Totem11.Seleccionada = 0;
                Totem1.BorderBrush = new SolidColorBrush(Colors.Transparent);
            }
        }

        private void Totem1j2_Click(object sender, RoutedEventArgs e)
        {
            if (Totem11.Seleccionada == 0)
            {
                Totem11.Seleccionada = 1;
                Totem1j2.BorderBrush = new SolidColorBrush(Colors.Gold);
                foreach (Minions i in Heroes[1].Tablero1)
                {
                    if (i.NombreCarta != "Totem1")
                    { i.Seleccionada = 0; }

                }
                info.Visibility = Visibility.Visible;
                info.Text = " Carta: " + Totem11.NombreCarta + "\n" + "Vida: " + Totem11.Vida + "\n";
            }
            else
            {
                Totem11.Seleccionada = 0;
                Totem1j2.BorderBrush = new SolidColorBrush(Colors.Transparent);
            }
        }

        private void Totem2j1_Click(object sender, RoutedEventArgs e)
        {
            if (Totem20.Seleccionada == 0)
            {
                Totem20.Seleccionada = 1;
                Totem2.BorderBrush = new SolidColorBrush(Colors.Gold);
                foreach (Minions i in Heroes[0].Tablero1)
                {
                    if (i.NombreCarta != "Totem2")
                    { i.Seleccionada = 0; }

                }
                info.Visibility = Visibility.Visible;
                info.Text = " Carta: " + Totem20.NombreCarta + "\n" + "Vida: " + Totem20.Vida + "\n";
            }
            else
            {
                Totem20.Seleccionada = 0;
                Totem2.BorderBrush = new SolidColorBrush(Colors.Transparent);
            }
        }

        private void Totem2j2_Click(object sender, RoutedEventArgs e)
        {
            if (Totem20.Seleccionada == 0)
            {
                Totem20.Seleccionada = 1;
                Totem2j2.BorderBrush = new SolidColorBrush(Colors.Gold);
                foreach (Minions i in Heroes[1].Tablero1)
                {
                    if (i.NombreCarta != "Totem2")
                    { i.Seleccionada = 0; }

                }
                info.Visibility = Visibility.Visible;
                info.Text = " Carta: " + Totem20.NombreCarta + "\n" + "Vida: " + Totem20.Vida + "\n";
            }
            else
            {
                Totem20.Seleccionada = 0;
                Totem2j2.BorderBrush = new SolidColorBrush(Colors.Transparent);
            }
        }

        private void Totem3j1_Click(object sender, RoutedEventArgs e)
        {
            if (Totem30.Seleccionada == 0)
            {
                Totem30.Seleccionada = 1;
                Totem3.BorderBrush = new SolidColorBrush(Colors.Gold);
                foreach (Minions i in Heroes[0].Tablero1)
                {
                    if (i.NombreCarta != "Totem3")
                    { i.Seleccionada = 0; }

                }
                info.Visibility = Visibility.Visible;
                info.Text = " Carta: " + Totem30.NombreCarta + "\n" + "Vida: " + Totem30.Vida + "\n";
            }
            else
            {
                Totem30.Seleccionada = 0;
                Totem3.BorderBrush = new SolidColorBrush(Colors.Transparent);
            }
        }

        private void Totem3j2_Click(object sender, RoutedEventArgs e)
        {
            if (Totem30.Seleccionada == 0)
            {
                Totem30.Seleccionada = 1;
                Totem3j2.BorderBrush = new SolidColorBrush(Colors.Gold);
                foreach (Minions i in Heroes[1].Tablero1)
                {
                    if (i.NombreCarta != "Totem3")
                    { i.Seleccionada = 0; }

                }
                info.Visibility = Visibility.Visible;
                info.Text = " Carta: " + Totem30.NombreCarta + "\n" + "Vida: " + Totem30.Vida + "\n";
            }
            else
            {
                Totem30.Seleccionada = 0;
                Totem3j2.BorderBrush = new SolidColorBrush(Colors.Transparent);
            }
        }

        private void Totem4j1_Click(object sender, RoutedEventArgs e)
        {
            if (Totem40.Seleccionada == 0)
            {
                Totem40.Seleccionada = 1;
                Totem4.BorderBrush = new SolidColorBrush(Colors.Gold);
                foreach (Minions i in Heroes[0].Tablero1)
                {
                    if (i.NombreCarta != "Totem4")
                    { i.Seleccionada = 0; }

                }
                info.Visibility = Visibility.Visible;
                info.Text = " Carta: " + Totem40.NombreCarta + "\n" + "Vida: " + Totem40.Vida + "\n";
            }
            else
            {
                Totem40.Seleccionada = 0;
                Totem4.BorderBrush = new SolidColorBrush(Colors.Transparent);
            }
        }

        private void Totem4j2_Click(object sender, RoutedEventArgs e)
        {
            if (Totem40.Seleccionada == 0)
            {
                Totem40.Seleccionada = 1;
                Totem4j2.BorderBrush = new SolidColorBrush(Colors.Gold);
                foreach (Minions i in Heroes[1].Tablero1)
                {
                    if (i.NombreCarta != "Totem4")
                    { i.Seleccionada = 0; }

                }
                info.Visibility = Visibility.Visible;
                info.Text = " Carta: " + Totem40.NombreCarta + "\n" + "Vida: " + Totem40.Vida + "\n";
            }
            else
            {
                Totem40.Seleccionada = 0;
                Totem4j2.BorderBrush = new SolidColorBrush(Colors.Transparent);
            }
        }

        private void Atacar_Click(object sender, RoutedEventArgs e)
        {
            int con = 0;
            info.Visibility = Visibility.Hidden;
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
                                //MessageBox.Show(Convert.ToString(Heroes[0].Tablero1.Count()));
                                //MessageBox.Show(Convert.ToString(Heroes[1].Tablero1.Count()));
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


            if (Heroes[0].Tablero1.Count() != 0) { foreach (Minions x in Heroes[0].Tablero1) { if (x.Vida <= 0) { Heroes[0].Tablero1.Remove(x); } } }
            if (Heroes[1].Tablero1.Count() != 0)
            { foreach (Minions x in Heroes[1].Tablero1) { if (x.Vida <= 0) { Heroes[1].Tablero1.Remove(x); } } }
            //MessageBox.Show(Convert.ToString(Heroes[0].Tablero1.Count()));
            //MessageBox.Show(Convert.ToString(Heroes[1].Tablero1.Count()));

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

        

        public void MostrarCartas(List<Minions> Lista)
        {
            if (Lista.Count() != 0)
            {
                foreach (Minions i in Lista)
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
            else
            {
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



        }

        public void MostrarCartas1(List<Minions> Lista) {
            if ((Lista.Count() != 0))
            {
                foreach (Minions i in Lista)
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
            else
            {
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
        public void MostrarCartasM1(List<Minions> Lista)
        {
            foreach (Minions i in Lista)
            {
                if (i.NombreCarta == "Wisp1")
                {
                    Wisp1.Visibility = Visibility.Visible;

                }
                if (i.NombreCarta == "Wisp2")
                {
                    Wisp2.Visibility = Visibility.Visible;
                }
                if (i.NombreCarta == "Wisp3")
                {
                    Wisp3.Visibility = Visibility.Visible;
                }
                if (i.NombreCarta == "Murloc1")
                {
                    Murloc1.Visibility = Visibility.Visible;
                }
                if (i.NombreCarta == "Murloc2")
                {
                    Murloc2.Visibility = Visibility.Visible;
                }
                if (i.NombreCarta == "Murloc3")
                {
                    Murloc3.Visibility = Visibility.Visible;
                }
                if (i.NombreCarta == "Oasis1")
                {
                    Oasis1.Visibility = Visibility.Visible;
                }
                if (i.NombreCarta == "Oasis2")
                {
                    Oasis2.Visibility = Visibility.Visible;
                }
                if (i.NombreCarta == "Oasis3")
                {
                    Oasis3.Visibility = Visibility.Visible;
                }
                if (i.NombreCarta == "Corehound1")
                {
                    Corehound1.Visibility = Visibility.Visible;
                }
                if (i.NombreCarta == "Corehound2")
                {
                    Corehound2.Visibility = Visibility.Visible;
                }
                if (i.NombreCarta == "Corehound3")
                {
                    Corehound3.Visibility = Visibility.Visible;
                }
                if (i.NombreCarta == "River1")
                {
                    River1.Visibility = Visibility.Visible;
                }
                if (i.NombreCarta == "River2")
                {
                    River2.Visibility = Visibility.Visible;
                }
                if (i.NombreCarta == "River3")
                {
                    River3.Visibility = Visibility.Visible;
                }

                if (i.NombreCarta == "Bloodfen1")
                {
                    Bloodfen1.Visibility = Visibility.Visible;
                }
                if (i.NombreCarta == "Bloodfen2")
                {
                    Bloodfen2.Visibility = Visibility.Visible;
                }
                if (i.NombreCarta == "Bloodfen3")
                {
                    Bloodfen3.Visibility = Visibility.Visible;
                }
                if (i.NombreCarta == "Magma1")
                {
                    Magma1.Visibility = Visibility.Visible;
                }
                if (i.NombreCarta == "Magma2")
                {
                    Magma2.Visibility = Visibility.Visible;
                }
                if (i.NombreCarta == "Magma3")
                {
                    Magma3.Visibility = Visibility.Visible;
                }
                if (i.NombreCarta == "Chillwind1")
                {
                    Chillwind1.Visibility = Visibility.Visible;

                }
                if (i.NombreCarta == "Chillwind2")
                {
                    Chillwind2.Visibility = Visibility.Visible;

                }
                if (i.NombreCarta == "Chillwind3")
                {
                    Chillwind3.Visibility = Visibility.Visible;

                }
                if (i.NombreCarta == "War1")
                {
                    War1.Visibility = Visibility.Visible;

                }
                if (i.NombreCarta == "War2")
                {
                    War2.Visibility = Visibility.Visible;

                }
                if (i.NombreCarta == "War3")
                {
                    War3.Visibility = Visibility.Visible;

                }
                if (i.NombreCarta == "Boulderfist1")
                {
                    Boulderfist1.Visibility = Visibility.Visible;
                }
                if (i.NombreCarta == "Boulderfist2")
                {
                    Boulderfist2.Visibility = Visibility.Visible;
                }
                if (i.NombreCarta == "Boulderfist3")
                {
                    Boulderfist3.Visibility = Visibility.Visible;
                }
            }
        }

        private void HabilidadHeroe_Click(object sender, RoutedEventArgs e)
        {
            if (jugando == 0)
            {
                if (Heroes[0].Nombre == "Paladin")
                {
                   Heroes[0].Habilidad(Heroes[1]);
                   Manaj1.Value = Heroes[0].Mana;
                   cantmana.Text = Convert.ToString(Heroes[0].Mana);
                   Palaj1.Visibility = Visibility.Visible;
                }
                
                else if (Heroes[0].Nombre == "Druida") { Heroes[0].Habilidad(Heroes[1]); Manaj1.Value = Heroes[0].Mana; cantmana.Text = Convert.ToString(Heroes[0].Mana); }
                else if (Heroes[0].Nombre == "Hunter") { Heroes[0].Habilidad(Heroes[1]); Manaj1.Value = Heroes[0].Mana; cantmana.Text = Convert.ToString(Heroes[0].Mana); }
                else if (Heroes[0].Nombre == "Sacerdote") { Heroes[0].Habilidad(Heroes[1]); Manaj1.Value = Heroes[0].Mana; cantmana.Text = Convert.ToString(Heroes[0].Mana); }
                else if (Heroes[0].Nombre == "Picaro") { Heroes[0].Habilidad(Heroes[1]); Manaj1.Value = Heroes[0].Mana; cantmana.Text = Convert.ToString(Heroes[0].Mana); }
                else if (Heroes[0].Nombre == "Brujo") { Heroes[0].HabilidadDruid(Heroes[1], MJugador1.mazo1); Manaj1.Value = Heroes[0].Mana; cantmana.Text = Convert.ToString(Heroes[0].Mana); MostrarCartas(Heroes[0].Tablero1); vidaheroejug.Text = "Heroe: " + Heroes[0].Nombre + "\n" + "Vida: " + Convert.ToString(Heroes[0].Vida); MostrarCartasM1(Heroes[0].mano); }
                else if (Heroes[0].Nombre == "Mago") { Heroes[0].Habilidad(Heroes[1]); Manaj1.Value = Heroes[0].Mana; cantmana.Text = Convert.ToString(Heroes[0].Mana); ; MostrarCartas(Heroes[0].Tablero1); }
                else if (Heroes[0].Nombre == "Chaman") { Heroes[0].Habilidad(Heroes[1]); Manaj1.Value = Heroes[0].Mana; cantmana.Text = Convert.ToString(Heroes[0].Mana);
                    foreach (Minions i in Heroes[0].Tablero1)
                    {
                        if (i.NombreCarta == "Totem1")
                        {
                            Totem1.Visibility = Visibility.Visible;
                        }
                        if (i.NombreCarta == "Totem2")
                        {
                            Totem2.Visibility = Visibility.Visible;
                        }
                        if (i.NombreCarta == "Totem3")
                        {
                            Totem3.Visibility = Visibility.Visible;
                        }
                        if (i.NombreCarta == "Totem4")
                        {
                            Totem4.Visibility = Visibility.Visible;
                        }
                    }

                }
                else { Heroes[0].Habilidad(Heroes[1]); }


            }
            else
            {
                if (Heroes[1].Nombre == "Paladin")
                {
                    Heroes[1].Habilidad(Heroes[0]);
                    Manaj1.Value = Heroes[1].Mana;
                    cantmana.Text = Convert.ToString(Heroes[1].Mana);
                    Palaj2.Visibility = Visibility.Visible;

                }
                else if (Heroes[1].Nombre == "Druida") { Heroes[1].Habilidad(Heroes[0]); Manaj1.Value = Heroes[1].Mana; cantmana.Text = Convert.ToString(Heroes[1].Mana); }
                else if (Heroes[1].Nombre == "Hunter") { Heroes[1].Habilidad(Heroes[0]); Manaj1.Value = Heroes[1].Mana; cantmana.Text = Convert.ToString(Heroes[1].Mana); }
                else if (Heroes[1].Nombre == "Sacerdote") { Heroes[1].Habilidad(Heroes[0]); Manaj1.Value = Heroes[1].Mana; cantmana.Text = Convert.ToString(Heroes[1].Mana); }
                else if (Heroes[1].Nombre == "Picaro") { Heroes[1].Habilidad(Heroes[0]); Manaj1.Value = Heroes[1].Mana; cantmana.Text = Convert.ToString(Heroes[1].Mana); }
                else if (Heroes[1].Nombre == "Brujo") { Heroes[1].HabilidadDruid(Heroes[0], MJugador2.mazo1); Manaj1.Value = Heroes[1].Mana; cantmana.Text = Convert.ToString(Heroes[1].Mana); MostrarCartas1(Heroes[1].Tablero1); vidaheroejug.Text = "Heroe: " + Heroes[1].Nombre + "\n" + "Vida: " + Convert.ToString(Heroes[1].Vida); MostrarCartasM1(Heroes[0].mano); }
                else if (Heroes[1].Nombre == "Mago") { Heroes[1].Habilidad(Heroes[0]); Manaj1.Value = Heroes[1].Mana; cantmana.Text = Convert.ToString(Heroes[1].Mana); ; MostrarCartas1(Heroes[1].Tablero1); }
                else if (Heroes[1].Nombre == "Chaman") { Heroes[1].Habilidad(Heroes[0]); Manaj1.Value = Heroes[1].Mana; cantmana.Text = Convert.ToString(Heroes[1].Mana);
                    foreach (Minions i in Heroes[1].Tablero1)
                    {
                        if (i.NombreCarta == "Totem11")
                        {
                            Totem1j2.Visibility = Visibility.Visible;
                        }
                        
                        if (i.NombreCarta == "Totem20")
                        {
                            Totem2j2.Visibility = Visibility.Visible;
                        }
                        if (i.NombreCarta == "Totem30")
                        {
                            Totem3j2.Visibility = Visibility.Visible;
                        }
                        if (i.NombreCarta == "Totem40")
                        {
                            Totem4j2.Visibility = Visibility.Visible;
                        }
                    }

                }
                else { Heroes[1].Habilidad(Heroes[0]); }

            }


        }

        private void Guardar_Click(object sender, RoutedEventArgs e)
        {
            Stream He1G = new FileStream("Heroe1.txt", FileMode.Create, FileAccess.Write, FileShare.None);
            Stream He2G = new FileStream("Heroe2.txt", FileMode.Create, FileAccess.Write, FileShare.None);
            Stream Ma1G = new FileStream("Mazo1.txt", FileMode.Create, FileAccess.Write, FileShare.None);
            Stream Ma2G = new FileStream("Mazo2.txt", FileMode.Create, FileAccess.Write, FileShare.None);

            bf.Serialize(He1G,Heroes[0]);
            bf.Serialize(He2G, Heroes[1]);
            bf.Serialize(Ma1G, MJugador1);
            bf.Serialize(Ma2G, MJugador2);

            Ma1G.Close();
            Ma2G.Close();
            He1G.Close();
            He2G.Close();
        }      

        private void Cargar_Click(object sender, RoutedEventArgs e)
        {
         
            Stream He1C = new FileStream("Heroe1.txt", FileMode.Open, FileAccess.Read, FileShare.None);
            Stream He2C = new FileStream("Heroe2.txt", FileMode.Open, FileAccess.Read, FileShare.None);
            Stream Ma1C = new FileStream("Mazo1.txt", FileMode.Open, FileAccess.Read, FileShare.None);
            Stream Ma2C = new FileStream("Mazo2.txt", FileMode.Open, FileAccess.Read, FileShare.None);
            Heroe H1 = (Heroe)bf.Deserialize(He1C);
            Heroes.Add(H1);
            Heroe H2 = (Heroe)bf.Deserialize(He2C);
            Heroes.Add(H2);
            MJugador1 = (Mazo)bf.Deserialize(Ma1C);
            MJugador2 = (Mazo)bf.Deserialize(Ma2C);
            Ma1C.Close();
            Ma2C.Close();
            He1C.Close();
            He2C.Close();

            jugando = 0;

            Tablero.Visibility = Visibility.Visible;
            FinTurno1.Visibility = Visibility.Visible;
            JugadorUno.Visibility = Visibility.Visible;

            Atacar.Visibility = Visibility.Visible;
            HabilidadHeroe.Visibility = Visibility.Visible;
            Rendirse.Visibility = Visibility.Visible;
            Mano.Visibility = Visibility.Visible;
            Tableroj1.Visibility = Visibility.Visible;
            BarraMano.Visibility = Visibility.Visible;
            BarraTableroj1.Visibility = Visibility.Visible;
            BarraTableroj2.Visibility = Visibility.Visible;
            Tableroj2.Visibility = Visibility.Visible;
            Cargar.Visibility = Visibility.Hidden;
            Manaj1.Visibility = Visibility.Visible;
            cantmana.Visibility = Visibility.Visible;
            Manaj1.Value = Heroes[0].Mana;
            AtacarHeroe.Visibility = Visibility.Visible;
            string va = Convert.ToString(Heroes[0].Mana);
            cantmana.Text = va;

            HabilidadHeroe.Visibility = Visibility.Visible;
            vidaheroejug.Visibility = Visibility.Visible;
            string f = Convert.ToString(Heroes[0].Vida);
            vidaheroejug.Text = "Heroe: " + Heroes[0].Nombre + "\n" + "Vida: " + f;

            Vidaheroenojug.Visibility = Visibility.Visible;
            string d = Convert.ToString(Heroes[1].Vida);
            Vidaheroenojug.Text = "Heroe: " + Heroes[1].Nombre + "\n" + "Vida: " + d;


            if (Heroes[0].Nombre == "Paladin")
            {
                paladinjugador.Visibility = Visibility.Visible;

            }
            if (Heroes[1].Nombre == "Paladin")
            {
                otropaladin.Visibility = Visibility.Visible;
            }
            if (Heroes[0].Nombre == "Druida")
            {
                druidajugador.Visibility = Visibility.Visible;

            }
            if (Heroes[1].Nombre == "Druida")
            {
                otrodruida.Visibility = Visibility.Visible;
            }
            if (Heroes[0].Nombre == "Hunter")
            {
                cazadorjugador.Visibility = Visibility.Visible;

            }
            if (Heroes[1].Nombre == "Hunter")
            {
                otrocazador.Visibility = Visibility.Visible;
            }
            if (Heroes[0].Nombre == "Sacerdote")
            {
                sacerdotejugador.Visibility = Visibility.Visible;

            }
            if (Heroes[1].Nombre == "Sacerdote")
            {
                otrosacerdote.Visibility = Visibility.Visible;
            }
            if (Heroes[0].Nombre == "Picaro")
            {
                picarojugador.Visibility = Visibility.Visible;

            }
            if (Heroes[1].Nombre == "Picaro")
            {
                otropicaro.Visibility = Visibility.Visible;
            }
            if (Heroes[0].Nombre == "Brujo")
            {
                brujojugador.Visibility = Visibility.Visible;

            }
            if (Heroes[1].Nombre == "Brujo")
            {
                otrobrujo.Visibility = Visibility.Visible;
            }
            if (Heroes[0].Nombre == "Mago")
            {
                magojugador.Visibility = Visibility.Visible;

            }
            if (Heroes[1].Nombre == "Mago")
            {
                otromago.Visibility = Visibility.Visible;
            }
            if (Heroes[0].Nombre == "Chaman")
            {
                chamanjugador.Visibility = Visibility.Visible;

            }
            if (Heroes[1].Nombre == "Chaman")
            {
                otrochaman.Visibility = Visibility.Visible;
            }
            if (Heroes[0].Nombre == "Warrior")
            {
                guerrerojugador.Visibility = Visibility.Visible;

            }
            if (Heroes[1].Nombre == "Warrior")
            {
                otroguerrero.Visibility = Visibility.Visible;
            }

            if (Heroes[0].Tablero1.Count() != 0)
            {
                foreach (Minions i in Heroes[0].Tablero1)
                {
                    if (i.NombreCarta == "Wisp1")
                    {

                        Wisp1j1.Visibility = Visibility.Visible;
                    }

                    if (i.NombreCarta == "Wisp2")
                    {

                        Wisp2j1.Visibility = Visibility.Visible;

                    }

                    if (i.NombreCarta == "Wisp3")
                    {

                        Wisp3j1.Visibility = Visibility.Visible;

                    }

                    if (i.NombreCarta == "Murloc1")
                    {

                        Murloc1j1.Visibility = Visibility.Visible;

                    }

                    if (i.NombreCarta == "Murloc2")
                    {

                        Murloc2j1.Visibility = Visibility.Visible;


                    }

                    if (i.NombreCarta == "Murloc3")
                    {

                        Murloc3j1.Visibility = Visibility.Visible;

                    }

                    if (i.NombreCarta == "Oasis1")
                    {

                        Oasis1j1.Visibility = Visibility.Visible;
                    }

                    if (i.NombreCarta == "Oasis2")
                    {

                        Oasis2j1.Visibility = Visibility.Visible;
                    }

                    if (i.NombreCarta == "Oasis3")
                    {


                        Oasis3j1.Visibility = Visibility.Visible;
                    }

                    if (i.NombreCarta == "Corehound1")
                    {

                        Corehound1j1.Visibility = Visibility.Visible;
                    }

                    if (i.NombreCarta == "Corehound2")
                    {

                        Corehound2j1.Visibility = Visibility.Visible;
                    }

                    if (i.NombreCarta == "Corehound3")
                    {


                        Corehound3j1.Visibility = Visibility.Visible;
                    }

                    if (i.NombreCarta == "River1")
                    {
                        River1j1.Visibility = Visibility.Visible;
                    }

                    if (i.NombreCarta == "River2")
                    {

                        River2j1.Visibility = Visibility.Visible;
                    }

                    if (i.NombreCarta == "River3")
                    {

                        River3j1.Visibility = Visibility.Visible;
                    }


                    if (i.NombreCarta == "Bloodfen1")
                    {

                        Bloodfen1j1.Visibility = Visibility.Visible;

                    }

                    if (i.NombreCarta == "Bloodfen2")
                    {

                        Bloodfen2j1.Visibility = Visibility.Visible;

                    }

                    if (i.NombreCarta == "Bloodfen3")
                    {

                        Bloodfen3j1.Visibility = Visibility.Visible;

                    }

                    if (i.NombreCarta == "Magma1")
                    {

                        Magma1j1.Visibility = Visibility.Visible;
                    }

                    if (i.NombreCarta == "Magma2")
                    {

                        Magma2j1.Visibility = Visibility.Visible;
                    }

                    if (i.NombreCarta == "Magma3")
                    {

                        Magma3j1.Visibility = Visibility.Visible;
                    }

                    if (i.NombreCarta == "Chillwind1")
                    {

                        Chillwind1j1.Visibility = Visibility.Visible;

                    }

                    if (i.NombreCarta == "Chillwind2")
                    {


                        Chillwind2j1.Visibility = Visibility.Visible;

                    }

                    if (i.NombreCarta == "Chillwind3")
                    {


                        Chillwind3j1.Visibility = Visibility.Visible;

                    }

                    if (i.NombreCarta == "War1")
                    {

                        War1j1.Visibility = Visibility.Visible;

                    }

                    if (i.NombreCarta == "War2")
                    {
                        War2j1.Visibility = Visibility.Visible;

                    }

                    if (i.NombreCarta == "War3")
                    {

                        War3j1.Visibility = Visibility.Visible;


                    }

                    if (i.NombreCarta == "Boulderfist1")
                    {


                        Boulderfist1j1.Visibility = Visibility.Visible;
                    }

                    if (i.NombreCarta == "Boulderfist2")
                    {

                        Boulderfist2j1.Visibility = Visibility.Visible;
                    }

                    if (i.NombreCarta == "Boulderfist3")
                    {


                        Boulderfist3j1.Visibility = Visibility.Visible;
                    }

                }
            }


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

            }

            if ((Heroes[1].Tablero1.Count() != 0))
            {
                foreach (Minions i in Heroes[1].Tablero1)
                {
                    if (i.NombreCarta == "Wisp1")
                    {

                        Wisp1j2.Visibility = Visibility.Visible;

                    }

                    if (i.NombreCarta == "Wisp2")
                    {

                        Wisp2j2.Visibility = Visibility.Visible;

                    }

                    if (i.NombreCarta == "Wisp3")
                    {

                        Wisp3j2.Visibility = Visibility.Visible;

                    }

                    if (i.NombreCarta == "Murloc1")
                    {

                        Murloc1j2.Visibility = Visibility.Visible;

                    }

                    if (i.NombreCarta == "Murloc2")
                    {

                        Murloc2j2.Visibility = Visibility.Visible;
                    }

                    if (i.NombreCarta == "Murloc3")
                    {

                        Murloc3j2.Visibility = Visibility.Visible;

                    }

                    if (i.NombreCarta == "Oasis1")
                    {

                        Oasis1j2.Visibility = Visibility.Visible;
                    }

                    if (i.NombreCarta == "Oasis2")
                    {

                        Oasis2j2.Visibility = Visibility.Visible;
                    }

                    if (i.NombreCarta == "Oasis3")
                    {

                        Oasis3j2.Visibility = Visibility.Visible;
                    }

                    if (i.NombreCarta == "Corehound1")
                    {

                        Corehound1j2.Visibility = Visibility.Visible;
                    }

                    if (i.NombreCarta == "Corehound2")
                    {

                        Corehound2j2.Visibility = Visibility.Visible;
                    }

                    if (i.NombreCarta == "Corehound3")
                    {

                        Corehound3j2.Visibility = Visibility.Visible;
                    }

                    if (i.NombreCarta == "River1")
                    {

                        River1j2.Visibility = Visibility.Visible;
                    }

                    if (i.NombreCarta == "River2")
                    {


                        River2j2.Visibility = Visibility.Visible;
                    }

                    if (i.NombreCarta == "River3")
                    {

                        River3j2.Visibility = Visibility.Visible;
                    }

                    if (i.NombreCarta == "Bloodfen1")
                    {


                        Bloodfen1j2.Visibility = Visibility.Visible;

                    }

                    if (i.NombreCarta == "Bloodfen2")
                    {


                        Bloodfen2j2.Visibility = Visibility.Visible;

                    }

                    if (i.NombreCarta == "Bloodfen3")
                    {


                        Bloodfen3j2.Visibility = Visibility.Visible;

                    }

                    if (i.NombreCarta == "Magma1")
                    {


                        Magma1j2.Visibility = Visibility.Visible;
                    }

                    if (i.NombreCarta == "Magma2")
                    {


                        Magma2j2.Visibility = Visibility.Visible;
                    }

                    if (i.NombreCarta == "Magma3")
                    {


                        Magma3j2.Visibility = Visibility.Visible;
                    }

                    if (i.NombreCarta == "Chillwind1")
                    {


                        Chillwind1j2.Visibility = Visibility.Visible;

                    }

                    if (i.NombreCarta == "Chillwind2")
                    {


                        Chillwind2j2.Visibility = Visibility.Visible;

                    }

                    if (i.NombreCarta == "Chillwind3")
                    {


                        Chillwind3j2.Visibility = Visibility.Visible;

                    }

                    if (i.NombreCarta == "War1")
                    {


                        War1j2.Visibility = Visibility.Visible;

                    }

                    if (i.NombreCarta == "War2")
                    {

                        War2j2.Visibility = Visibility.Visible;

                    }

                    if (i.NombreCarta == "War3")
                    {


                        War3j2.Visibility = Visibility.Visible;

                    }

                    if (i.NombreCarta == "Boulderfist1")
                    {


                        Boulderfist1j2.Visibility = Visibility.Visible;
                    }

                    if (i.NombreCarta == "Boulderfist2")
                    {


                        Boulderfist2j2.Visibility = Visibility.Visible;
                    }

                    if (i.NombreCarta == "Boulderfist3")
                    {


                        Boulderfist3j2.Visibility = Visibility.Visible;
                    }

                }
            }
        }

        private void Rendirse_Click(object sender, RoutedEventArgs e)
        {
            if (jugando == 0)
            {
                ganador.Visibility = Visibility.Visible;
                if (Heroes[1].Nombre == "Paladin")
                {
                    paladingan.Visibility = Visibility.Visible;
                }
                else if (Heroes[1].Nombre == "Druida")
                {
                    druidagan.Visibility = Visibility.Visible;
                }
                else if (Heroes[1].Nombre == "Hunter")
                {
                    huntergan.Visibility = Visibility.Visible;
                }
                else if (Heroes[1].Nombre == "Sacerdote")
                {
                    priestgan.Visibility = Visibility.Visible;
                }
                else if (Heroes[1].Nombre == "Picaro")

                { picarogan.Visibility = Visibility.Visible; }
                else if (Heroes[1].Nombre == "Brujo")
                { brujogan.Visibility = Visibility.Visible; }
                else if (Heroes[1].Nombre == "Chaman")
                { chamangan.Visibility = Visibility.Visible; }
                else if (Heroes[1].Nombre == "Warrior")
                { warriorgan.Visibility = Visibility.Visible; }

            }
            else
            {
                ganador.Visibility = Visibility.Visible;
                if (Heroes[0].Nombre == "Paladin")
                {
                    paladingan.Visibility = Visibility.Visible;
                }
                else if (Heroes[0].Nombre == "Druida")
                {
                    druidagan.Visibility = Visibility.Visible;
                }
                else if (Heroes[0].Nombre == "Hunter")
                {
                    huntergan.Visibility = Visibility.Visible;
                }
                else if (Heroes[0].Nombre == "Sacerdote")
                {
                    priestgan.Visibility = Visibility.Visible;
                }
                else if (Heroes[0].Nombre == "Picaro")

                { picarogan.Visibility = Visibility.Visible; }
                else if (Heroes[0].Nombre == "Brujo")
                { brujogan.Visibility = Visibility.Visible; }
                else if (Heroes[0].Nombre == "Chaman")
                { chamangan.Visibility = Visibility.Visible; }
                else if (Heroes[0].Nombre == "Warrior")
                { warriorgan.Visibility = Visibility.Visible; }
            }
        }

        private void AtacarHeroe_Click(object sender, RoutedEventArgs e)
        {
            if (jugando == 0)
            {
                foreach (Minions i in Heroes[0].Tablero1)
                {
                    if (i.Seleccionada == 1 && i.NDT == 0)
                    {
                        
                        Heroes[1].Vida -= i.Daño;
                        if (Heroes[1].Vida <= 0)
                        {
                            ganador.Visibility = Visibility.Visible;
                            if (Heroes[0].Nombre == "Paladin")
                            {
                                paladingan.Visibility = Visibility.Visible;
                            }
                            else if (Heroes[0].Nombre == "Druida")
                            {
                                druidagan.Visibility = Visibility.Visible;
                            }
                            else if (Heroes[0].Nombre == "Hunter")
                            {
                                huntergan.Visibility = Visibility.Visible;
                            }
                            else if (Heroes[0].Nombre == "Sacerdote")
                            {
                                priestgan.Visibility = Visibility.Visible;
                            }
                            else if (Heroes[0].Nombre == "Picaro")

                            { picarogan.Visibility = Visibility.Visible; }
                            else if (Heroes[0].Nombre == "Brujo")
                            { brujogan.Visibility = Visibility.Visible; }
                            else if (Heroes[0].Nombre == "Chaman")
                            { chamangan.Visibility = Visibility.Visible; }
                            else if (Heroes[0].Nombre == "Warrior")
                            { warriorgan.Visibility = Visibility.Visible; }
                            i.NDT = 1;

                        }
                        break;
                    }

                }
                
                Vidaheroenojug.Text = "Heroe: " + Heroes[1].Nombre + "\n" + "Vida: " + Convert.ToString(Heroes[1].Vida);
            }
            else
            {
                foreach (Minions i in Heroes[1].Tablero1)
                {
                    if (i.Seleccionada == 1 && i.NDT == 0)
                    {
                        
                        Heroes[0].Vida -= i.Daño;

                        if (Heroes[0].Vida <= 0)
                        {
                            ganador.Visibility = Visibility.Visible;
                            if (Heroes[1].Nombre == "Paladin")
                            {
                                paladingan.Visibility = Visibility.Visible;
                            }
                            else if (Heroes[1].Nombre == "Druida")
                            {
                                druidagan.Visibility = Visibility.Visible;
                            }
                            else if (Heroes[1].Nombre == "Hunter")
                            {
                                huntergan.Visibility = Visibility.Visible;
                            }
                            else if (Heroes[1].Nombre == "Sacerdote")
                            {
                                priestgan.Visibility = Visibility.Visible;
                            }
                            else if (Heroes[1].Nombre == "Picaro")

                            { picarogan.Visibility = Visibility.Visible; }
                            else if (Heroes[1].Nombre == "Brujo")
                            { brujogan.Visibility = Visibility.Visible; }
                            else if (Heroes[1].Nombre == "Chaman")
                            { chamangan.Visibility = Visibility.Visible; }
                            else if (Heroes[1].Nombre == "Warrior")
                            { warriorgan.Visibility = Visibility.Visible; }
                        }
                        i.NDT = 1;
                        break;
                    }
                }
                Vidaheroenojug.Text = "Heroe: " + Heroes[0].Nombre + "\n" + "Vida: " + Convert.ToString(Heroes[0].Vida);
            }
            


        }
    }
}

