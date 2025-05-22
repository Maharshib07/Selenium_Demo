using System;
using System.IO;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OfficeOpenXml;
using System.Globalization;
//using NUnit.Framework.Interfaces; // EPPlus for Excel handling

namespace Selenium_Demo
{
    public class ReadExcel
    {
        private IWebDriver driver;
        private string excelFilePath = @"C:\Users\Lenovo\Documents\Xpath_techtutorialz.xlsx";

        [SetUp]
        public void Setup()
        {
            // Ensure the Excel file exists
            Assert.IsTrue(File.Exists(excelFilePath), "Excel file does not exist: " + excelFilePath);
            // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            // Initialize ChromeDriver
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void TestdataFromExcel()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial; // Required for EPPlus 5+

            var fileInfo = new FileInfo(excelFilePath);

            using (var package = new ExcelPackage(fileInfo))
            {
                var worksheet = package.Workbook.Worksheets[0]; // Get first worksheet
                var rowCount = worksheet.Dimension?.Rows ?? 0; // Safe null handling

                Assert.Greater(rowCount, 1, "Excel file should have at least one data row.");

                for (int row = 2; row <= rowCount; row++) // Assuming first row is headers
                {

                    var searchQuery1 = worksheet.Cells[row, 1].Text; // Read search term from column 1
                    var searchQuery2 = worksheet.Cells[row, 2].Text; // Read search term from column 2
                    Assert.IsNotEmpty(searchQuery1, searchQuery1, $"Search term in row {row} is empty!");

                    Console.WriteLine($"Elements and there Xpaths : {searchQuery1}   :   {searchQuery2}");

                    //// Open Google and search
                    //driver.Navigate().GoToUrl("https://www.memonotepad.com/");
                    //var searchBox = driver.FindElement(By.Id("notes"));
                    //searchBox.SendKeys(searchQuery1 );
                    //searchBox.SendKeys(Keys.Enter);

                    // Wait for results to load
                    System.Threading.Thread.Sleep(2000); // Better to use WebDriverWait in real tests

                    // Verify results are displayed
                    var results = driver.FindElements(By.CssSelector("h3"));
                    //Assert.IsTrue(results.Count > 0, "No search results found!");

                    //  Console.WriteLine($"Search successful for: {searchQuery1}");
                }
            }
        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit(); // Close browser
            driver.Dispose();
        }

    }
    public class readExcell
    {
        private IWebDriver driver;
        private string excelFilePath = @"C:\Users\Lenovo\OneDrive\Documents\US-539,568-RishiBadiganti8.xlsx";

        [SetUp]
        public void Setup()
        {
            Assert.IsTrue(File.Exists(excelFilePath), "Excel file does not exist: " + excelFilePath);
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void DataFromExcell()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            var fileInfo = new FileInfo(excelFilePath);

            using (var package = new ExcelPackage(fileInfo))
            {
                var worksheet = package.Workbook.Worksheets[0];
                var rowCount = worksheet.Dimension?.Rows ?? 0;

                Console.WriteLine("Reading test data from Excel:\n");
                Assert.Greater(rowCount, 1, "Excel file should have at least one data row.");

                for (int row = 2; row <= rowCount; row++)
                {
                    var searchQuery1 = worksheet.Cells[row, 1].Text.Trim();
                    var searchQuery2 = worksheet.Cells[row, 2].Text.Trim();
                    var searchQuery3 = worksheet.Cells[row, 3].Text.Trim();
                    var searchQuery4 = worksheet.Cells[row, 4].Text.Trim();

                    if (!string.IsNullOrEmpty(searchQuery1) ||
                        !string.IsNullOrEmpty(searchQuery2) ||
                        !string.IsNullOrEmpty(searchQuery3) ||
                        !string.IsNullOrEmpty(searchQuery4))
                    {
                        Console.WriteLine($"List: {searchQuery1} | Action: {searchQuery2} | Expected: {searchQuery3} | Actual: {searchQuery4}");
                    }
                }
            }
        }

        [TearDown]
        public void TearDownn()
        {
            Thread.Sleep(2000);
            driver.Quit();
            driver.Dispose();
        }
    }


    public class SentenceSplit
    {
        [Test]
        public void BreakingSentence()
        {
            string sentence = " Hi my name  a is  Maharshi  ";

            // string Trim = sentence.Trim();
            string sen = sentence.ToLower();
            Console.WriteLine(sen);

            string[] Split = sen.Split(" ");


            foreach (var split in Split)
            {
                if (split.Length > 0)
                {
                    string capital = char.ToUpper(split[0]) + split.Substring(1) + " ";
                    Console.Write(capital);
                }
            }

            //foreach (var spy in Split)
            //{
            //    string output = " ";
            //    for (int i = 0; i < spy.Length; i++)
            //    {
            //        if (i % 2 != 0)
            //        { output = (" " + char.ToUpper(spy[i]) + spy.Substring(1)); }
            //        // else { output =(char.ToLower(spy[i]) + spy.Substring(1) + " ");}

            //        Console.WriteLine(output);
            //    }
            //}
        }
        [Test]
        public void ReverseString()
        {
            string name = "Maharshi";
            char[] reverse = name.ToCharArray();
            string Reversename = "";

            for (int i = reverse.Length - 1; i >= 0; i--)
            {
                Reversename += reverse[i];
            }

            Console.WriteLine(Reversename);

            Console.WriteLine(name.Reverse().ToArray());
        }
        [Test]
        public void String()
        {
            string Name = "Markandeya";
            Console.WriteLine(Name.Length);
            Console.WriteLine(Name.Substring(1, 6));
            Console.WriteLine(Name.Replace('a', 'o'));
            Console.WriteLine(Name.IndexOf('r'));

            string name = "Maharshi";
            Console.WriteLine(Name.CompareTo(name));
            Console.WriteLine(name.Contains("Markan"));

            Assert.IsTrue(Name.Contains("rkandeya"), "Name doesnt contains ");
        }
        [Test]
        public void Palindrom()
        {
            string name = "LamaL";
            name = name.ToUpper();
            int left = 0;
            int right = name.Length - 1;
            bool palindrom = true;

            while (left < right)
            {
                if (name[left] != name[right])
                {
                    palindrom = false;
                    break;
                }
                left++;
                right--;
            }
            if (palindrom)
            {
                Console.WriteLine(name + " is palindrom");
            }
            else
            {
                Console.WriteLine(name + " is not palindrom");
            }

        }
        [Test]
        public void Vowels()
        {
            string Name = "MaharshiMarkandeya";
            int Vowelsinwordcont = 0;

            foreach (char nam in Name.ToLower())
            {
                if ("aeiou".Contains(nam))
                {
                    Vowelsinwordcont++;
                }

            }
            Console.WriteLine("Vowelscount in a word :" + Vowelsinwordcont);

        }
       
            [Test]
            public void Words()
            {
                string input = "Hi!  my name is Maharshi";

                // Use TextInfo to capitalize each word
                TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
                string result = textInfo.ToTitleCase(input.ToLower());

                Console.WriteLine(result);
            }
            [Test]
            public void Word2()
            {
                string input = "Hi! my name is Maharshi";
                string rang = input.ToLower();
                string[] words = rang.Split(' ');

                string result = "";

                foreach (string word in words)
                {
                    if (word.Length > 0)
                    {
                        // Capitalize first character, keep rest as is
                        string capitalized = char.ToUpper(word[0]) + word.Substring(1);
                        result += capitalized + " ";
                    }
                    //else
                    //{
                    //    // Preserve multiple spaces
                    //    result += " ";
                    //}
                }
                // Trim any extra space at the end
                result = result.TrimEnd();

                Console.WriteLine(result);
            }
    }
    public class ExcelReaders
    {
        public static List<string[]> ReadExcel(string filePath)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            var data = new List<string[]>();

            FileInfo fileInfo = new FileInfo(filePath);
            using (var package = new ExcelPackage(fileInfo))
            {
                var worksheet = package.Workbook.Worksheets[0];
                int rowCount = worksheet.Dimension.Rows;
                int colCount = worksheet.Dimension.Columns;

                for (int row = 2; row <= rowCount; row++) // assuming first row is header
                {
                    string[] rowData = new string[colCount];
                    for (int col = 1; col <= colCount; col++)
                    {
                        rowData[col - 1] = worksheet.Cells[row, col].Text;
                    }
                    data.Add(rowData);
                }
            }
            return data;
        }
    }
    public class ExcelDataTest
    {
        [Test]
        public void ReadExcelDataTest()
        {
            string path = @"C:\Users\Lenovo\OneDrive\Documents\Xpath_techtutorialz.xlsx";
            List<string[]> excelData = ExcelReaders.ReadExcel(path);
            //string datafromexcel = excelData[1][2];

            foreach (var row in excelData)
            {
                TestContext.WriteLine($"Data : {string.Join(" | ", row)}");
            }
        }
    }



    public class ExcelReaderss
    {
        public static List<string[]> ReadExcel(string filePath, int rowLimit, int colLimit)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            var data = new List<string[]>();

            FileInfo fileInfo = new FileInfo(filePath);
            using (var package = new ExcelPackage(fileInfo))
            {
                var worksheet = package.Workbook.Worksheets[0];
                int rowCount = Math.Min(worksheet.Dimension.Rows, rowLimit);
                int colCount = Math.Min(worksheet.Dimension.Columns, colLimit);

                for (int row = 2; row <= rowCount; row++) // assuming first row is header
                {
                    string[] rowData = new string[colCount];
                    for (int col = 1; col <= colCount; col++)
                    {
                        rowData[col - 1] = worksheet.Cells[row, col].Text;
                    }
                    data.Add(rowData);
                }
            }
            return data;
        }
    }
    public class ExcelDataTests
    {
        [Test]
        public void ReadExcelData()
        {
            string path = @"C:\Users\Lenovo\OneDrive\Documents\Xpath_techtutorialz.xlsx";
            int rowLimit = 4;
            int colLimit = 1;
            List<string[]> excelData = ExcelReaderss.ReadExcel(path, rowLimit, colLimit);

            foreach (var row in excelData)
            {
                Console.WriteLine($"   : {string.Join(" | ", row)}");
            }
        }
    }
}