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

        // Обработчик события нажатия на кнопку расчета
        private void BtnCalculate_Click(object sender, RoutedEventArgs e)
        {
            // Объявляем целочисленные переменные a, b, c
            int a, b, c;

            try
            {
                // Пытаемся преобразовать введенные пользователем строки в целочисленные значения
                // и сохраняем их в соответствующие переменные a, b, c
                a = int.Parse(TbA.Text);
                b = int.Parse(TbB.Text);
                c = int.Parse(TbC.Text);

                // Вычисляем количество квадратов, размещенных на прямоугольнике,
                // и площадь незанятой части прямоугольника
                int count = (a / c) * (b / c);
                int area = a * b - count * c * c;

                // Выводим результаты расчета в соответствующие текстовые блоки на форме
                TbCount.Text = $"Количество: {count}\nПлощадь: {area}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
    }
}
