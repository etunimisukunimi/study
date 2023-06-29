using System;
using NUnit.Framework;
using Lab6Variant01;
namespace Lab6Variant01
{

    public class MatrixOperations
    {
        private const int MatrixSize = 10;
        private const int LeftHalfColumns = MatrixSize / 2;
        private const int ShadedRows = MatrixSize / 2;
        private const int ShadedColumns = MatrixSize - LeftHalfColumns;

        public int[,] CreateMatrix()
        {
            int[,] matrix = new int[MatrixSize, MatrixSize];

            Console.WriteLine($"Enter {MatrixSize}x{MatrixSize} matrix elements:");
            for (int i = 0; i < MatrixSize; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                for (int j = 0; j < MatrixSize; j++)
                {
                    matrix[i, j] = int.Parse(input[j]);
                }
            }

            return matrix;
        }
        //задача 1
        public int GetSumOfPositiveElements(int[,] matrix)
        {
            int sum = 0;

            for (int i = 0; i < ShadedRows; i++)
            {
                for (int j = LeftHalfColumns; j < MatrixSize; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        sum += matrix[i, j];
                    }
                }
            }

            return sum;
        }
        //задача 2
        public int[] GetElementsLessThanMinusThree(int[,] matrix)
        {
            int[] elements = new int[ShadedRows * ShadedColumns];
            int index = 0;

            for (int i = 0; i < ShadedRows; i++)
            {
                for (int j = LeftHalfColumns; j < MatrixSize; j++)
                {
                    if (matrix[i, j] < -3)
                    {
                        elements[index] = matrix[i, j];
                        index++;
                    }
                }
            }

            Array.Resize(ref elements, index);

            return elements;
        }
        //задача 3
        public int[] GetNegativeElementsCountPerRow(int[,] matrix)
        {
            int[] counts = new int[ShadedRows];

            for (int i = 0; i < ShadedRows; i++)
            {
                for (int j = LeftHalfColumns; j < MatrixSize; j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        counts[i]++;
                    }
                }
            }

            return counts;
        }
        // задача 4
        public int GetMinimumNegativeElementInLeftHalf(int[,] matrix)
        {
            int minNegativeElement = int.MaxValue;

            for (int i = 0; i < MatrixSize; i++)
            {
                for (int j = 0; j < LeftHalfColumns; j++)
                {
                    if (matrix[i, j] < 0 && matrix[i, j] < minNegativeElement)
                    {
                        minNegativeElement = matrix[i, j];
                    }
                }
            }

            return minNegativeElement == int.MaxValue ? 0 : minNegativeElement;
        }
    }
}

namespace Lab6Variant01.Tests
{
    [TestFixture]
    public class Lab6Variant01Tests
    {

        //тестовые методы для задачи 1

        [Test]
        public void Test_GetSumOfPositiveElements_ShouldReturnZero_WhenMatrixHasNoPositiveElements()
        {
            // Тестовая матрица без положительных элементов
            int[,] matrix = new int[,]
            {
                { -1, -2, -3, -4, -5, -6, -7, -8, -9, -10 },
                { -11, -12, -13, -14, -15, -16, -17, -18, -19, -20 },
                { -21, -22, -23, -24, -25, -26, -27, -28, -29, -30 },
                { -31, -32, -33, -34, -35, -36, -37, -38, -39, -40 },
                { -41, -42, -43, -44, -45, -46, -47, -48, -49, -50 },
                { -51, -52, -53, -54, -55, -56, -57, -58, -59, -60 },
                { -61, -62, -63, -64, -65, -66, -67, -68, -69, -70 },
                { -71, -72, -73, -74, -75, -76, -77, -78, -79, -80 },
                { -81, -82, -83, -84, -85, -86, -87, -88, -89, -90 },
                { -91, -92, -93, -94, -95, -96, -97, -98, -99, -100 }
            };

            MatrixOperations matrixOperations = new MatrixOperations();
            int expectedSum = 0;
            int actualSum = matrixOperations.GetSumOfPositiveElements(matrix);

            Assert.AreEqual(expectedSum, actualSum);
        }

        [Test]
        public void Test_GetSumOfPositiveElements_ShouldReturnSumOfPositiveElements()
        {
            // Тестовая матрица с положительными элементами
            int[,] matrix = new int[,]
            {
                { 1, -2, 3, -4, 5, -6, 7, -8, 9, -10 },
                { -11, 12, -13, 14, -15, 16, -17, 18, -19, 20 },
                { 21, -22, 23, -24, 25, -26, 27, -28, 29, -30 },
                { -31, 32, -33, 34, -35, 36, -37, 38, -39, 40 },
                { 41, -42, 43, -44, 45, -46, 47, -48, 49, -50 },
                { -51, 52, -53, 54, -55, 56, -57, 58, -59, 60 },
                { 61, -62, 63, -64, 65, -66, 67, -68, 69, -70 },
                { -71, 72, -73, 74, -75, 76, -77, 78, -79, 80 },
                { 81, -82, 83, -84, 85, -86, 87, -88, 89, -90 },
                { -91, 92, -93, 94, -95, 96, -97, 98, -99, 100 }
            };

            MatrixOperations matrixOperations = new MatrixOperations();
            int expectedSum = 1715; // Сумма положительных элементов: 1 + 3 + 5 + ... + 99 = 1715
            int actualSum = matrixOperations.GetSumOfPositiveElements(matrix);

            Assert.AreEqual(expectedSum, actualSum);
        }

        // Дополнительные тестовые методы для полного покрытия возможных случаев

        [Test]
        public void Test_GetSumOfPositiveElements_ShouldReturnZero_WhenMatrixIsEmpty()
        {
            // Пустая матрица
            int[,] matrix = new int[10, 10];

            MatrixOperations matrixOperations = new MatrixOperations();
            int expectedSum = 0;
            int actualSum = matrixOperations.GetSumOfPositiveElements(matrix);

            Assert.AreEqual(expectedSum, actualSum);
        }

        [Test]
        public void Test_GetSumOfPositiveElements_ShouldReturnZero_WhenMatrixHasNoElements()
        {
            // Матрица без элементов
            int[,] matrix = new int[10, 10];

            MatrixOperations matrixOperations = new MatrixOperations();
            int expectedSum = 0;
            int actualSum = matrixOperations.GetSumOfPositiveElements(matrix);

            Assert.AreEqual(expectedSum, actualSum);
        }

        [Test]
        public void Test_GetSumOfPositiveElements_ShouldReturnZero_WhenMatrixHasNoPositiveElements()
        {
            // Матрица без положительных элементов
            int[,] matrix = new int[,]
            {
                { -1, -2, -3, -4, -5, -6, -7, -8, -9, -10 },
                { -11, -12, -13, -14, -15, -16, -17, -18, -19, -20 },
                { -21, -22, -23, -24, -25, -26, -27, -28, -29, -30 },
                { -31, -32, -33, -34, -35, -36, -37, -38, -39, -40 },
                { -41, -42, -43, -44, -45, -46, -47, -48, -49, -50 },
                { -51, -52, -53, -54, -55, -56, -57, -58, -59, -60 },
                { -61, -62, -63, -64, -65, -66, -67, -68, -69, -70 },
                { -71, -72, -73, -74, -75, -76, -77, -78, -79, -80 },
                { -81, -82, -83, -84, -85, -86, -87, -88, -89, -90 },
                { -91, -92, -93, -94, -95, -96, -97, -98, -99, -100 }
            };

            MatrixOperations matrixOperations = new MatrixOperations();
            int expectedSum = 0;
            int actualSum = matrixOperations.GetSumOfPositiveElements(matrix);

            Assert.AreEqual(expectedSum, actualSum);
        }



        //тестовые методы для задачи 2
        
        [Test]
        public void Test_GetElementsLessThanNegativeThree_ShouldReturnEmptyArray_WhenNoElementsAreLessThanNegativeThree()
        {
            // Тестовая матрица без элементов меньше -3
            int[,] matrix = new int[,]
            {
                { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 },
                { 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 },
                { 31, 32, 33, 34, 35, 36, 37, 38, 39, 40 },
                { 41, 42, 43, 44, 45, 46, 47, 48, 49, 50 },
                { 51, 52, 53, 54, 55, 56, 57, 58, 59, 60 },
                { 61, 62, 63, 64, 65, 66, 67, 68, 69, 70 },
                { 71, 72, 73, 74, 75, 76, 77, 78, 79, 80 },
                { 81, 82, 83, 84, 85, 86, 87, 88, 89, 90 },
                { 91, 92, 93, 94, 95, 96, 97, 98, 99, 100 }
            };

            MatrixOperations matrixOperations = new MatrixOperations();
            int[] expectedArray = new int[0];
            int[] actualArray = matrixOperations.GetElementsLessThanNegativeThree(matrix);

            CollectionAssert.AreEqual(expectedArray, actualArray);
        }

        [Test]
        public void Test_GetElementsLessThanNegativeThree_ShouldReturnArrayWithElementsLessThanNegativeThree()
        {
            // Тестовая матрица с элементами меньше -3
            int[,] matrix = new int[,]
            {
                { 1, -2, -3, 4, 5, -6, 7, -8, -9, 10 },
                { -11, 12, -13, 14, -15, 16, -17, 18, 19, 20 },
                { -21, 22, -23, 24, -25, -26, 27, -28, 29, 30 },
                { 31, -32, -33, -34, 35, 36, 37, 38, 39, 40 },
                { 41, 42, 43, -44, 45, -46, 47, 48, 49, 50 },
                { 51, -52, 53, 54, 55, 56, -57, 58, -59, 60 },
                { 61, -62, 63, -64, 65, -66, 67, -68, 69, -70 },
                { -71, 72, -73, 74, -75, 76, -77, 78, -79, 80 },
                { 81, -82, 83, 84, 85, -86, 87, -88, 89, -90 },
                { -91, 92, -93, -94, -95, 96, -97, -98, -99, -100 }
            };

            MatrixOperations matrixOperations = new MatrixOperations();
            int[] expectedArray = new int[] { -2, -3, -6, -8, -9, -11, -13, -15, -17, -21, -23, -25, -26, -28, -32, -33, -34, -44, -46, -52, -57, -59, -62, -64, -66, -68, -71, -73, -75, -77, -79, -82, -86, -88, -90, -91, -93, -94, -95, -97, -98, -99, -100 };
            int[] actualArray = matrixOperations.GetElementsLessThanNegativeThree(matrix);

            CollectionAssert.AreEqual(expectedArray, actualArray);
        }

        [Test]
        public void Test_GetElementsLessThanNegativeThree_ShouldReturnEmptyArray_WhenMatrixIsEmpty()
        {
            // Пустая матрица
            int[,] matrix = new int[10, 10];

            MatrixOperations matrixOperations = new MatrixOperations();
            int[] expectedArray = new int[0];
            int[] actualArray = matrixOperations.GetElementsLessThanNegativeThree(matrix);

            CollectionAssert.AreEqual(expectedArray, actualArray);
        }

        [Test]
        public void Test_GetElementsLessThanNegativeThree_ShouldReturnEmptyArray_WhenMatrixHasNoElements()
        {
            // Матрица без элементов
            int[,] matrix = new int[10, 10];

            MatrixOperations matrixOperations = new MatrixOperations();
            int[] expectedArray = new int[0];
            int[] actualArray = matrixOperations.GetElementsLessThanNegativeThree(matrix);

            CollectionAssert.AreEqual(expectedArray, actualArray);
        }

        [Test]
        public void Test_GetElementsLessThanNegativeThree_ShouldReturnEmptyArray_WhenMatrixHasNoElementsLessThanNegativeThreeInStrippedArea()
        {
            // Матрица без элементов меньше -3 в заштрихованной области
            int[,] matrix = new int[,]
            {
                { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 },
                { 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 },
                { 31, 32, 33, 34, 35, 36, 37, 38, 39, 40 },
                { 41, 42, 43, 44, 45, 46, 47, 48, 49, 50 },
                { 51, 52, 53, 54, 55, 56, 57, 58, 59, 60 },
                { 61, 62, 63, 64, 65, 66, 67, 68, 69, 70 },
                { 71, 72, 73, 74, 75, 76, 77, 78, 79, 80 },
                { 81, 82, 83, 84, 85, 86, 87, 88, 89, 90 },
                { 91, 92, 93, 94, 95, 96, 97, 98, 99, 100 }
            };

            MatrixOperations matrixOperations = new MatrixOperations();
            int[] expectedArray = new int[0];
            int[] actualArray = matrixOperations.GetElementsLessThanNegativeThree(matrix);

            CollectionAssert.AreEqual(expectedArray, actualArray);
        }


        //тестовые методы для задачи 3
        [Test]
        public void Test_GetNegativeElementCounts_ShouldReturnArrayWithZeroCounts_WhenMatrixHasNoNegativeElements()
        {
            // Тестовая матрица без отрицательных элементов
            int[,] matrix = new int[,]
            {
                { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 },
                { 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 },
                { 31, 32, 33, 34, 35, 36, 37, 38, 39, 40 },
                { 41, 42, 43, 44, 45, 46, 47, 48, 49, 50 },
                { 51, 52, 53, 54, 55, 56, 57, 58, 59, 60 },
                { 61, 62, 63, 64, 65, 66, 67, 68, 69, 70 },
                { 71, 72, 73, 74, 75, 76, 77, 78, 79, 80 },
                { 81, 82, 83, 84, 85, 86, 87, 88, 89, 90 },
                { 91, 92, 93, 94, 95, 96, 97, 98, 99, 100 }
            };

            MatrixOperations matrixOperations = new MatrixOperations();
            int[] expectedCounts = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int[] actualCounts = matrixOperations.GetNegativeElementCounts(matrix);

            CollectionAssert.AreEqual(expectedCounts, actualCounts);
        }

        [Test]
        public void Test_GetNegativeElementCounts_ShouldReturnArrayWithCountsOfNegativeElementsInEachRow()
        {
            // Тестовая матрица с отрицательными элементами
            int[,] matrix = new int[,]
            {
                { 1, -2, -3, 4, 5, -6, 7, -8, -9, 10 },
                { -11, 12, -13, 14, -15, 16, -17, 18, 19, 20 },
                { -21, 22, -23, 24, -25, -26, 27, -28, 29, 30 },
                { 31, -32, -33, -34, 35, 36, 37, 38, 39, 40 },
                { 41, 42, 43, -44, 45, -46, 47, 48, 49, -50 },
                { -51, -52, 53, 54, 55, 56, -57, 58, -59, 60 },
                { 61, -62, 63, -64, 65, -66, 67, -68, 69, -70 },
                { -71, 72, -73, 74, -75, 76, -77, 78, -79, 80 },
                { 81, -82, 83, 84, 85, -86, 87, -88, 89, -90 },
                { -91, 92, -93, -94, -95, 96, -97, -98, -99, -100 }
            };

            MatrixOperations matrixOperations = new MatrixOperations();
            int[] expectedCounts = new int[10] { 4, 6, 8, 2, 5, 5, 6, 6, 6, 9 };
            int[] actualCounts = matrixOperations.GetNegativeElementCounts(matrix);

            CollectionAssert.AreEqual(expectedCounts, actualCounts);
        }

        [Test]
        public void Test_GetNegativeElementCounts_ShouldReturnArrayWithZeroCounts_WhenMatrixIsEmpty()
        {
            // Пустая матрица
            int[,] matrix = new int[10, 10];

            MatrixOperations matrixOperations = new MatrixOperations();
            int[] expectedCounts = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int[] actualCounts = matrixOperations.GetNegativeElementCounts(matrix);

            CollectionAssert.AreEqual(expectedCounts, actualCounts);
        }

        [Test]
        public void Test_GetNegativeElementCounts_ShouldReturnArrayWithZeroCounts_WhenMatrixHasNoElements()
        {
            // Матрица без элементов
            int[,] matrix = new int[10, 10];

            MatrixOperations matrixOperations = new MatrixOperations();
            int[] expectedCounts = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int[] actualCounts = matrixOperations.GetNegativeElementCounts(matrix);

            CollectionAssert.AreEqual(expectedCounts, actualCounts);
        }

        [Test]
        public void Test_GetNegativeElementCounts_ShouldReturnArrayWithZeroCounts_WhenMatrixHasNoNegativeElementsInStrippedArea()
        {
            // Матрица без отрицательных элементов в заштрихованной области
            int[,] matrix = new int[,]
            {
                { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 },
                { 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 },
                { 31, 32, 33, 34, 35, 36, 37, 38, 39, 40 },
                { 41, 42, 43, 44, 45, 46, 47, 48, 49, 50 },
                { 51, 52, 53, 54, 55, 56, 57, 58, 59, 60 },
                { 61, 62, 63, 64, 65, 66, 67, 68, 69, 70 },
                { 71, 72, 73, 74, 75, 76, 77, 78, 79, 80 },
                { 81, 82, 83, 84, 85, 86, 87, 88, 89, 90 },
                { 91, 92, 93, 94, 95, 96, 97, 98, 99, 100 }
            };

            MatrixOperations matrixOperations = new MatrixOperations();
            int[] expectedCounts = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int[] actualCounts = matrixOperations.GetNegativeElementCounts(matrix);

            CollectionAssert.AreEqual(expectedCounts, actualCounts);
        }




    }

}