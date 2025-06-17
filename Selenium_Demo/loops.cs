using Microsoft.VisualStudio.TestPlatform.CoreUtilities.Extensions;
using System;

namespace CsharpLoops
{
    public class Looops
    {
        [Test]
        public void ForLoopInt()
        {
            int x = 10;
            for (x = 0; x <= 10; x++)
            {

                if (x == 6)
                {
                    Console.WriteLine("\nBreaking at :" + x);
                    break;
                }
                Console.WriteLine("\nNumbers are :" + x);
            }
        }
        [Test]
        public void ForLoopString()
        {
            string[] bikes = new string[4]; //{ "Colour", "Model", "Brand", "Mileage" };
            bikes[0] = "Colour";
            bikes[1] = "Model";
            bikes[2] = "Brand";
            bikes[3] = "Mileage";

            for (int i = 0; i < bikes.Length; i++)
            {
                if (bikes[i] == "Model")
                {
                    Console.WriteLine("Kicking :" + bikes[i]);
                    continue;
                }
                Console.WriteLine(bikes[i]);
                // Console.WriteLine(bikes[i]);
            }
        }
        [Test]
        public void ForeachLoopstring()
        {
            string[] cars = new string[3] { "Brand", "Price", "Colour" };
            foreach (string v in cars)
            {
                Console.WriteLine(v);
            }
        }

        [Test]
        public void Whileloopoint()
        {
            int[] numbers = { 1, 3, 5, 6, 10 };
            int i = 0;
            while ( i <numbers.Length)
            {
                Console.Write(numbers[i]+", "); i++;
            }
        }
        [Test]
        public void whileloopstring()
        {
            string[] str = { "Ram", "Raj", "Rakesh", "Roy" };
            int i = 0;
            do
            {
                Console.Write(str[i] + " "); i++;
            }
            while (i < str.Length);

        }
    }
    public class MethodRecall()
    {
        public void ageofstud(int snum)
        {

            if (snum == 10)
            {
                Console.WriteLine(" Anand age : 40");
            }
            else if (snum == 20)
            {
                Console.WriteLine(" Sai age : 25");
            }
            else if (snum == 30)
            {
                Console.WriteLine("Anvesh age : 9");
            }
            else
            {
                Console.WriteLine("Asha age : 0");
            }
        }
    }
    public class MethodRecalls()
    {
        [Test]
        public void ageofperson()
        {
            MethodRecall tests = new MethodRecall();
            tests.ageofstud(40);
        }
    }
    public class Methodrrecall()
    {
        public int Ray(string Name)
        {
            Name = Name.ToLower();

            if (Name == "anand") return 40;
            else if (Name == "sai") return 25;
            else if (Name == "anvesh") return 9;
            else if (Name == "asha") return 0;
            else return 0;

        }
        [Test]
        public void Rays()
        {
            Methodrrecall roy = new Methodrrecall();
            int result = roy.Ray("anand");

        }
    }
    class Primeselect
    {
        [Test]
        public void Prm()
        { 
            int[] numbers = { 12, 52, 23, 7, 6 };

            List<int> primeNumbers = new List<int>();

            foreach (int num in numbers)
            {
                if (IsPrime(num))
                {
                    primeNumbers.Add(num);
                }
            }

            Console.WriteLine("Prime numbers:"); // print primenumbers
            foreach (int prime in primeNumbers)
            {
                Console.WriteLine(prime);
            }
        }
        static bool IsPrime(int num) // checking the number are prime 
        {
            if (num <= 1) return false; // 0 and 1 are not prime
            if (num == 2) return true;  // 2 is prime

            // Only check for factors up to the square root of the number
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0) return false; // Divisible, so not prime
            }

            return true;
        }
    }

}
