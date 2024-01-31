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

namespace FibonacciMaker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GenerateFibo(object sender, RoutedEventArgs e)
        {

            try
            {
                int len = Int32.Parse(length.Text);
                int a = 0, b = 1, c = 0;

                if (len < 1)
                {
                    MessageBox.Show("Minimum length is 1. Please try again.");
                    return;
                }

                if (len == 1) {
                    output.Text = "0";
                    return;
                }

                String outText = "0 1";
                for (int i = 2; i < len; i++)
                {
                    c = a + b;
                    outText += $" {c}";
                    a = b;
                    b = c;
                }
                output.Text = outText;
            }
            catch {
                MessageBox.Show("Please provide a valid number input");
            }
        }
    }
}
