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

namespace lab4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollar = Convert.ToDouble(sum.Text);
            double resDouble = rateDollar * sumDollar;
            resSum.Text = resDouble.ToString();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            double rateEuro = Convert.ToDouble(rate1.Text);
            double sumEuro = Convert.ToDouble(sum1.Text);
            double resDouble1 = rateEuro * sumEuro;
            resSum1.Text = resDouble1.ToString();
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            double rateGrivn = Convert.ToDouble(rate2.Text);
            double sumGrivn = Convert.ToDouble(sum2.Text);
            double resDouble2 = rateGrivn * sumGrivn;
            resSum2.Text = resDouble2.ToString();
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            double rateDram = Convert.ToDouble(rate3.Text);
            double sumDram = Convert.ToDouble(sum3.Text);
            double resDouble3 = rateDram * sumDram;
            resSum3.Text = resDouble3.ToString();
        }

        private void Button01_Click(object sender, RoutedEventArgs e)
        {
            double valIn = Convert.ToDouble(val.Text);
            double resIn = valIn * 39.3701;
            res.Text = resIn.ToString();
        }

        private void Button11_Click(object sender, RoutedEventArgs e)
        {
            double valFut = Convert.ToDouble(val1.Text);
            double resFut = valFut * 3.28084;
            res1.Text = resFut.ToString();
        }

        private void Button21_Click(object sender, RoutedEventArgs e)
        {
            double valMile = Convert.ToDouble(val2.Text);
            double resMile = valMile / 0.000621371;
            res2.Text = resMile.ToString();
        }

        private void Button31_Click(object sender, RoutedEventArgs e)
        {
            double valVerst = Convert.ToDouble(val3.Text);
            double resVerst = valVerst / 0.000937383;
            res3.Text = resVerst.ToString();
        }
    }
}
