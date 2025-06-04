using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Reflection;

namespace CsharpArray
{
    public class Arrays
    {
        [Test]
        public void SingleDArrays()
        {
            string[] News = new string[] { "Raju", "Raja", "Rocky" };  //News.Sort

            for (int i = 0; i < News.Length; i++)   //int ind = Array.BinarySearch(News, "Raj"); sortT(News, ind);
            {
                Console.WriteLine(News[1]);
                Console.WriteLine(News[0] + "  " + News[2]);
            }
        }
        [Test]
        public void directAssignaray()
        {
            int[] arry = { 1, 2, 3, 4, 5 };

            int i = 1;
            while (i < arry.Length)
            {
                Console.Write(arry[i] + " "); i++;
            }
        }
        [Test]
        public void DoubleDArray()
        {
            string[,] Nes = new string[2, 3] { { "Raju", "Raja", "Ray" }, { "Raji", "Rani", "Roy" } };
            {
                Console.WriteLine(Nes[0, 0] + "  " + Nes[1, 2]);
            }
        }
        [Test]
        public void MultiArray3d()
        {
            string[,,] Multi = new string[2, 3, 4]   //2Boxes , 3Rows  , 4Colums
            {
                    {
                      {"A1","B1","C1","D1"},
                      {"A2","B2","C2","D2"},
                      {"A3","B3","C3","D3"}
                    },

                    {
                        {"P1","Q1","R1","S1" },
                        {"P2","Q2","R2","S2" },
                        {"P3","Q3","R3","S3" }
                    },
            };

            Console.Write("Array[1,2,3] :" + Multi[1, 2, 3]); //Follows Index
        }
    }
    public class PracticeCond
    {
        [Test]
        public void ForIntStatement()
        {
            for (int i = 0; i <= 100; i++) 
            {
                Console.Write(i+",");
            }
        }
        [Test]
        public void Ifstringstatement()
        {
            string[] Name = { "Ram","raju", "rajesh" };

            for (int i=0; i<Name.Length;i++)
            {
                if (Name[i] =="raju")
                {
                    Console.WriteLine(Name[i]);
                    break;
                }
                //else
                //{
                //    Console.WriteLine("Null");
                //}


            }
        }
        [Test]
        public void IfIntstatement()
        {
            int[] Num = {2,6,8 };

            foreach (int nam in Num)
            {
                if (nam == 6)
                {
                    Console.WriteLine(nam);
                    break;
                }
                //else
                //{
                //    Console.WriteLine("Null");
                //}


            }



        }


    }
}
