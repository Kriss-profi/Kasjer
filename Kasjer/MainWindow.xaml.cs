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
using System.Globalization;

namespace Kasjer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public delegate double MyDelegate();
    public partial class MainWindow : Window
    {
        private const string S = "Siema";
        private const string P = "Przelicz";
        public double suma = 0;
        public double KasetkaD;
        public double KasaD;
        public double SejfD;
        private const double N500 = 500;
        private const double N50 = 50;
        private const double N5 = 5;
        private const double N05 = 0.5;
        private const double N005 = 0.05;
        private const double N200 = 200;
        private const double N20 = 20;
        private const double N2 = 2;
        private const double N02 = 0.2;
        private const double N002 = 0.02;
        private const double N100 = 100;
        private const double N10 = 10;
        private const double N1 = 1;
        private const double N01 = 0.1;
        private const double N001 = 0.01;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Przelicz_Click_K(object sender, RoutedEventArgs e)
        {
            suma = 0;
            double kasetka = 0;

            kasetka += (double)(N500 * double.Parse(K_50000.Text));
            kasetka += (double)(N50 * double.Parse(K_5000.Text));
            kasetka += (double)(N5 * double.Parse(K_500.Text));
            kasetka += (double)(N05 * double.Parse(K_50.Text));
            kasetka += (double)(N005 * double.Parse(K_5.Text));

            kasetka += (double)(N200 * double.Parse(K_20000.Text));
            kasetka += (double)(N20 * double.Parse(K_2000.Text));
            kasetka += (double)(N2 * double.Parse(K_200.Text));
            kasetka += (double)(N02 * double.Parse(K_20.Text));
            kasetka += (double)(N002 * double.Parse(K_2.Text));

            kasetka += (double)(N100 * double.Parse(K_10000.Text));
            kasetka += (double)(N10 * double.Parse(K_1000.Text));
            kasetka += (double)(N1 * double.Parse(K_100.Text));
            kasetka += (double)(N01 * double.Parse(K_10.Text));
            kasetka += (double)(N001 * double.Parse(K_1.Text));

            Kasetka.Text = kasetka.ToString("C", CultureInfo.CurrentCulture);
            KasetkaD = kasetka;
            suma = kasetka + KasaD + SejfD;
            Suma.Text = suma.ToString("C", CultureInfo.CurrentCulture);

        //    return KasetkaD;
        }
        private void Przelicz_Click_Kasa(object sender, RoutedEventArgs e)
        {
            suma = 0;
            double kasa = 0;

            kasa += (double)(N500 * double.Parse(Kasa_50000.Text));
            kasa += (double)(N50 * double.Parse(Kasa_5000.Text));
            kasa += (double)(N5 * double.Parse(Kasa_500.Text));
            kasa += (double)(N05 * double.Parse(Kasa_50.Text));
            kasa += (double)(N005 * double.Parse(Kasa_5.Text));
            
            kasa += (double)(N200 * double.Parse(Kasa_20000.Text));
            kasa += (double)(N20 * double.Parse(Kasa_2000.Text));
            kasa += (double)(N2 * double.Parse(Kasa_200.Text));
            kasa += (double)(N02 * double.Parse(Kasa_20.Text));
            kasa += (double)(N002 * double.Parse(Kasa_2.Text));
            
            kasa += (double)(N100 * double.Parse(Kasa_10000.Text));
            kasa += (double)(N10 * double.Parse(Kasa_1000.Text));
            kasa += (double)(N1 * double.Parse(Kasa_100.Text));
            kasa += (double)(N01 * double.Parse(Kasa_10.Text));
            kasa += (double)(N001 * double.Parse(Kasa_1.Text));

            Kasa.Text = kasa.ToString("C", CultureInfo.CurrentCulture);
            KasaD = kasa;
            suma += kasa + KasetkaD + SejfD;
            Suma.Text = suma.ToString("C", CultureInfo.CurrentCulture);

        //    return KasaD;
        }
        private void Przelicz_Click_Sejf(object sender, RoutedEventArgs e)
        {
            suma = 0;
            double sejf = 0;

            sejf += (double)(N500 * double.Parse(Sejf_50000.Text));
            sejf += (double)(N50 * double.Parse(Sejf_5000.Text));
            sejf += (double)(N5 * double.Parse(Sejf_500.Text));
            sejf += (double)(N05 * double.Parse(Sejf_50.Text));
            sejf += (double)(N005 * double.Parse(Sejf_5.Text));

            sejf += (double)(N200 * double.Parse(Sejf_20000.Text));
            sejf += (double)(N20 * double.Parse(Sejf_2000.Text));
            sejf += (double)(N2 * double.Parse(Sejf_200.Text));
            sejf += (double)(N02 * double.Parse(Sejf_20.Text));
            sejf += (double)(N002 * double.Parse(Sejf_2.Text));

            sejf += (double)(N100 * double.Parse(Sejf_10000.Text));
            sejf += (double)(N10 * double.Parse(Sejf_1000.Text));
            sejf += (double)(N1 * double.Parse(Sejf_100.Text));
            sejf += (double)(N01 * double.Parse(Sejf_10.Text));
            sejf += (double)(N001 * double.Parse(Sejf_1.Text));

            Sejf.Text = sejf.ToString("C", CultureInfo.CurrentCulture);
            SejfD = sejf;
            suma += sejf + KasetkaD + KasaD;
            Suma.Text = suma.ToString("C", CultureInfo.CurrentCulture);

        //    return SejfD;
        }
        private void Przelicz_Click(object sender, RoutedEventArgs e)
        {
            Przelicz.Content = S;
        }

        private void Drukuj_Click(object sender, RoutedEventArgs e)
        {
            Przelicz.Content = P;
        }

        private void K_10000_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            K_10000.Select(K_10000.Text.Length, 0);
        }

        private void Wypelnij_Click(object sender, RoutedEventArgs e)
        {

            K_50000.Text = "2";
            K_5000.Text = "2";
            K_500.Text = "2";
            K_50.Text = "2";
            K_5.Text = "2";
            K_20000.Text = "2";
            K_2000.Text = "2";
            K_200.Text = "2";
            K_20.Text = "2";
            K_2.Text = "2";
            K_10000.Text = "2";
            K_1000.Text = "2";
            K_100.Text = "2";
            K_10.Text = "2";
            K_1.Text = "2";
            Kasa_50000.Text = "12";
            Kasa_5000.Text = "7";
            Kasa_500.Text = "2";
            Kasa_50.Text = "1";
            Kasa_5.Text = "27";
            Kasa_20000.Text = "8";
            Kasa_2000.Text = "16";
            Kasa_200.Text = "46";
            Kasa_20.Text = "38";
            Kasa_2.Text = "52";
            Kasa_10000.Text = "3";
            Kasa_1000.Text = "16";
            Kasa_100.Text = "46";
            Kasa_10.Text = "38";
            Kasa_1.Text = "52";
            Sejf_50000.Text = "12";
            Sejf_5000.Text = "7";
            Sejf_500.Text = "2";
            Sejf_50.Text = "1";
            Sejf_5.Text = "27";
            Sejf_20000.Text = "8";
            Sejf_2000.Text = "16";
            Sejf_200.Text = "46";
            Sejf_20.Text = "38";
            Sejf_2.Text = "52";
            Sejf_10000.Text = "3";
            Sejf_1000.Text = "16";
            Sejf_100.Text = "46";
            Sejf_10.Text = "38";
            Sejf_1.Text = "52";
        }

        public void Wyzeruj_Click(object sender, RoutedEventArgs e)
        {

            K_50000.Text = "0";
            K_5000.Text = "0";
            K_500.Text = "0";
            K_50.Text = "0";
            K_5.Text = "0";
            K_20000.Text = "0";
            K_2000.Text = "0";
            K_200.Text = "0";
            K_20.Text = "0";
            K_2.Text = "0";
            K_10000.Text = "0";
            K_1000.Text = "0";
            K_100.Text = "0";
            K_10.Text = "0";
            K_1.Text = "0";
            Kasa_50000.Text = "0";
            Kasa_5000.Text = "0";
            Kasa_500.Text = "0";
            Kasa_50.Text = "0";
            Kasa_5.Text = "0";
            Kasa_20000.Text = "0";
            Kasa_2000.Text = "0";
            Kasa_200.Text = "0";
            Kasa_20.Text = "0";
            Kasa_2.Text = "0";
            Kasa_10000.Text = "0";
            Kasa_1000.Text = "0";
            Kasa_100.Text = "0";
            Kasa_10.Text = "0";
            Kasa_1.Text = "0";
            Sejf_50000.Text = "0";
            Sejf_5000.Text = "0";
            Sejf_500.Text = "0";
            Sejf_50.Text = "0";
            Sejf_5.Text = "0";
            Sejf_20000.Text = "0";
            Sejf_2000.Text = "0";
            Sejf_200.Text = "0";
            Sejf_20.Text = "0";
            Sejf_2.Text = "0";
            Sejf_10000.Text = "0";
            Sejf_1000.Text = "0";
            Sejf_100.Text = "0";
            Sejf_10.Text = "0";
            Sejf_1.Text = "0";
        }

        private void TextBox_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Dispatcher.BeginInvoke(new Action(() => tb.SelectAll()));
        }

    }
}
