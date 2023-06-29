using System;
using Lab3Variant01;
using NUnit.Framework;

namespace Lab3Variant01.Tests
{
    //задача 1
     public class MathUtils
    {
        public static int SumOfDigits(int x)
        {
            int tensDigit = x / 10;
            int unitsDigit = x % 10;
            return tensDigit + unitsDigit;
        }
    }
    //тестовые методы
    [TestFixture]
    public class MathUtilsTests
    {
        [Test]
        public void SumOfDigits_Input47_Returns11()
        {
            int result = MathUtils.SumOfDigits(47);
            Assert.AreEqual(11, result);
        }

        [Test]
        public void SumOfDigits_Input99_Returns18()
        {
            int result = MathUtils.SumOfDigits(99);
            Assert.AreEqual(18, result);
        }
    }

   //задача 2
    public class PrimeNumberUtils
    {
        public static string IsPrime(int number)
        {
            if (number <= 1)
                return "Составное число";
            if (number == 2)
                return "Простое число";
            if (number % 2 == 0)
                return "Составное число";

            int sqrt = (int)Math.Sqrt(number);
            for (int i = 3; i <= sqrt; i += 2)
            {
                if (number % i == 0)
                    return "Составное число";
            }

            return "Простое число";
        }
    }
    //тестовые методы
    [TestFixture]
    public class PrimeNumberUtilsTests
    {
        [Test]
        public void IsPrime_Input2_ReturnsPrimeNumber()
        {
            string result = PrimeNumberUtils.IsPrime(2);
            Assert.AreEqual("Простое число", result);
        }

        [Test]
        public void IsPrime_Input9_ReturnsCompositeNumber()
        {
            string result = PrimeNumberUtils.IsPrime(9);
            Assert.AreEqual("Составное число", result);
        }

        [Test]
        public void IsPrime_Input17_ReturnsPrimeNumber()
        {
            string result = PrimeNumberUtils.IsPrime(17);
            Assert.AreEqual("Простое число", result);
        }
    }

    
}
