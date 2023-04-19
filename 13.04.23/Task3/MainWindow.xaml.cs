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

namespace Task3
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
                float c = Convert.ToSingle(TbNumberC.Text);
                double D = b * b - 4 * a * c;
                TextBlockAnswerD.Text = Convert.ToString("Дискриминант: " + Math.Round(D));
                if (D > 0)
                {
                    double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                    TextBlockAnswerX1.Text = Convert.ToString("Корни уравнения: " + x1);
                    TextBlockAnswerX2.Text = Convert.ToString(x2);

                }
                else if (D == 0)
                {
                    double x3 = (-b / (2 * a));
                    TextBlockAnswerX1.Text = Convert.ToString("Корень уравнения: " + Math.Round(x3));
                }
                else
                {
                    MessageBox.Show("Корней нет.");
                }
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

