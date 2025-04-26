using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.ConstrainedExecution;
using NUnit.Framework;
using System.Security.Cryptography.X509Certificates;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium.DevTools.V131.Browser;

namespace CsharpOOps
{
    public interface IAnimal
    {
        public void animalSound(); // interface method (does not have a body)
    }

    // Pig "implements" the IAnimal interface
    public class InterfPig : IAnimal
    {
        
        public void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The pig says: wee wee");
        }
    }
    public class InterfProgram
    {
        [Test]
        public void aniSon()
        {
            InterfPig myPig = new InterfPig();  // Create a Pig object
            myPig.animalSound();
        }
    }


    public class InheVechile
    {
        public string brand = "Ford";  // method Field
        public void Sound()              // method
        {
            Console.WriteLine("Zu.. Zuu..");
        }
    }
    public class carU : InheVechile
    {
        public string model = "Mustang";

    }
    public class InhePze
    {
        [Test]
        public void MaiInhe()
        {
            carU ncar = new carU();
            ncar.Sound();
            {
                Console.WriteLine(ncar.brand + " " + ncar.model);
            }
        }
    }


    public abstract class Ani
    {
        public abstract void anison();
        public void anisle()
        {
            Console.WriteLine("Zee");
        }
    }
    public class AbsCow : Ani
    {
        
        public override void anison()
        {
            Console.WriteLine("Aa..");
        }
    }
    public class Absprog
    {
        [Test]
        public void Ma()
        {
            AbsCow mycow = new AbsCow();
            mycow.anisle();
            mycow.anison();
        }

    }


    public class Programs
    {
       
        public int Ad(int x, int y)
        {
            return x + y;
        }
        
        public int Ad(int x, int y, int z)
        {
            return x + y + z;
        }
        
    }
    public class overloadProgram
    {
        [Test]
        public void add()
        {
            Programs pro = new Programs();
            Console.WriteLine(pro.Ad(25, 30));

        }
    }



    public class Areas
    {

        //public object Math { get; internal set; }
        public virtual double Are()
        { return 0; }
    }
    public class Cir : Areas
    {
        public double rad { get; set; }
        public Cir()
        {
            rad = 7;
        }
        public override double Are()
        {
            return ((3.14) * (7 ^ 2));

        }
    }
    public class Sq : Areas
    {
        public double length { get; set; }
        public Sq()
        {
            length = 7;     // if rec ht,width
        }
        public override double Are()
        {
            return 7 ^ 2; // 
        }
    }
    public class overrideSum
    {
        [Test]
        public void Sums()
        {
            Areas cir = new Cir();
            Console.WriteLine("Area: " + cir.Are());
            Areas sq = new Sq();
            Console.WriteLine("Area :" + sq.Are());
        }  
    }
    class PhoneNum
    {
        private long phnNO = 23456789;
        public long PNo
        {
            get { return phnNO; }
            set
            {
                if (value > 1000000000 && value < 9999999999)
                { phnNO = value; }
                else
                {
                    Console.WriteLine("Invalid PHNo.. Enter Correct Phone Number\n Default Num Is :");
                }
            }
        }
    }
    class Encapsculation
    {
        [Test]
        public static void Number()
        {
            PhoneNum Num = new PhoneNum();
            Num.PNo = 6575159896;
            Console.WriteLine(Num.PNo);
           
        }
    }
}
