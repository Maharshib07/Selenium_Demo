using System;

namespace Csharpconditional
{
    public class CondStatements
    {
        [Test]
        public void StatementIfString()
        {
            string sname = "AP";
            if (sname == "MH") 
            {
                Console.WriteLine("Capital city is mumbai");
            }
            else if (sname == "TS") 
            {
                Console.WriteLine("Capital city is hyderabad");
            }
            else if (sname == "GOA") 
            {
                Console.WriteLine("Capital city is panaji");
            }
            else if (sname == "AP")
            {
                Console.WriteLine("Capital city is Amaravathi");
            }
            else
            {
                Console.WriteLine("unknown capital");
            }
        }
        [Test]
        public void StatementIfInt()
        {
            int x = 55;
            if (x > 10 && x < 30)
            {
                Console.WriteLine("x is > 10 and < 30");
            }
            else if (x > 30 && x < 40)
            {
                Console.WriteLine("x is > 30 and x < 50");
            }
            else if (x > 50 && x < 70)
            {
                Console.WriteLine("x is > 50 and x < 70");
            }
            else
            {
                Console.WriteLine("x is :" + x);
            }
        }
        [Test]
        public void StatementSwitch()
        {
            int x = 55;
            switch (x)
            {
                case 20:
                    Console.WriteLine("X is 20");
                    break;
                case 30:
                    Console.WriteLine("X is 30");
                    break;
                case 40:
                    Console.WriteLine("X is 40");
                    break;
                case 45:
                    Console.WriteLine("X is 45");
                    break;
                default:
                    Console.WriteLine("X is:" + x);
                    break;
            }
        }
    }
}