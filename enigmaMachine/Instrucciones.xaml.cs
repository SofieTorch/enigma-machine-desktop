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
using System.Windows.Shapes;

namespace enigmaMachine
{
    /// <summary>
    /// Interaction logic for Instrucciones.xaml
    /// </summary>
    public partial class Instrucciones : Window
    {
        public Instrucciones()
        {
            InitializeComponent();
        }

        private void btn_click_volver(object sender, RoutedEventArgs e)
        {
            MainWindow home = new MainWindow(false);
            home.Show();
            this.Close();
        }
        private void btn_click_minimizar(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
        private void btn_click_cerrar(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
