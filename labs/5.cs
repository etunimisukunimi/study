using NUnit.Framework;
using System;
using Lab5Variant01;
namespace Lab5Variant01
{
    public class MatrixUtils
    {
        // Задача 1
        public static int FindMinimumElement(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int minElement = matrix[0, 0];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] < minElement)
                    {
                        minElement = matrix[i, j];
                    }
                }
            }

            return minElement;
        }

        // Задача 2
        public static int SumOfPositiveElementsInRow(int[,] matrix, int row)
        {
            int cols = matrix.GetLength(1);
            int sum = 0;

            for (int j = 0; j < cols; j++)
            {
                if (matrix[row, j] > 0)
                {
                    sum += matrix[row, j];
                }
            }

            return sum;
        }

        // Задача 3
        public static int[] CountZeroElementsInColumns(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[] zeroCounts = new int[cols];

            for (int j = 0; j < cols; j++)
            {
                for (int i = 0; i < rows; i++)
                {
                    if (matrix[i, j] == 0)
                    {
                        zeroCounts[j]++;
                    }
                }
            }

            return zeroCounts;
        }

        // Задача 4
        public static int[] GetElementsLessThan(int[,] matrix, int value)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[] lessThanArray = new int[rows * cols];
            int index = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] < value)
                    {
                        lessThanArray[index] = matrix[i, j];
                        index++;
                    }
                }
            }

            Array.Resize(ref lessThanArray, index);
            return lessThanArray;
        }
    }
}

namespace Lab5Variant01.Tests
{
    [TestFixture]
    public class MatrixUtilsTests
    {
        private int[,] matrix;

        [SetUp]
        public void Setup()
        {
            matrix = new int[,]
            {
                { 3, 8, 2, 5, 9, 1, 4 },
                { -1, 6, 0, 7, 2, 3, 8 },
                { 4, -2, 9, 3, 6, 0, 7 },
                { 2, 5, 1, -3, 7, 6, 2 },
                { 0, 4, 2, 9, 1, -2, 5 }
            };
        }

        // Тестовые методы для задачи 1
        [TestFixture]
        public class MatrixUtilsTests
        {
            // Задача 1: Найти минимальный элемент матрицы

            // Тест 1: Матрица содержит положительные и отрицательные элементы
            [Test]
            public void Test_FindMinimumElement_MatrixWithPositiveAndNegativeElements_ShouldReturnMinimumElement()
            {
                int[,] matrix = new int[,]
                {
                    { 5, -2, 9, -4, 7, 3, -1 },
                    { 1, -6, 4, 0, 2, -3, 8 },
                    { 5, -2, 9, -4, 7, 3, -1 },
                    { 1, -6, 4, 0, 2, -3, 8 },
                    { 5, -2, 9, -4, 7, 3, -1 }
                };

                int expected = -6;
                int actual = MatrixUtils.FindMinimumElement(matrix);

                Assert.AreEqual(expected, actual);
            }

            // Тест 2: Матрица состоит из одного элемента
            [Test]
            public void Test_FindMinimumElement_MatrixWithSingleElement_ShouldReturnElement()
            {
                int[,] matrix = new int[,]
                {
                    { 3 }
                };

                int expected = 3;
                int actual = MatrixUtils.FindMinimumElement(matrix);

                Assert.AreEqual(expected, actual);
            }

            // Тест 3: Матрица содержит только отрицательные элементы
            [Test]
            public void Test_FindMinimumElement_MatrixWithOnlyNegativeElements_ShouldReturnMinimumElement()
            {
                int[,] matrix = new int[,]
                {
                    { -5, -2, -9, -4, -7, -3, -1 },
                    { -1, -6, -4, -2, -3, -8, -5 },
                    { -5, -2, -9, -4, -7, -3, -1 },
                    { -1, -6, -4, -2, -3, -8, -5 },
                    { -5, -2, -9, -4, -7, -3, -1 }
                };

                int expected = -9;
                int actual = MatrixUtils.FindMinimumElement(matrix);

                Assert.AreEqual(expected, actual);
            }

            // Тест 4: Матрица содержит только положительные элементы
            [Test]
            public void Test_FindMinimumElement_MatrixWithOnlyPositiveElements_ShouldReturnMinimumElement()
            {
                int[,] matrix = new int[,]
                {
                    { 5, 2, 9, 4, 7, 3, 1 },
                    { 1, 6, 4, 2, 3, 8, 5 },
                    { 5, 2, 9, 4, 7, 3, 1 },
                    { 1, 6, 4, 2, 3, 8, 5 },
                    { 5, 2, 9, 4, 7, 3, 1 }
                };

                int expected = 1;
                int actual = MatrixUtils.FindMinimumElement(matrix);

                Assert.AreEqual(expected, actual);
            }

            // Тест 5: Матрица содержит нулевые элементы
            [Test]
            public void Test_FindMinimumElement_MatrixWithZeroElements_ShouldReturnMinimumElement()
            {
                int[,] matrix = new int[,]
                {
                    { 0, 2, 9, 0, 7, 3, 1 },
                    { 1, 6, 4, 0, 2, 3, 8 },
                    { 0, 2, 9, 0, 7, 3, 1 },
                    { 1, 6, 4, 0, 2, 3, 8 },
                    { 0, 2, 9, 0, 7, 3, 1 }
                };

                int expected = 0;
                int actual = MatrixUtils.FindMinimumElement(matrix);

                Assert.AreEqual(expected, actual);
            }
        }


        // Тестовые методы для задачи 2
        
        [TestFixture]
        public class MatrixUtilsTests
        {
            // Задача 2: Вычислить сумму положительных элементов во 2-й строке матрицы

            // Тест 1: Матрица содержит положительные и отрицательные элементы
            [Test]
            public void Test_SumOfPositiveElementsInRow_MatrixWithPositiveAndNegativeElements_ShouldReturnSum()
            {
                int[,] matrix = new int[,]
                {
                    { 5, -2, 9, -4, 7, 3, -1 },
                    { 1, -6, 4, 0, 2, -3, 8 },
                    { 5, -2, 9, -4, 7, 3, -1 },
                    { 1, -6, 4, 0, 2, -3, 8 },
                    { 5, -2, 9, -4, 7, 3, -1 }
                };
                int row = 1;

                int expected = 15; // Сумма положительных элементов во 2-й строке: 1 + 4 + 2 + 8 = 15
                int actual = MatrixUtils.SumOfPositiveElementsInRow(matrix, row);

                Assert.AreEqual(expected, actual);
            }

            // Тест 2: Матрица содержит только отрицательные элементы
            [Test]
            public void Test_SumOfPositiveElementsInRow_MatrixWithOnlyNegativeElements_ShouldReturnZero()
            {
                int[,] matrix = new int[,]
                {
                    { -5, -2, -9, -4, -7, -3, -1 },
                    { -1, -6, -4, -2, -3, -8, -5 },
                    { -5, -2, -9, -4, -7, -3, -1 },
                    { -1, -6, -4, -2, -3, -8, -5 },
                    { -5, -2, -9, -4, -7, -3, -1 }
                };
                int row = 3;

                int expected = 0; // Все элементы во 4-й строке отрицательные, сумма положительных равна 0
                int actual = MatrixUtils.SumOfPositiveElementsInRow(matrix, row);

                Assert.AreEqual(expected, actual);
            }

            // Тест 3: Матрица содержит только положительные элементы
            [Test]
            public void Test_SumOfPositiveElementsInRow_MatrixWithOnlyPositiveElements_ShouldReturnSum()
            {
                int[,] matrix = new int[,]
                {
                    { 5, 2, 9, 4, 7, 3, 1 },
                    { 1, 6, 4, 2, 3, 8, 5 },
                    { 5, 2, 9, 4, 7, 3, 1 },
                    { 1, 6, 4, 2, 3, 8, 5 },
                    { 5, 2, 9, 4, 7, 3, 1 }
                };
                int row = 2;

                int expected = 31; // Сумма положительных элементов в 3-й строке: 5 + 2 + 9 + 4 + 7 + 3 + 1 = 31
                int actual = MatrixUtils.SumOfPositiveElementsInRow(matrix, row);

                Assert.AreEqual(expected, actual);
            }

            // Тест 4: Матрица содержит нулевые элементы
            [Test]
            public void Test_SumOfPositiveElementsInRow_MatrixWithZeroElements_ShouldReturnSum()
            {
                int[,] matrix = new int[,]
                {
                    { 0, 2, 9, 0, 7, 3, 1 },
                    { 1, 6, 4, 0, 2, 3, 8 },
                    { 0, 2, 9, 0, 7, 3, 1 },
                    { 1, 6, 4, 0, 2, 3, 8 },
                    { 0, 2, 9, 0, 7, 3, 1 }
                };
                int row = 0;

                int expected = 22; // Сумма положительных элементов в 1-й строке: 2 + 9 + 7 + 3 + 1 = 22
                int actual = MatrixUtils.SumOfPositiveElementsInRow(matrix, row);

                Assert.AreEqual(expected, actual);
            }

            // Тест 5: Матрица содержит только один положительный элемент
            [Test]
            public void Test_SumOfPositiveElementsInRow_MatrixWithSinglePositiveElement_ShouldReturnPositiveElement()
            {
                int[,] matrix = new int[,]
                {
                    { -5, -2, -9, -4, -7, -3, -1 },
                    { -1, -6, -4, -2, -3, -8, -5 },
                    { -5, -2, -9, -4, -7, -3, -1 },
                    { -1, -6, -4, -2, -3, -8, -5 },
                    { 5, 2, 9, 4, 7, 3, 1 }
                };
                int row = 4;

                int expected = 31; // Единственный положительный элемент в 5-й строке: 5
                int actual = MatrixUtils.SumOfPositiveElementsInRow(matrix, row);

                Assert.AreEqual(expected, actual);
            }
        }

        // Тестовые методы для задачи 3

        [TestFixture]
        public class MatrixUtilsTests
        {
            // Задача 3: Сформировать одномерный массив L из количеств нулевых элементов каждого столбца матрицы

            // Тест 1: Матрица содержит нулевые элементы в разных столбцах
            [Test]
            public void Test_CountZeroElementsInColumns_MatrixWithZeroElements_ShouldReturnZeroCounts()
            {
                int[,] matrix = new int[,]
                {
                    { 0, 2, 9, 0, 7, 3, 1 },
                    { 1, 6, 4, 0, 2, 3, 8 },
                    { 0, 2, 9, 0, 7, 3, 1 },
                    { 1, 0, 4, 0, 2, 3, 8 },
                    { 0, 2, 9, 0, 7, 0, 1 }
                };

                int[] expected = { 3, 0, 0, 3, 2, 1, 0 }; // Количество нулевых элементов в каждом столбце: 3, 0, 0, 3, 2, 1, 0
                int[] actual = MatrixUtils.CountZeroElementsInColumns(matrix);

                Assert.AreEqual(expected, actual);
            }

            // Тест 2: Матрица не содержит нулевых элементов
            [Test]
            public void Test_CountZeroElementsInColumns_MatrixWithoutZeroElements_ShouldReturnZeroCounts()
            {
                int[,] matrix = new int[,]
                {
                    { 5, 2, 9, 4, 7, 3, 1 },
                    { 1, 6, 4, 2, 3, 8, 5 },
                    { 5, 2, 9, 4, 7, 3, 1 },
                    { 1, 6, 4, 2, 3, 8, 5 },
                    { 5, 2, 9, 4, 7, 3, 1 }
                };

                int[] expected = { 0, 0, 0, 0, 0, 0, 0 }; // Нет нулевых элементов, все столбцы содержат 0 нулевых элементов
                int[] actual = MatrixUtils.CountZeroElementsInColumns(matrix);

                Assert.AreEqual(expected, actual);
            }

            // Тест 3: Матрица содержит только нулевые элементы
            [Test]
            public void Test_CountZeroElementsInColumns_MatrixWithOnlyZeroElements_ShouldReturnRowCounts()
            {
                int[,] matrix = new int[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0 }
                };

                int[] expected = { 5, 5, 5, 5, 5, 5, 5 }; // Количество нулевых элементов в каждом столбце: 5, 5, 5, 5, 5, 5, 5
                int[] actual = MatrixUtils.CountZeroElementsInColumns(matrix);

                Assert.AreEqual(expected, actual);
            }

            // Тест 4: Матрица содержит только один нулевой элемент в каждом столбце
            [Test]
            public void Test_CountZeroElementsInColumns_MatrixWithSingleZeroElementInEachColumn_ShouldReturnSingleCounts()
            {
                int[,] matrix = new int[,]
                {
                    { 1, 2, 9, 3, 7, 4, 5 },
                    { 0, 0, 0, 0, 0, 0, 0 },
                    { 1, 2, 9, 3, 7, 4, 5 },
                    { 0, 0, 0, 0, 0, 0, 0 },
                    { 1, 2, 9, 3, 7, 4, 5 }
                };

                int[] expected = { 2, 2, 2, 2, 2, 2, 2 }; // Количество нулевых элементов в каждом столбце: 2, 2, 2, 2, 2, 2, 2
                int[] actual = MatrixUtils.CountZeroElementsInColumns(matrix);

                Assert.AreEqual(expected, actual);
            }

            // Тест 5: Матрица содержит только один нулевой элемент в первом столбце
            [Test]
            public void Test_CountZeroElementsInColumns_MatrixWithSingleZeroElementInFirstColumn_ShouldReturnSingleCountInFirstColumn()
            {
                int[,] matrix = new int[,]
                {
                    { 0, 2, 9, 3, 7, 4, 5 },
                    { 1, 6, 4, 2, 3, 8, 5 },
                    { 0, 2, 9, 3, 7, 4, 5 },
                    { 1, 6, 4, 2, 3, 8, 5 },
                    { 0, 2, 9, 3, 7, 4, 5 }
                };

                int[] expected = { 3, 0, 0, 0, 0, 0, 0 }; // Количество нулевых элементов в каждом столбце: 3, 0, 0, 0, 0, 0, 0
                int[] actual = MatrixUtils.CountZeroElementsInColumns(matrix);

                Assert.AreEqual(expected, actual);
            }
        }

        
    }
}
