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
        CalculadoraCore calculadora = new CalculadoraCore();

        public MainWindow()
        {
            InitializeComponent();

        }

        private void textInput_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void showInput_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void displaySaida_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            calculadora = new CalculadoraCore();
            textInput.Text = "";
            showInput.Text = "";

        }

        private void adicionarNum_Click(object sender, RoutedEventArgs e)
        {
            string entrada = textInput.Text;
            double valor;
            if (double.TryParse(entrada, out valor))
            {
                if (calculadora.AddValor(valor))
                {
                    textInput.Text = "";
                    showInput.Text += valor.ToString() + "\n";
                }
            }
        }


        private void processarSoma_Click(object sender, RoutedEventArgs e)
        {
            double saida = calculadora.Soma();

            displaySaida.Text = saida.ToString();
        }


        private void processarSubtracao_Click(object sender, RoutedEventArgs e)
        {
            double saida = calculadora.Subtracao();

            displaySaida.Text = saida.ToString();
        }


        private void processarMultiplicacao_Click(object sender, RoutedEventArgs e)
        {
            double saida = calculadora.Multiplicacao();

            displaySaida.Text = saida.ToString();
        }


        private void processarDivisao_Click(object sender, RoutedEventArgs e)
        {
            double? saida = calculadora.Divisao();

            if (saida == null)
            {
                displaySaida.Text = "Nenhum número é divisível por zero";
            }
            else
            {
                displaySaida.Text = saida.ToString();
            }
        }
    }
}