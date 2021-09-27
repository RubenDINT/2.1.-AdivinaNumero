using System;
using System.Windows;

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
            mensajeTextBlock.Text = String.Empty;
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
