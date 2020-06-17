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

namespace enigmaMachine
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Encriptador encriptador;
        public MainWindow()
        {
            System.Threading.Thread.Sleep(3000);
            InitializeComponent();
            encriptador = new Encriptador();
            textBoxSalida.Text = "";
            textBoxEntrada.Text = "";
            actualizar_vista_rotores();
        }

        public MainWindow(bool sleep)
        {
            if (!sleep)
            {
                InitializeComponent();
                encriptador = new Encriptador();
                textBoxSalida.Text = "";
                textBoxEntrada.Text = "";
                actualizar_vista_rotores();
            }
        }

        private void btn_click_rotar_arriba( object sender, RoutedEventArgs e)
        {
            Button button = ((Button)sender);
            int numRotor = int.Parse(button.Tag.ToString());
            encriptador.rotarRotor(numRotor, "arriba");
            actualizar_vista_rotores();
        }
        private void btn_click_rotar_abajo(object sender, RoutedEventArgs e)
        {
            Button button = ((Button)sender);
            int numRotor = int.Parse(button.Tag.ToString());
            encriptador.rotarRotor(numRotor, "abajo");
            actualizar_vista_rotores();
        }

        private void btn_click_encriptar(object sender, RoutedEventArgs e)
        {
            Button button = ((Button)sender);
            char letra = char.Parse(button.Content.ToString());
            textBoxEntrada.Text += letra;
            textBoxSalida.Text += encriptador.encriptar(letra);
            actualizar_vista_rotores();
        }

        private void btn_click_borrar(object sender, RoutedEventArgs e)
        {
            encriptador.borrarCaracter();
            textBoxEntrada.Text = textBoxEntrada.Text.Remove(textBoxEntrada.Text.Length - 1);
            textBoxSalida.Text = textBoxSalida.Text.Remove(textBoxSalida.Text.Length - 1);
            actualizar_vista_rotores();
        }

        private void btn_click_reiniciar(object sender, RoutedEventArgs e)
        {
            textBoxEntrada.Text = "";
            textBoxSalida.Text = "";
            encriptador = new Encriptador();
            actualizar_vista_rotores();
        }

        private void btn_click_ir_a_instrucciones(object sender, RoutedEventArgs e)
        {
            Instrucciones instrucciones = new Instrucciones();
            instrucciones.Show();
            this.Close();
        }

        private void btn_click_ir_a_historia(object sender, RoutedEventArgs e)
        {
            Historia historia = new Historia();
            historia.Show();
            this.Close();
        }

        private void btn_click_abrir_creditos(object sender, RoutedEventArgs e)
        {
            Creditos creditos = new Creditos();
            creditos.Activate();
            creditos.Topmost = true;
            creditos.Show();
        }

        private void btn_click_minimizar(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btn_click_cerrar(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void actualizar_vista_rotores()
        {
            textBox1.Text = encriptador.rotor1.alfabeto[0].ToString();
            textBox2.Text = encriptador.rotor2.alfabeto[0].ToString();
            textBox3.Text = encriptador.rotor3.alfabeto[0].ToString();
        }

    }
}
