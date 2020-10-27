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

namespace ActividadesUT2_5
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Azul.IsChecked = true;
        }

        void AnyadirTexto(object sender, RoutedEventArgs e)
        {
            Cajon_TextBlock.Text = Caja_TextBox.Text;
        }

        private void Negrita_Checkbox(object sender, RoutedEventArgs e)
        {
            if (Negrita.IsChecked.Value)
            {
                Cajon_TextBlock.FontWeight = FontWeights.Bold;
            }
            else
            {                
                Cajon_TextBlock.FontWeight = FontWeights.Normal;
            }
        }

        private void Cursiva_Checkbox(object sender, RoutedEventArgs e)
        {
            if (Cursiva.IsChecked.Value)
            {
                Cajon_TextBlock.FontStyle = FontStyles.Italic;
            }
            else
            {
                Cajon_TextBlock.FontStyle = FontStyles.Normal;
            }
        }

        private void Color_RadioButton(object sender, RoutedEventArgs e)
        {
            if (Azul.IsChecked == true)
            {
                Cajon_TextBlock.Foreground = new SolidColorBrush(Colors.Blue);
            }
            if (Rojo.IsChecked == true)
            {
                Cajon_TextBlock.Foreground = new SolidColorBrush(Colors.Red);
            }
            if (Verde.IsChecked == true)
            {
                Cajon_TextBlock.Foreground = new SolidColorBrush(Colors.Green);
            }
        }
    }
}
