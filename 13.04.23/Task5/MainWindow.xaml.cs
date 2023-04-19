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

namespace Task5
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
                double a1 = Convert.ToInt32(TbNumberA1.Text);
                double b1 = Convert.ToInt32(TbNumberB1.Text);
                double c1 = Convert.ToInt32(TbNumberC1.Text);
                double a2 = Convert.ToInt32(TbNumberA2.Text);
                double b2 = Convert.ToInt32(TbNumberB2.Text);
                double c2 = Convert.ToInt32(TbNumberC2.Text);
                double d = a1 * b2 - a2 * b1;
                double x = (c1 * b2 - c2 * b1) / d;
                double y = (a1 * c2 - a2 * c1) / d;
                double q = a1 * x + b1 * y;
                double w = a2 * x + b2 * y;
                TextBlockAnswer.Text = ($" A1·x + B1·y = {q} \n C1 = {c1} \n A2·x + B2·y = {w} \n C2 = {c2}");
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
