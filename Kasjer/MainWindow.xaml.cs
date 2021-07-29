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

namespace Kasjer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string S = "Siema";
        private const string P = "Przelicz";
        public MainWindow()
        {
            InitializeComponent();
            Suma.Text = "0.00";
        }

        private void Przelicz_Click(object sender, RoutedEventArgs e)
        {
            Przelicz.Content = S;
        }

        private void Drukuj_Click(object sender, RoutedEventArgs e)
        {
            Przelicz.Content = P;
        }
    }
}
