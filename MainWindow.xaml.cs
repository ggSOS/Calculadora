using System.Drawing;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculadora
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Calculadora calculadora;

        public MainWindow()
        {
            InitializeComponent();

            calculadora = new Calculadora( new double[1]);

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {   
            //double saida = calculadora.Processa();
            //displaySaida.Text = saida.ToString();
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            string entrada = input1.Text;
            // out _ se não precisar do valor convertido
            if (double.TryParse(entrada, out double entradaConvertida))
            {
                calculadora.addValor(entradaConvertida);
            }
        }

        private void input1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}