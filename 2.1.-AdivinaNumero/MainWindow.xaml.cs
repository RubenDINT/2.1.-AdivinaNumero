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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _2._1._AdivinaNumero
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int numeroAAdivinar;
        Random seed = new Random();

        public MainWindow()
        {
            InitializeComponent();
            
            numeroAAdivinar = seed.Next(1, 101);

        }

        private void Button_Click_Reiniciar(object sender, RoutedEventArgs e)
        {
            numeroAAdivinar = seed.Next(1, 101);
            mensajeTextBlock.Text = "Numero Reiniciado";
        }

        private void Button_Click_Comprobar(object sender, RoutedEventArgs e)
        {
            if (int.Parse(numeroIntroducido.Text) > numeroAAdivinar)
                mensajeTextBlock.Text = "Te has pasado";
            else if (int.Parse(numeroIntroducido.Text) < numeroAAdivinar)
                mensajeTextBlock.Text = "Te has quedado corto";
            else
                mensajeTextBlock.Text = "Enhorabuena has acertado!";
           
        }
    }
}
