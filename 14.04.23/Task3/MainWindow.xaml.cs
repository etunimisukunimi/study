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

        private void BtnCancelClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnCalculateClick(object sender, RoutedEventArgs e)
        {
            try
            {
                int k = Convert.ToInt32(TbK.Text);

                if (k >= 1 && k <= 365)
                {
                    int firstDayOfYear = 1; // 1 января - четверг
                    int dayOfWeek = (firstDayOfYear + k - 1) % 7;

                    TextBlockResult.Text = $"Номер дня недели для {k}-го дня года: {dayOfWeek}";
                }
                else
                {
                    MessageBox.Show("Введите число K в диапазоне от 1 до 365");
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
    }
}

