using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using NUnit.Framework;
using System.Diagnostics.Metrics;
using System.Xml.Linq;

namespace CsharpCollections 
{
    public class Collections
    {

        [Test]
        public void ListCollectionString()
        {
            List<string> Students = new List<string>();
            Students.Add("Rishi");
            Students.Add("Rajesh");
            Students.Add("Ramesh");
            Students.Add("Rahul");
            Students.Add(null);
            Students.Add("Rishi");
            

            foreach (string student in Students)
            {
                Console.Write(student + " ");
            }

        }
        [Test]
        public void ArrayListCollectStrg()
        {
            ArrayList Nms = new ArrayList();

            Nms.Add("Raja");
            Nms.Add("Rakesh");
            Nms.Add(8);
            Nms.Add(null); //Num.Remove(" ");  .RemoveAt(int);  .RemoveRange(,);  .Clear();
            Nms.Add(8);

            for (int i = 0; i < Nms.Count; i++)
            {
                Console.Write(Nms[i] + "  ");
            }
            //Console.Write(Nms.Capacity);
        }
        [Test]
        public void HashCollection()
        {
            Hashtable Table = new Hashtable();

            Table.Add("Raja", "Rani");
            Table.Add("Rajesh", 5);
            Table.Add(28, 40);
            Table.Add('k', 5);

            if (Table.ContainsKey('k'))
            {
                Console.WriteLine("k assigned value is 5");
            }
        }
        [Test]
        public void DictCollection()
        {
            Dictionary<int, string> Dist = new Dictionary<int, string>();

            Dist.Add(5, "Sampath");
            Dist.Add(2, "Sami");
            Dist.Add(6, "Sahid");

            if (Dist.ContainsKey(2)) // checking the key exist or not,can access key without cheking also
            {
                Console.WriteLine("Name is : " + Dist[2]);  //Access by Key,can't access by key
            }
            if (Dist.TryGetValue(5, out string dist)) // Try getvalue usage
            {
                Console.WriteLine(dist);
            }
            Dist.Remove(2); // To Remove  key;

            foreach (var dict in Dist)
            {
                
                Console.WriteLine(value: $"{dict.Key} {dict.Value}");
            }
        }
        [Test]
        public void QueueCollection()
        {
            Queue<int> Que = new Queue<int>();

            Que.Enqueue(25);
            Que.Enqueue(45);
            Que.Enqueue(18);
            Que.Enqueue(72);

            Console.WriteLine("\nInitial Queue:");
            foreach (var que in Que)
            {
                Console.WriteLine(que);
            }

            // Dequeue elements from the queue (removing items from the front)
            Console.WriteLine("\nDequeueing elements:");
            while (Que.Count > 0)
            {
                int dequeuedque = Que.Dequeue();
                Console.WriteLine($"\nDequeued: {dequeuedque}");
            }

            // Check if the queue is empty after dequeue operations
            Console.WriteLine("\nQueue is empty: " + (Que.Count == 0));
        }
    }
    public class PratCollections
    {
        [Test]
        public void HashPractice()
        {
            Hashtable Books = new Hashtable();
            Books.Add(1, "Karthik");
            Books.Add('k', "Karthik"); // can key value be duplicate
            Books.Add("k", 'g');
            Books.Add(5, "San");
            Books.Add("Rama",null);  //key cant null, value be null
            Books.Add(1.5, null);


            foreach (DictionaryEntry dict in Books)
            {
                Console.WriteLine(value: $"{dict.Key}, {dict.Value}");
            }

        }
        [Test]
        public void DictPractice()
        {
            Dictionary<string, int> Books = new Dictionary<string, int>();
            Books.Add("Sanjay", 3);
            Books.Add("Karthik", 26);
            Books.Add("Sai", 25);  // cant key duplicate, value be duplicate
            Books.Add("Say", 8);
            Books.Add("Rama", 99);
            Books.Add("", 99);   // key value cant be null

            Console.WriteLine("Value associated with key Sai: " + Books["Sai"]);

            Console.WriteLine(Books.Count); // shows count

            Console.WriteLine(Books.ContainsKey("Sai")); //Boolen (check)

            foreach (var dict in Books)
            {
                Console.WriteLine(value: $"{dict.Key}, {dict.Value}");
            }
        }

    }
    public class LetterCounter
    {
        [Test]
        public void Dictpractice()
        {
            string name = "Maharshi";
            Dictionary<char, int> letterCount = new Dictionary<char, int>();

            foreach (var cont in name.ToLower())
            {
                if (char.IsLetter(cont)) // Ensuring only letters are counted
                {
                    if (letterCount.ContainsKey(cont))
                    {
                        letterCount[cont]++;
                    }
                    else
                    {
                        letterCount[cont] = 1;
                    }
                }
            }

            foreach (var item in letterCount)
            {
                Console.WriteLine($"Letter: {item.Key}, Count: {item.Value}");
            }
        }
        public void TestDictpractice()
        {
            LetterCounter counter = new LetterCounter();
            counter.Dictpractice();
        }

        
        public void NameCount(string Name)
        {
            
            Dictionary<char, int> LetterCount = new Dictionary<char, int>();

            foreach(var letter in Name.ToLower())
            {
                if (char.IsLetter(letter))
                {
                    if (LetterCount.ContainsKey(letter))
                    {
                        LetterCount[letter]++;
                    }
                    else
                    {
                        LetterCount[letter] = 1;
                    }
                }

            }
            foreach(var item in LetterCount)
            {
                Console.WriteLine($"Letter : {item.Key}, Count : {item.Value}");
            }
        }
        [Test]
        public void Letter()
        {
            LetterCounter nam = new LetterCounter();
            nam.NameCount("B.M.MahA12rshi");

        }
    }
}