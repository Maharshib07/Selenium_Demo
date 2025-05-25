using Microsoft.Office.Interop.Excel;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            
            dr.Navigate().GoToUrl("https://apnaohio.com/new_ad.jsp");
            dr.Manage().Window.Maximize();
           
            IWebElement SelectCategory = dr.FindElement(By.Id("category"));
            SelectElement Category = new SelectElement(SelectCategory);
            Category.SelectByIndex(5);

            IWebElement SubCategory = dr.FindElement(By.Id("subcat"));
            SelectElement SubCat = new SelectElement(SubCategory);
            SubCat.SelectByText("Available");

            IWebElement City = dr.FindElement(By.Name("city"));
            SelectElement city = new SelectElement(City);
            city.SelectByText("Columbus");

            //string[] cityname = new string[] { "Columbus", "Cincinnati", "Dayton", "Cleveland", "Toledo", "other" };
            //for (int i = 0; i<cityname.Length;i++)
            //{
            //    
            
            
            IWebElement YourName = dr.FindElement(By.Name("name"));
            YourName.SendKeys("Rishi");
            YourName.SendKeys(Keys.Enter);

            IAlert alert = dr.SwitchTo().Alert();
            alert.Accept();

            IWebElement YourEmail = dr.FindElement(By.XPath("//input[@name='email']"));
            YourEmail.SendKeys("maharshi@gmail.com");
            YourEmail.SendKeys(Keys.Enter);

            IAlert alrt = dr.SwitchTo().Alert();
            alrt.Accept();

            IWebElement chkRed = dr.FindElement(By.XPath("//input[@name='emailCheck']"));
            //name="emailCheck"
            if (chkRed.Selected == false)
            {
                chkRed.Click(); //select
            }

            IWebElement ConfirmEmail = dr.FindElement(By.XPath("//input[@name='email2']"));
            ConfirmEmail.SendKeys("maharshi@gmail.com");
            ConfirmEmail.SendKeys(Keys.Enter);

            IAlert alt = dr.SwitchTo().Alert();
            alt.Accept();

            IWebElement AdTitle = dr.FindElement(By.Id("title"));
            AdTitle.SendKeys("Manual Testing, Selenium, Playwright training, Interview, Job support available");
            AdTitle.SendKeys(Keys.Enter);

            IAlert al = dr.SwitchTo().Alert();
            al.Accept();  //textarea name="desc"

            IWebElement Description = dr.FindElement(By.XPath("//textarea[@name='desc']"));
            Description.SendKeys("xyz");
            Description.SendKeys(Keys.Enter);

            Thread.Sleep(5000);
            //input type="checkbox"
            IWebElement Checkbox = dr.FindElement(By.XPath("//input[@name='TAC']"));
            Checkbox.Click();

            //input type="submit"
            IWebElement post = dr.FindElement(By.XPath("//input[@type='submit']"));
            post.SendKeys("xyz");
            post.SendKeys(Keys.Enter);
            IAlert alertt = dr.SwitchTo().Alert();
            string altmsg = alertt.Text;
            Console.WriteLine(altmsg); 






















        }
    }
}
