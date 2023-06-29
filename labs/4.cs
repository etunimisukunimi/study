using NUnit.Framework;

namespace Lab4Variant01
{
    // Функция 1
    public class ArrayUtils
    {
        public static (int, int) ProductAndCountLessThanL(int[] array, int L)
        {
            int product = 1;
            int count = 0;

            foreach (int num in array)
            {
                if (num < L)
                {
                    product *= num;
                    count++;
                }
            }

            return (product, count);
        }

        // Функция 2
        public static int[] CalculateYArray(int[] array)
        {
            int[] yArray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                yArray[i] = array[i] / 4;
            }

            return yArray;
        }

        // Функция 3
        public static int SumOfEvenPositions(int[] array)
        {
            int sum = 0;

            for (int i = 1; i < array.Length; i += 2)
            {
                sum += array[i];
            }

            return sum;
        }
    }

    // Тестовые методы
    [TestFixture]
    public class Task1Tests
    {
        // Тест 1: Проверка вычисления произведения элементов меньше L и их количества
        [Test]
        public void CalculateProductAndCount_ElementsLessThanL_ReturnsProductAndCount()
        {
            int[] array = { 3, 7, 2, 9, 1, 4, 8, 6, 5, 10, 12, 15, 11, 20, 18 };
            int L = 10;

            int expectedProduct = 3024; // 3 * 7 * 2 * 9 * 1 * 4 = 3024
            int expectedCount = 6; // Количество элементов меньше 10: 3, 7, 2, 9, 1, 4

            var result = ArrayUtils.CalculateProductAndCount(array, L);

            Assert.AreEqual(expectedProduct, result.Product);
            Assert.AreEqual(expectedCount, result.Count);
        }

        // Тест 2: Проверка вычисления произведения элементов меньше L и их количества, когда все элементы больше L
        [Test]
        public void CalculateProductAndCount_AllElementsGreaterThanL_ReturnsZeroProductAndZeroCount()
        {
            int[] array = { 12, 15, 11, 20, 18, 13, 14, 19, 16, 17, 22, 21, 25, 23, 24 };
            int L = 10;

            int expectedProduct = 0; // Нет элементов меньше 10, произведение равно 0
            int expectedCount = 0; // Нет элементов меньше 10

            var result = ArrayUtils.CalculateProductAndCount(array, L);

            Assert.AreEqual(expectedProduct, result.Product);
            Assert.AreEqual(expectedCount, result.Count);
        }

        // Тест 3: Проверка вычисления произведения элементов меньше L и их количества, когда все элементы равны L
        [Test]
        public void CalculateProductAndCount_AllElementsEqualToL_ReturnsZeroProductAndZeroCount()
        {
            int[] array = { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 };
            int L = 10;

            int expectedProduct = 0; // Нет элементов меньше 10, произведение равно 0
            int expectedCount = 0; // Нет элементов меньше 10

            var result = ArrayUtils.CalculateProductAndCount(array, L);

            Assert.AreEqual(expectedProduct, result.Product);
            Assert.AreEqual(expectedCount, result.Count);
        }

        // Тест 4: Проверка вычисления произведения элементов меньше L и их количества, когда массив пустой
        [Test]
        public void CalculateProductAndCount_EmptyArray_ReturnsZeroProductAndZeroCount()
        {
            int[] array = new int[15];
            int L = 10;

            int expectedProduct = 0; // Нет элементов меньше 10, произведение равно 0
            int expectedCount = 0; // Нет элементов меньше 10

            var result = ArrayUtils.CalculateProductAndCount(array, L);

            Assert.AreEqual(expectedProduct, result.Product);
            Assert.AreEqual(expectedCount, result.Count);
        }

        // Тест 5: Проверка вычисления произведения элементов меньше L и их количества, когда все элементы отрицательные
        [Test]
        public void CalculateProductAndCount_AllElementsNegative_ReturnsProductAndCount()
        {
            int[] array = { -3, -7, -2, -9, -1, -4, -6, -5, -10, -12, -15, -11, -20, -18, -13 };
            int L = -10;

            int expectedProduct = -544320; // -3 * -7 * -2 * -9 * -1 * -4 = -544320
            int expectedCount = 6; // Количество элементов меньше -10: -3, -7, -2, -9, -1, -4

            var result = ArrayUtils.CalculateProductAndCount(array, L);

            Assert.AreEqual(expectedProduct, result.Product);
            Assert.AreEqual(expectedCount, result.Count);
        }
    }
    

        // Тестовые методы для функции 2
    [TestFixture]
    public class Task2Tests
    {
            // Тест 1: Проверка вычисления произведения элементов массива, меньших L
            [Test]
            public void CalculateProductOfElementsLessThanL_ReturnsProduct()
            {
                int[] array = { 2, 8, 4, 6, 10, 12, 16, 14, 18, 20, 22, 24, 26, 28, 30 };
                int L = 15;

                int expectedProduct = 768; // 2 * 8 * 4 * 6 = 768

                int result = ArrayUtils.CalculateProductOfElementsLessThanL(array, L);

                Assert.AreEqual(expectedProduct, result);
            }

            // Тест 2: Проверка вычисления количества элементов массива, меньших L
            [Test]
            public void CalculateCountOfElementsLessThanL_ReturnsCount()
            {
                int[] array = { 2, 8, 4, 6, 10, 12, 16, 14, 18, 20, 22, 24, 26, 28, 30 };
                int L = 15;

                int expectedCount = 3; // 2, 8, 4

                int result = ArrayUtils.CalculateCountOfElementsLessThanL(array, L);

                Assert.AreEqual(expectedCount, result);
            }

            // Тест 3: Проверка вычисления массива {y_i} по формуле y_i = x_i / 4
            [Test]
            public void CalculateYArray_DivideElementsBy4_ReturnsYArray()
            {
                int[] array = { 2, 8, 4, 6, 10, 12, 16, 14, 18, 20, 22, 24, 26, 28, 30 };

                double[] expectedYArray = { 0.5, 2.0, 1.0, 1.5, 2.5, 3.0, 4.0, 3.5, 4.5, 5.0, 5.5, 6.0, 6.5, 7.0, 7.5 };

                double[] result = ArrayUtils.CalculateYArray(array);

                Assert.AreEqual(expectedYArray, result);
            }

            // Тест 4: Проверка вычисления суммы элементов массива {y_i}, расположенных на четных позициях
            [Test]
            public void CalculateSumOfElementsAtEvenPositions_ReturnsSum()
            {
                int[] array = { 2, 8, 4, 6, 10, 12, 16, 14, 18, 20, 22, 24, 26, 28, 30 };

                double expectedSum = 25.0; // 2.0 + 4.0 + 10.0 + 16.0 + 18.0 + 22.0 + 26.0 + 30.0 = 25.0

                double result = ArrayUtils.CalculateSumOfElementsAtEvenPositions(array);

                Assert.AreEqual(expectedSum, result);
            }

            // Тест 5: Проверка вычисления суммы элементов массива {y_i}, расположенных на нечетных позициях
            [Test]
            public void CalculateSumOfElementsAtOddPositions_ReturnsSum()
            {
                int[] array = { 2, 8, 4, 6, 10, 12, 16, 14, 18, 20, 22, 24, 26, 28, 30 };

                double expectedSum = 23.0; // 8.0 + 6.0 + 12.0 + 14.0 + 20.0 + 24.0 + 28.0 = 23.0

                double result = ArrayUtils.CalculateSumOfElementsAtOddPositions(array);

                Assert.AreEqual(expectedSum, result);
            }
    }
    
    
}
