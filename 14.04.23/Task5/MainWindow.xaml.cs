using System;
using System.Windows;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, RoutedEventArgs e)
        {
            int year, century;

            try
            {
                year = int.Parse(TbYear.Text);

                // Расчитываем столетие, вычитая 1 из года (для того, чтобы учитывать, что 1901 год - начало 20 века),
                // делим на 100, и добавляем единицу (для того, чтобы округлить результат вверх до целого столетия)
                century = (year - 1) / 100 + 1;

                TbResult.Text = $"Год {year} соответствует {century}-му столетию.";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
    }
}
