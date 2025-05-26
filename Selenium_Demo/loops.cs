using Microsoft.VisualStudio.TestPlatform.CoreUtilities.Extensions;
using System;

namespace CsharpLoops
{
    public class loops
    {
        [Test]
        public void ForLoopInt()
        {
            int x = 10;
            for (x = 0; x <= 10; x++)
            {
                
              if(x==6)
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
                if (bikes[i]=="Model")
                {
                    Console.WriteLine("Kicking :" + bikes[i]);
                    continue;
                }
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
    }
    

}
