using System;
using System.IO;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OfficeOpenXml;
using System.Globalization; // EPPlus for Excel handling

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
            // Ensure the Excel file exists
            Assert.IsTrue(File.Exists(excelFilePath), "Excel file does not exist: " + excelFilePath);
           // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            // Initialize ChromeDriver
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void DataFromExcell()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial; // Required for EPPlus 5+

            var fileInfo = new FileInfo(excelFilePath);

            using (var package = new ExcelPackage(fileInfo))
            {
                var worksheet = package.Workbook.Worksheets[0]; // Get first worksheet
                var rowCount = worksheet.Dimension?.Rows ?? 0; // Safe null handling
                Console.WriteLine("test case\n");

                Assert.Greater(rowCount,3, "Excel file should have at least one data row.");
                Thread.Sleep(1000);
                for (int row =2; row <= rowCount; row++) // Assuming first row is headers
                {
                    Thread.Sleep(1000);
                    var searchQuery1 = worksheet.Cells[row, 1].Text; // Read search term from column 1
                    var searchQuery2 = worksheet.Cells[row, 2].Text;
                    var searchQuery3 = worksheet.Cells[row, 3].Text;// Read search term from column 3
                    var searchQuery4 = worksheet.Cells[row, 4].Text;
                   // Assert.IsNotEmpty(searchQuery1, searchQuery2, searchQuery3, searchQuery4,$"Search term in row {row} is empty!");

                    Console.WriteLine($"list:{searchQuery1}\n|action:{searchQuery2}\n|expected:{searchQuery3}\n|actual:{searchQuery4}\n  \n");
                }
            }
        }

        [TearDown]
        public void TearDownn()
        {
            Thread.Sleep(2000);
            driver.Quit(); // Close browser
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
                    string capital = char.ToUpper(split[0])+ split.Substring(1) + " ";
                    Console.Write(capital);
                }
            }
        }
    }
    public class Program
    {
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
                    string capitalized = char.ToUpper(word[0])+ word.Substring(1);
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
}