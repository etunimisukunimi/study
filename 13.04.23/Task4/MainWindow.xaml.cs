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

namespace Task4
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
        private void BtnOK_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                float a = Convert.ToSingle(TbNumberA.Text);
                float b = Convert.ToSingle(TbNumberB.Text);
                float x = Convert.ToSingle(TbNumberX.Text);
                double aa = Math.Pow(-a, 5);
                double bb = Math.Pow(b, 5);
                double xx = Math.Pow(x, 2);
                double yy = (aa + Math.Cos(bb) + b * x);
                double result = Math.Sqrt(-aa * xx + yy) / Math.Log(xx + Math.Pow(yy, 2));
                TextBlockAnswerY.Text = Convert.ToString("Y: " + Math.Round(yy));
                TextBlockAnswer.Text = Convert.ToString("Ответ: " + Math.Round(result));
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены некорректные данные");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}