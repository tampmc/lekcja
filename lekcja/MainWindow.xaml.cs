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

namespace lekcja
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        int a;
        int b;
        int c;




        private void BT_DODAWANIE_Click(object sender, RoutedEventArgs e)
        {
            a = int.Parse(TB_DODAWANIE.Text);
            b = int.Parse(TP_ODEJMOWANIE.Text);
            c = a + b;
            MessageBox.Show(c.ToString());
        }

        private void BT_ODEJMOWANIE_Click(object sender, RoutedEventArgs e)
        {
            a = int.Parse(TB_DODAWANIE.Text);
            b = int.Parse(TP_ODEJMOWANIE.Text);
            c = a - b;
            MessageBox.Show(c.ToString());
        }

        private void BT_MNOZENIE_Click(object sender, RoutedEventArgs e)
        {
            a = int.Parse(TB_DODAWANIE.Text);
            b = int.Parse(TP_ODEJMOWANIE.Text);
            c = a * b;
            MessageBox.Show(c.ToString());
        }

        private void B_DZIELENIE_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TB_DZIELENIE_TextChanged(object sender, TextChangedEventArgs e)
        {
            a = int.Parse(TB_DODAWANIE.Text);
            b = int.Parse(TP_ODEJMOWANIE.Text);
            c = a / b;
            MessageBox.Show(c.ToString());
        }

        private void TB_MNOZENIE_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TP_ODEJMOWANIE_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TB_DODAWANIE_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
