
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;



namespace Selenium_Demo
{
    public class ApnaohioPage
    {

        
        [Test]
        public void Apnaohio()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("incognito");
            IWebDriver dr = new ChromeDriver(options);
            //string Pagesource = dr.PageSource;
            //Console.WriteLine("HTML :\n"+Pagesource);


            string[] cityname = new string[] { "Columbus", "Cincinnati", "Dayton", "Cleveland", "Toledo", "Other" };
            for (int i = 0; i < cityname.Length; i++)
            {
                dr.Navigate().GoToUrl("https://apnaohio.com/new_ad.jsp");
                dr.Manage().Window.Maximize();

                IWebElement SelectCategory = dr.FindElement(By.Id("category"));
                SelectElement Category = new SelectElement(SelectCategory);
                Category.SelectByText("Computer Training");

                IWebElement SubCategory = dr.FindElement(By.Id("subcat"));
                SelectElement SubCat = new SelectElement(SubCategory);
                SubCat.SelectByText("Available");

                IWebElement YourName = dr.FindElement(By.Name("name"));
                YourName.SendKeys("Techtutorialz");

                IWebElement YourEmail = dr.FindElement(By.XPath("//input[@name='email']"));
                YourEmail.SendKeys("maharshi@gmail.com");

                IWebElement ConfirmEmail = dr.FindElement(By.XPath("//input[@name='email2']"));
                ConfirmEmail.SendKeys("maharshi@gmail.com");

                IWebElement AdTitle = dr.FindElement(By.Id("title"));
                AdTitle.SendKeys("Manual Testing, Selenium, Playwright training, Interview, Job support available");

                IWebElement Description = dr.FindElement(By.XPath("//textarea[@name='desc']"));
                Description.SendKeys("xyz");

                IWebElement City = dr.FindElement(By.Name("city"));
                SelectElement city = new SelectElement(City);
                city.SelectByText(cityname[i]);

                IWebElement Checkbox = dr.FindElement(By.XPath("//input[@name='TAC']"));
                Checkbox.Click();

                Thread.Sleep(7000);
               
                IWebElement btnPost = dr.FindElement(By.XPath("//input[@type='submit']"));
                btnPost.Click();
                Thread.Sleep(2000);
            }
           dr.Close();
            //Console.WriteLine("HI");
        }
    }
}
