﻿using System;
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
    /// Interaction logic for Creditos.xaml
    /// </summary>
    public partial class Creditos : Window
    {
        public Creditos()
        {
            InitializeComponent();
        }

        public void btn_click_close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
