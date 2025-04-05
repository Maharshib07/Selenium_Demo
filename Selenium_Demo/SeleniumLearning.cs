using System;
using System.Collections.Generic;
using System.Collections;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium.Support.UI;
using System.Security.Cryptography.X509Certificates;
using System.Drawing;

using OpenQA.Selenium.Interactions;
using static System.Collections.Specialized.BitVector32;
using static System.Net.WebRequestMethods;
using NUnit.Framework.Internal;
using NUnit.Framework;
using static System.Net.Mime.MediaTypeNames;
using System.Data;
using System.Net.NetworkInformation;
using Microsoft.Office.Interop.Excel;
using Actions = OpenQA.Selenium.Interactions.Actions;

//using ExcelDataReader;
//using Microsoft.Office.Interop.Excel;
namespace Selenium_Learning
{
    public class Boxes
    {
        public IWebDriver dr;
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("I am from setup method");
            dr = new ChromeDriver();
            //dr = new EdgeDriver();

        }
        [TearDown]
        public void Teardown()
        {
            dr.Quit();
            dr.Dispose();

        }


        [Test]
        public void InteractWithtextbox()
        {
            dr.Navigate().GoToUrl("http://google.com");
            dr.FindElement(By.Name("q")).SendKeys("India");
            //dr.FindElement(By.Name("q")).SendKeys(Keys.Enter);
            IWebElement txtSrch2 = dr.FindElement(By.Name("q"));
            Console.WriteLine(txtSrch2.GetAttribute("value"));
            Assert.IsTrue(txtSrch2.GetAttribute("value") == "India", "Search keyword not matching");
            Assert.IsTrue(txtSrch2.GetAttribute("maxlength") == "2048", "maxlength not matching");
            Console.WriteLine(txtSrch2.GetAttribute("name"));
            Console.WriteLine(txtSrch2.GetAttribute("type"));
        }
        [Test]
        public void InteractWithCheckBoxAndRadio()
        {
            dr.Navigate().GoToUrl("https://www.ironspider.ca/forms/checkradio.htm");
            IWebElement chkRed = dr.FindElement(By.XPath("//input[@value='red']"));
            //Console.WriteLine("blue color is selected:" + chkRed.Selected);
            if (chkRed.Selected == false)
            {
                chkRed.Click(); //select
            }
            IWebElement radioOpera = dr.FindElement(By.XPath("(//input[@type='radio'])[3]"));
            Console.WriteLine("Opera is selected1:" + radioOpera.Selected);
            if (radioOpera.Selected == false)
            {
                radioOpera.Click();
            }
            Console.WriteLine("Opera is selected2:" + radioOpera.Selected);
        }

        [Test]
        public void HandlingSelectBox()
        {
            dr.Navigate().GoToUrl("https://demo.guru99.com/test/newtours/register.php");
            IWebElement ddCountry = dr.FindElement(By.Name("country"));
            //ddCountry.SendKeys("HYDERABAD");
            //SelectElement objSelect = new SelectElement(dr.FindElement(By.Name("country")));
            SelectElement objSelect = new SelectElement(ddCountry);

            objSelect.SelectByIndex(2);
            objSelect.SelectByText("INDIA");
            objSelect.SelectByValue("CHINA");
            Console.WriteLine("Multiple values allowed:" + objSelect.IsMultiple);

            int optCount = objSelect.Options.Count;
            Console.WriteLine("options count is:" + optCount);

            //objSelect.DeselectByValue("CHINA");
            //for (int i = 0; i < optCount; i++)
            //{
            //    objSelect.SelectByIndex(i);
            //}
        }
        [Test]
        public void InteractWithListbox()
        {
            dr.Navigate().GoToUrl("https://output.jsbin.com/osebed/2");
            IWebElement fruitsLB = dr.FindElement(By.XPath("//select[@id='fruits']"));
            SelectElement objSelect = new SelectElement(fruitsLB);
            Console.WriteLine("Multi select allowed:" + objSelect.IsMultiple);
            // objSelect.SelectByValue("apple");
            //objSelect.SelectByText("Grape");
            // Console.WriteLine("Selected options count before:" + objSelect.AllSelectedOptions.Count);
            // objSelect.DeselectByText("Apple");

            //objSelect.DeselectAll();
            //objSelect.DeselectByText("Grape");
            //Console.WriteLine("Selected options count after:" + objSelect.AllSelectedOptions.Count);

        }
        

    }
    class pracSelenium()
    {

        [Test]
        public void Login()
        {
            IWebDriver dr = new ChromeDriver();
            dr.Navigate().GoToUrl("Http://www.google.com");
            dr.FindElement(By.Name("q")).SendKeys("@BMMaharshi");
            Thread.Sleep(5000);
            dr.FindElement(By.Name("q")).SendKeys(Keys.Enter);
            dr.Close();
        }
        [Test]
        public void Loggin()
        {
            IWebDriver Dr = new EdgeDriver();
            Dr.Navigate().GoToUrl("Http://www.google.com");
            Dr.FindElement(By.Name("q")).SendKeys("Flipkart");
            Thread.Sleep(5000);
            Dr.FindElement(By.Name("q")).SendKeys(Keys.Enter);
            Thread.Sleep(4000);
            Dr.Close();


        }
        [Test]
        public void Teachingtutorials()
        {
            IWebDriver dr = new ChromeDriver();
            dr.Navigate().GoToUrl("https://www.tutorialsteacher.com/\r\n");
            Thread.Sleep(2000);
            dr.Manage().Window.Maximize();
            Thread.Sleep(2000);
            // dr.FindElement(By.XPath("//img[@alt='TutorialsTeacher.com']")).Click(); //1.TutorialsTeacher  

            //Thread.Sleep(2000);
            //dr.FindElement(By.XPath("//a[@id='dropdownMenuButton-0']")).Click();//2..NET 
            //Thread.Sleep(3000);
            //dr.FindElement(By.XPath("//a[@id='dropdownMenuButton-1']")).Click(); //3.JAVASCRIPT 
            //dr.FindElement(By.XPath("//a[@id='dropdownMenuButton-2']")).Click();  //4.PROGRAMMING 
            //Thread.Sleep(2000);
            //dr.FindElement(By.XPath("//a[@id='dropdownMenuButton-3']")).Click();  //5.DATABASE
            //dr.FindElement(By.XPath("//*[@href=\"/online-test\"]")).Click();      //6.ONLINE TESTS
            //dr.FindElement(By.XPath("//a[starts-with(@href, \"/article\")]")).Click();  //7.ARTICLES
            //dr.FindElement(By.XPath("(//a[@rel='noopener noreferrer'])[1]")).Click();  //8.F logo
            //dr.FindElement(By.XPath("(//li[@class='nav-item dropdown gap-2 d-lg-flex align-items-lg-center h-5'])[8]")).Click(); //9.x logo
            //dr.FindElement(By.XPath("(//p[@class='bg-white lato-fonts p-2 text-center m-0 card-title'])[1]")).Click();  //10.C# img

            //.NET dropdown
            //dr.FindElement(By.XPath("(//a[@href='/csharp'])[1]")).Click(); //1.C#
            //dr.FindElement(By.XPath("//a[@href='/csharp/object-oriented-programming']")).Click(); //C# OOPS
            Thread.Sleep(3000);
            dr.Close();

        }
        [Test]
        public void BMSHyd()
        {
            IWebDriver dr = new ChromeDriver();
            dr.Navigate().GoToUrl("https://in.bookmyshow.com/explore/movies-hyderabad");
            //Thread.Sleep(2000);
            dr.Manage().Window.Maximize();
            Thread.Sleep(3000);
            dr.FindElement(By.XPath("//span[@class='bwc__sc-1nbn7v6-8 hbuyht']")).Click();
            Thread.Sleep(3000);
            //dr.FindElement(By.XPath("//span[@class='bwc__sc-1iyhybo-6 ilhhay']")).SendKeys("Chhaava (Telugu)");
            // Thread.Sleep(3000);
            //dr.FindElement(By.XPath("//span[@class='bwc__sc-1iyhybo-6 ilhhay']")).SendKeys(Keys.Enter);
            // dr.Quit();
        }
        [Test]
        public void makemy3p()
        {
            IWebDriver dr = new ChromeDriver();
            dr.Navigate().GoToUrl("https://www.makemytrip.com/");
            Thread.Sleep(1000);
            dr.Manage().Window.Maximize();
            dr.FindElement(By.XPath("//span[@data-cy='closeModal']")).Click(); //popup
            //used grandparent, grand child
            dr.FindElement(By.XPath("//span[@class='chNavIcon appendBottom2 chSprite chFlights active']//..//..//span//span")).Click();
            Thread.Sleep(1000);
            // used parent, child
            dr.FindElement(By.XPath("//span[@class='chNavIcon appendBottom2 chSprite chHotels inactive']//parent::span//child::span")).Click();
            Thread.Sleep(1000);
            // used
            dr.FindElement(By.XPath("//div[@data-cy='HotelSearchWidget_316']")).Click();
            Thread.Sleep(1000);
            dr.FindElement(By.XPath("//input[@placeholder='Where do you want to stay?']")).SendKeys("Charminar");
            Thread.Sleep(1000);
            dr.FindElement(By.XPath("//div[text()='Tourist Attraction in Hyderabad']")).Click();
            //dr.FindElement(By.XPath("//div[text()='April']")).Click();




        }
        [Test]
        public void Gmail()
        {


            IWebDriver dr = new ChromeDriver();
            dr.Navigate().GoToUrl("https://google.com");
            dr.Manage().Window.Maximize();
            //dr.FindElement(By.LinkText("Gmail")).Click();   // used linktext
            //dr.FindElement(By.PartialLinkText("capable")).Click();

            IWebElement txtSrch = dr.FindElement(By.Name("q"));
            string mlength = txtSrch.GetAttribute("maxlength");
            Console.WriteLine("check1");
            Assert.IsTrue(mlength == "2048", "Max length is NOT 2048");
            if (mlength == "2050")
            {
                Console.WriteLine("Length is 2050");
            }
            Console.WriteLine("check2");
            string stitle = txtSrch.GetAttribute("title");
            Assert.IsTrue(stitle == "Search", "title is not search");

            dr.Quit();
        }
        [Test]
        public void RadioBox()
        {
            IWebDriver dr = new ChromeDriver();
            dr.Navigate().GoToUrl("https://www.ironspider.ca/forms/checkradio.htm");
            dr.Manage().Window.Maximize();
            dr.FindElement(By.XPath("(//input[@type='radio'])[2]")).Click();
            IWebElement Radioo = dr.FindElement(By.XPath("(//input[@type='radio'])[2]"));

            if (Radioo.Selected == false)
            {
                Radioo.Click();
            }
            Assert.True(Radioo.Selected, "Radio button 'Mozilla' already selected");
            Thread.Sleep(3000);

            dr.Quit();
        }


        [Test]
        public void PractSelectBox()
        {
            IWebDriver dr = new ChromeDriver();
            dr.Navigate().GoToUrl("https://www.tutorialspoint.com/selenium/practice/select-menu.php");

            IWebElement ele = dr.FindElement(By.Id("inputGroupSelect03"));
            SelectElement element = new SelectElement(ele);
            //element.SelectByIndex(3);  // By index
            //element.SelectByText("Proof.");  // By Text
            //element.SelectByValue("3"); // By Value
            //Console.WriteLine("Multiple values allowed:" + element.IsMultiple);  //Bollen to check

            int optcount = element.Options.Count; // TO count
            Console.WriteLine("options count is:" + optcount);

            element.SelectByText("Proof.");
            for (int i = 0; i < optcount; i++)  //Select by LOOP
            {
                element.SelectByIndex(3);

            }
            Thread.Sleep(2000);
            dr.Quit();
        }
        [Test]
        public void listBox()
        {
            IWebDriver dr = new ChromeDriver();
            dr.Navigate().GoToUrl("https://www.tutorialspoint.com/selenium/practice/select-menu.php");
            dr.Manage().Window.Maximize();
            Thread.Sleep(2000);



            dr.FindElement(By.XPath("//span[text()='Please select...']")).Click();
            IWebElement Dr = dr.FindElement(By.XPath("//input[@id='demo-multiple-select-input']"));
            SelectElement elements = new SelectElement(Dr);
            elements.SelectByIndex(1);
            Thread.Sleep(2000);


            Console.WriteLine("Is multiple objects is allowed ;" + elements.IsMultiple); // boolen
            //ele.SelectByText("Health & Baby");     // by text

            //input[@placeholder='Please select...']  dialog    //div[@class='mbsc-scroller-wheel mbsc-ios mbsc-ltr']

            Thread.Sleep(3000);
            dr.Quit();



        }
        [Test]
        public void Flipkart()
        {
            IWebDriver dr = new ChromeDriver();
            dr.Navigate().GoToUrl("https://www.flipkart.com/");
            Thread.Sleep(1000);
            dr.Manage().Window.Maximize();
            dr.FindElement(By.XPath("//input[@name='q']")).Click();
            dr.FindElement(By.XPath("//input[@name='q']")).SendKeys("motorola edge 50");
            dr.FindElement(By.XPath("//input[@name='q']")).SendKeys(Keys.Enter);
            dr.FindElement(By.XPath("(//div[@class='KzDlHZ'])[1]")).Click();
            Thread.Sleep(3000);
            var windowHandles = dr.WindowHandles;             // Handles switch Window
            dr.SwitchTo().Window(windowHandles[1]);
            Thread.Sleep(1000);
            dr.FindElement(By.XPath("//button[@class='QqFHMw vslbG+ In9uk2']")).Click();  //button[@class='QqFHMw vslbG+ In9uk2'] add //button[@class='QqFHMw vslbG+ In9uk2 JTo6b7']
            Thread.Sleep(1000);
            dr.FindElement(By.XPath("//button[@class='QqFHMw zA2EfJ _7Pd1Fp']")).Click();



            Thread.Sleep(5000);
            //dr.Quit();


        }
        [Test]
        public void Amazon()
        {
            IWebDriver dr = new ChromeDriver();
            dr.Navigate().GoToUrl("https://www.amazon.in/");
            dr.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            dr.Manage().Window.Maximize();
            Thread.Sleep(8000);
            dr.FindElement(By.XPath("//span[text()='Hello, sign in']")).Click(); //signin
            //dr.FindElement(By.XPath("//input[@name='email']")).Click();
            dr.FindElement(By.XPath("//input[@name='email']")).SendKeys("maharshibadiganti@gmail.com"); //id
            dr.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            dr.FindElement(By.XPath("//input[@class='a-button-input']")).Click();
            dr.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            //dr.FindElement(By.XPath("//input[@id='ap_password']")).Click(); //password
            dr.FindElement(By.Name("password")).SendKeys("Maharshi08@#");      //input[@id='signInSubmit']
            dr.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            dr.FindElement(By.XPath("//input[@id='signInSubmit']")).Click();
            IWebElement ValidPassword = dr.FindElement(By.XPath("//span[text()='Hello, Maharshi']"));
            string stitle = ValidPassword.Text;
            Assert.IsTrue(stitle == "Hello, Maharshi", "Invalid Username or Password");
            Thread.Sleep(10000);
            dr.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);


           // dr.FindElement(By.XPath("//input[@id='twotabsearchtextbox']")).Click();
           // dr.FindElement(By.XPath("//input[@id='twotabsearchtextbox']")).SendKeys("sony bravia 55 inch"); //search tv
           // dr.FindElement(By.XPath("//input[@id='twotabsearchtextbox']")).SendKeys(Keys.Enter);
           // dr.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
           // dr.FindElement(By.XPath("//span[text()='Sony 139 cm (55 inches) BRAVIA 2 4K Ultra HD Smart LED Google TV K-55S25B (Black)']")).Click();
           // dr.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

           //// System.Collections.ObjectModel.ReadOnlyCollection<string> listHandles = dr.WindowHandles;
           // var windowHandles = dr.WindowHandles;             // Handles switch Window
           // dr.SwitchTo().Window(windowHandles[1]);
           // dr.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
           // dr.FindElement(By.XPath("(//input[@name='submit.add-to-cart'])[2]")).Click();  //add to cart
           // dr.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
           // //proced shows with login
           // dr.FindElement(By.XPath("//input[@aria-labelledby='attach-sidesheet-view-cart-button-announce']")).Click();
           // dr.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
           // dr.FindElement(By.Name("proceedToRetailCheckout")).Click();
            // dr.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            // dr.FindElement(By.XPath("(//input[@type='radio'])[4]")).Click();
            // dr.FindElement(By.Name("__sif_encryptedVPA_collect")).Click();
            // dr.FindElement(By.Name("__sif_encryptedVPA_collect")).SendKeys("8897251375@ybl");
            // dr.FindElement(By.Name("ppw-widgetEvent:ValidateUpiIdEvent")).Click();  //verify
            // Thread.Sleep(3000);
            // dr.FindElement(By.XPath("//input[@aria-labelledby='checkout-secondary-continue-button-id-announce']")).Click(); // use this payment
            // Thread.Sleep(7000);
            // //ChromeOptions blok = new ChromeOptions();
            // //blok.AddArgument("");
            // //dr.FindElement(By.XPath("//a[@id='prime-interstitial-nothanks-button']")).Click();
            // dr.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            //// dr.FindElement(By.Name("placeYourOrder1")).Click();  //pay now

            // Thread.Sleep(3000);
            dr.Quit();

        }
        [Test]
        public void Axismf()
        {
            IWebDriver dr = new ChromeDriver();
            dr.Navigate().GoToUrl("https://www.axismf.com/");
            // DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(dr);
            ChromeOptions options = new ChromeOptions();
            // options.AddArguments("disable-popup-blocking");
            //options.AddArguments("start-maximized");
            dr.Manage().Window.Maximize();
            dr.FindElement(By.XPath("//div[@id='nvpush_cross']")).Click();
            dr.FindElement(By.XPath("(//li[@class='buttonModalLi ng-star-inserted'])[3]")).Click();
            dr.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            //Thread.Sleep(1000);
            dr.FindElement(By.XPath("(//ion-input[@id='pan'])[2]")).Click();
            dr.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            //Thread.Sleep(1000); 
            dr.FindElement(By.XPath("(//input[@class='native-input sc-ion-input-md'])[6]")).SendKeys("Rishi123");
            IWebElement error = dr.FindElement(By.XPath("//div[@class='danger ng-star-inserted']"));
            Assert.IsTrue(error.Size != Size.Empty, "Error msg not displayed");
            // Assert.True(error.Displayed == true, "Error msg not displayed");
            Thread.Sleep(3000);
            dr.Close();
        }
    }
    public class ActionsPerform
    {
       

        [Test]
        public void DragandDropVerify()
        {
            IWebDriver dr = new ChromeDriver();
            dr.Navigate().GoToUrl("https://demo.automationtesting.in/Static.html");
            dr.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            dr.Manage().Window.Maximize();
            Thread.Sleep(1000);

            //From
            IWebElement from = dr.FindElement(By.XPath("//img[@id='angular']"));
            // To
            IWebElement To = dr.FindElement(By.XPath("//div[@id='droparea']"));
            // Dragged and dropped.	
            Actions act = new Actions(dr);
            act.DragAndDrop(from, To).Build().Perform();

            IWebElement drag = dr.FindElement(By.XPath("(//img[@id='angular'])[2]"));
            string dra = drag.GetAttribute("id");
            Assert.IsTrue(dra == "angular", "Element is not draged");
            dr.Quit();
        }
        [Test]
        public void Scrooldownverify()
        {
            IWebDriver dr = new ChromeDriver();
            dr.Navigate().GoToUrl("https://www.flipkart.com/");
            dr.Manage().Window.Maximize();
            IWebElement scrool = dr.FindElement(By.XPath("//a[@aria-label='Payments']"));
            Actions scr = new Actions(dr);
            //scr.ScrollToElement(scrool).Build().Perform();
            scr.SendKeys(Keys.PageDown).Build().Perform();
            scrool.Click();
            Thread.Sleep(3000);
            //string actualURL = dr.Url;
            //Assert.IsTrue(actualURL.Contains("Payments"), "Not reached to payment page");
            dr.Close();
        }
        [Test]
        public void DoubleClickverify()
        {
            IWebDriver dr = new ChromeDriver();
            dr.Navigate().GoToUrl("https://qa-practice.netlify.app/double-click");
            dr.Manage().Window.Maximize();
            IWebElement dobl = dr.FindElement(By.XPath("//button[@id='double-click-btn']"));
            Actions dk = new Actions(dr);
            dk.DoubleClick(dobl).Build().Perform();
            Thread.Sleep(3000);
            dr.Close();
        }
        public void Normalclikverify()
        {
            IWebDriver dr = new ChromeDriver();
            dr.Navigate().GoToUrl("https://www.flipkart.com/");
            dr.Manage().Window.Maximize();
            IWebElement cli = dr.FindElement(By.XPath("//img[@alt='Kilos']"));
            cli.Click();
            Thread.Sleep(3000);
            dr.Close();
        }
        [Test]
        
        public void RightClickverify()
        {
            IWebDriver dr = new ChromeDriver();
            dr.Navigate().GoToUrl("https://swisnl.github.io/jQuery-contextMenu/demo.html");
            dr.Manage().Window.Maximize();
            IWebElement rigt = dr.FindElement(By.XPath("//span[@class='context-menu-one btn btn-neutral']"));
            Actions act = new Actions(dr);
            act.ContextClick(rigt).Build().Perform();

            IWebElement check = dr.FindElement(By.XPath("//li[@class='context-menu-item context-menu-icon context-menu-icon-edit']"));
            string ok = check.GetAttribute("class");
            Assert.IsTrue(ok == "context-menu-item context-menu-icon context-menu-icon-edit", "Right click not performed");
            Thread.Sleep(2000);
            dr.Close();


        }
        [Test]
        public void Keydownwithoutsendkeys()
        {
            IWebDriver dr = new ChromeDriver();
            dr.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(10);
                
            dr.Navigate().GoToUrl("https://www.flipkart.com/");
            dr.Manage().Window.Maximize();
            IWebElement tex = dr.FindElement(By.Name("q"));
            Actions act = new Actions(dr);
            string st = "Motorola Edge 50 pro";
            char[] Chars = st.ToCharArray();
            for (int i = 0; i < Chars.Length; i++)
            {
                act.KeyDown(tex, Chars[i].ToString()).Build().Perform();
            }
            //act.KeyDown(tex, "M").Build().Perform();
            //act.KeyDown(tex, "o").Build().Perform();
            //act.KeyDown(tex, "t").Build().Perform();
            //act.KeyDown(tex, "o").Build().Perform();
           // Assert.IsTrue(tex.GetAttribute("value").Contains(st), "Search box does not contain the expected text.");
            Assert.IsTrue(tex.Displayed);
            Console.WriteLine($"Text entered in search box: {tex.GetAttribute("value")}");
            Thread.Sleep(3000);
            dr.Close();
        }
        [Test]
        public void KeyDownonelement()
        {
            IWebDriver dr = new ChromeDriver();
            dr.Navigate().GoToUrl("https://www.flipkart.com/");
            dr.Manage().Window.Maximize();
            Thread.Sleep(2000);
            Actions action = new Actions(dr);
            IWebElement linkTL = dr.FindElement(By.XPath("//img[@alt='Kilos']"));
            action.KeyDown(linkTL, Keys.Enter).Build().Perform();

            //finding by URl
            //string expectedURL ="https://www.flipkart.com/grocery-supermart-store?marketplace=GROCERY&fm=neo%2Fmerchandising&iid=M_cb1e70ed-524b-4444-9a36-0f88326af4b9_1_372UD5BXDFYS_MC.CBUR1Q46W5F1&otracker=hp_rich_navigation_1_1.navigationCard.RICH_NAVIGATION_Kilos_CBUR1Q46W5F1&otracker1=hp_rich_navigation_PINNED_neo%2Fmerchandising_NA_NAV_EXPANDABLE_navigationCard_cc_1_L0_view-all&cid=CBUR1Q46W5F1";
            //string actualURl = dr.Url;
            //Assert.AreEqual(expectedURL, actualURl, "page is not navigated");

            //Finding by Element
            IWebElement ele = dr.FindElement(By.XPath("((//img[@title='Flipkart'])[1])//."));
            string stitle = ele.GetAttribute("title");
            Assert.IsTrue(stitle=="Flipkart","Title not found" );
            

            dr.Close();

            //Finding by Text
            //Console.WriteLine(ele.Text);
            //Assert.IsTrue(actualURL.Contains(""), "Not reached to Grocery store page");
            //dr.Close(); //((//img[@title='Flipkart'])[1])//.. (//img[@title='Flipkart'])[1] Flipkart
        }
        [Test]
        public void Movetoelement()
        {
            IWebDriver dr = new ChromeDriver();
            dr.Navigate().GoToUrl("https://www.amazon.in/");
            
            dr.Manage().Window.Maximize();
            dr.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            
            Actions act = new Actions(dr);
            IWebElement ele = dr.FindElement(By.XPath("//a[text()='Sell on Amazon']"));
            act.MoveToElement(ele).Build().Perform();
            ele.Click();
            dr.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            IWebElement elet = dr.FindElement(By.XPath("(//div[@class='align-start'])[1]"));
            string stitle = elet.GetAttribute("class");
            Assert.IsTrue(stitle == "align-start", "element is not clicked");
            dr.Close();
        }
        [Test]
        public void Hovertoelement()
        {
            IWebDriver dr = new ChromeDriver();
            dr.Navigate().GoToUrl("https://rahulshettyacademy.com/AutomationPractice/");

            dr.Manage().Window.Maximize();
            dr.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            Actions act = new Actions(dr);
            IWebElement ele = dr.FindElement(By.XPath("//button[text()='Mouse Hover']"));
            act.MoveToElement(ele).Perform();
            dr.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            
            IWebElement elet = dr.FindElement(By.XPath("//a[text()='Reload']"));
            //string stitle = elet.GetAttribute("title");
            Assert.True(elet.Displayed, "mouse is not hovered");
            dr.Close(); 
        }
            [Test]
        public void Alertsverify()
        {
            IWebDriver dr = new ChromeDriver();
            dr.Manage().Window.Maximize();

            dr.Navigate().GoToUrl("https://demoqa.com/alerts");
            dr.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            dr.Manage().Window.Maximize();
            Actions act = new Actions(dr);
            dr.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            IWebElement ele = dr.FindElement(By.XPath("//button[@id='confirmButton']"));
            act.ScrollToElement(ele).Click().Build().Perform();
            dr.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            IAlert alrt = dr.SwitchTo().Alert();  // Alert   
            String alrtMsg = dr.SwitchTo().Alert().Text; // reading alert	
            Console.WriteLine(alrtMsg); //display alert

            Thread.Sleep(1000);
            if (alrtMsg == "Do you confirm action?")
            {
                alrt.Accept();
            }
            Thread.Sleep(2000);
            //IAlert alrtm = dr.SwitchTo().Alert();
            //IWebElement alrtm = dr.FindElement(By.XPath("//span[text()='Ok']"));
            //string alrtmsgs = alrtm.Text;
            //Assert.AreEqual("You selected Ok", alrtmsgs);
            //Console.WriteLine(alrtm.Text);



        }
        [Test]
        public void Alertsverify1()
        {
            IWebDriver dr = new ChromeDriver();
            dr.Navigate().GoToUrl("https://demo.automationtesting.in/Alerts.html");
            dr.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            dr.Manage().Window.Maximize();
            Actions act = new Actions(dr);
            dr.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            IWebElement ele = dr.FindElement(By.XPath("//button[@class='btn btn-danger']"));
            act.MoveToElement(ele).Click().Build().Perform();
            dr.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            IAlert alrt = dr.SwitchTo().Alert();  // Alert   
            var alrtMsg = dr.SwitchTo().Alert().Text; // reading alert	
            Console.WriteLine(alrtMsg); //display alert

            Thread.Sleep(1000);
            if (alrtMsg == "I am an alert box!")
            {
                alrt.Accept();
            }
            

        }
    }
    public class WebTable
    {
        //private object utilities;

        [Test]
        public void readwebtable()
        {
            IWebDriver dr = new ChromeDriver();
            dr.Navigate().GoToUrl("https://www.moneycontrol.com/stocks/marketinfo/marketcap/bse/C.html");
            dr.Manage().Window.Maximize();
            Thread.Sleep(4000);
            IWebElement fst = dr.FindElement(By.XPath("((//td[@class='Topfilter_web_redtext__42Ozs'])[1]//..//child::td)[1]"));
            Console.WriteLine("First company :" + fst.Text);
            IWebElement trd = dr.FindElement(By.XPath("((//td[@class='Topfilter_web_greentext__KELHh'])//..//child::td)[1]"));
            Console.WriteLine("Third company :" + trd.Text);
            dr.Close();


        }
        [Test]
        public void CompaniesNamebyRank()
        {
            {
                Console.WriteLine(CompanyRank(3));
            }
        }
        public string CompanyRank(int rank)
        {
            IWebDriver dr = new ChromeDriver();
            dr.Navigate().GoToUrl("https://www.moneycontrol.com/stocks/marketinfo/marketcap/bse/C.html");
            dr.Manage().Window.Maximize();
            Thread.Sleep(4000);

            IWebElement Companynamewill = dr.FindElement(By.XPath("(//table[@class='Topfilter_web_tbl_indices__Wa1Sj undefined'])//tbody//tr[" + rank + "]//td[1]"));
            return Companynamewill.Text;

        }
        //[Test]
        //public void CompaniesRankbyName()
        //{
        //    string Name = "SBI"; 
        //    int rank = CompanyRank(Name);
        //    if (rank != -1)
        //    {
        //        Console.WriteLine($"The rank of {Name} is: {rank}");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{Name} was not found in the list.");
        //    }
        //}
        //public int CompanyRank(string Name)
        //{
        //    IWebDriver dr = new ChromeDriver();
        //    dr.Navigate().GoToUrl("https://www.moneycontrol.com/stocks/marketinfo/marketcap/bse/C.html");
        //    dr.Manage().Window.Maximize();
        //    Thread.Sleep(4000);

        //    IList<IWebElement> Companyrankwill = dr.FindElement(By.XPath("(//table[@class='Topfilter_web_tbl_indices__Wa1Sj undefined'])//tbody//tr[" + rank + "]//td[1]"));
        //    int rank = -1;
        //    for (int i = 0; i < Companyrankwill.Count; i++)
        //    {
        //        if (Companyrankwill[i].Text.Trim() == Name)
        //        {
        //            rank = i + 1;
        //            break;
        //        }
        //    }
        //    return rank;
        //}
        [Test]
        public void FixedheaderWebTable()
        {
            string name = "Ben";
            bool found = false; 
            IWebDriver dr = new ChromeDriver();
            dr.Navigate().GoToUrl("https://rahulshettyacademy.com/AutomationPractice/"); 
            dr.Manage().Window.Maximize();
            dr.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            IWebElement table = dr.FindElement(By.XPath("(//table[@id='product'])[2]"));
            IList<IWebElement> rows = table.FindElements(By.TagName("tr"));
           // Console.WriteLine("Number of rows: " + rows.Count);
            

            for (int i = 0; i < rows.Count; i++)
            {
                IList<IWebElement> cells = rows[i].FindElements(By.TagName("td"));
                Console.WriteLine("Number of cells: " + cells.Count);
                for (int j = 0; j < cells.Count; j++)
                {
                    string names = cells[0].Text;
                    string positions = cells[1].Text;
                    if (names.Equals(name))
                    {
                        Console.WriteLine($"Name :{names},  Position :{positions}");
                        found= true;    
                         break;
                    }
                   // Console.WriteLine($"Name :{names},  Position :{positions}");
                   if(!found)
                   {
                        Console.WriteLine($"{names} not found in table");
                        break;
                   }
                }

               
            }
            

            dr.Quit();

        }

        //[Test]
        //public void SearchText()
        //{
        //    IWebDriver dr = new ChromeDriver();
        //    //System.Data.DataTable rishi = ReadExcel("C:\\Users\\Lenovo\\OneDrive\\Documents\\Xpath_techtutorialz.xlsx", null);

        //    Console.WriteLine("Rows count is:" + rishi.Rows.Count); // Corrected the rows count
        //    for (int i = 0; i < rishi.Rows.Count; i++)
        //    {
        //        // Navigate to Google
        //        dr.Navigate().GoToUrl("http://google.com");

        //        // Find the search box, enter search text, and hit Enter
        //        dr.FindElement(By.Name("q")).SendKeys(rishi.Rows[i][0].ToString());
        //        dr.FindElement(By.Name("q")).SendKeys(Keys.Enter);

        //        // Optional: Add a wait here if needed, like a small delay between searches
        //        Thread.Sleep(2000);

        //    }
        //}
        //[Test]
        //public DataTable ReadExcel(string fileName, string sheetName)
        //{
        //    WorkBook workbook = WorkBook.Load(fileName);
        //    //// Work with a single WorkSheet.
        //    ////you can pass static sheet name like Sheet1 to get that sheet
        //    ////WorkSheet sheet = workbook.GetWorkSheet("Sheet1");
        //    WorkSheet sheet = null;
        //    //You can also use workbook.DefaultWorkSheet to get default in case you want to get first sheet only
        //    if (sheetName.IsNullOrEmpty() == true)
        //    {
        //        sheet = workbook.DefaultWorkSheet;
        //    }
        //    else
        //    {
        //        sheet = workbook.GetWorkSheet(sheetName);
        //    }

        //    //Convert the worksheet to System.Data.DataTable
        //    //Boolean parameter sets the first row as column names of your table.
        //    return sheet.ToDataTable(true);
        //}
        [Test]
        public void DisplayIPLLeaderboard()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
            try
            {
                //IPL leaderboard page
                driver.Navigate().GoToUrl("https://www.cricbuzz.com/cricket-series/9237/indian-premier-league-2025/points-table");


               
                IWebElement table = driver.FindElement(By.XPath("(//table[@class='table cb-srs-pnts']//tbody)[1]"));

                //table rows
                IList<IWebElement> rows = table.FindElements(By.XPath("//td[@class='cb-srs-pnts-name']/.."));

                Console.WriteLine("IPL 2025 Leaderboard:");
                //Console.WriteLine("/n");
                Console.WriteLine("Team  | Mat  | Won  | Lost  | Tied  | NR  | Pts  |  NRR");

                for (int i = 0; i < rows.Count; i++) 
                {
                    IList<IWebElement> cells = rows[i].FindElements(By.XPath("//td[@class='cb-srs-pnts-name']/."));

                    if (cells.Count >= 8)
                    {
                        string team = cells[0].Text.Trim();
                        string matches = cells[1].Text.Trim();
                        string won = cells[2].Text.Trim();
                        string lost = cells[3].Text.Trim();
                        string tied = cells[4].Text.Trim();
                        string NR = cells[5].Text.Trim();
                        string pts = cells[6].Text.Trim();
                        string NRR = cells[7].Text.Trim();
                        Console.WriteLine($"{team} | {matches} | {won} | {lost} | {tied}  |  {NR}  |  {pts} | {NRR} ");
                    }
                }
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine("Error: Element not found - " + ex.Message);
            }
            finally
            {
                Thread.Sleep(1000);
                driver.Close();
            }
        }
        [Test]
        public void ChennaiMatches()
        {
            IWebDriver dr = new ChromeDriver();
            dr.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            dr.Manage().Window.Maximize();
            dr.Navigate().GoToUrl("https://www.cricbuzz.com/cricket-team/chennai-super-kings/58/schedule");
            //IWebElement chevsBan =  dr.FindElement(By.XPath("//div[@class='cb-bg-white cb-col-100 cb-col cb-hm-rght']//following::div[@class='cb-col-100 cb-col cb-series-matches ng-scope']"));
            //Console.WriteLine(chevsBan.Text, "Shedules not found");  
            var ele = dr.FindElement(By.XPath("//html//body//div[@class='cb-col-100 cb-col cb-series-matches ng-scope']"));
           
            Console.WriteLine(ele);
            
            
        }
        [Test]
        public void ErrorHandling()
        {

            IWebDriver dr = new ChromeDriver();
            dr.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            try
            {
                
                dr.Navigate().GoToUrl("https://www.cricbuzz.com/");
                dr.Manage().Window.Maximize();
                dr.FindElement(By.XPath("//span[text()='IPL 2025']")).Click();
                Thread.Sleep(2000);
                IWebElement element= dr.FindElement(By.XPath("(//a[@class='cb-nav-tab'])[4]"));   //4e
                Console.WriteLine("Element Found: " + element.Text);
                element.Click();
                IWebElement el = dr.FindElement(By.XPath("//div[text()='Chennai Super Kings']"));
                //string xee = el.Text;
                Assert.That(el.Text, Is.EqualTo("Chennai Super Kings"));
                
                Console.WriteLine("Element Found: " + el.Text);
            }
            catch (NoSuchElementException clickex)    
            {
                Console.WriteLine(clickex.Message);
                
                if (dr!= null)
                {
                    try
                    {
                        Screenshot ss = ((ITakesScreenshot)dr).GetScreenshot();
                        string path = "C:\\ScreenshotsSelenium\\testimg.png";
                        //Screenshot screenshot = driver.GetScreenshot();
                        byte[] img = Convert.FromBase64String(ss.AsBase64EncodedString);

                        System.IO.File.WriteAllBytes(path, img);
                        Console.WriteLine($"Screenshot saved to: {path}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Failed to capture screenshot: " + ex.Message);
                    }
                }
            }
            finally
            {
                Thread.Sleep(1000);
                dr.Quit();
            }
        }
    }
    public class ArgcokScreenshotVerify
    {
        public IWebDriver dr;
       //private object utilities;

        [SetUp]
        public void Setuped()
        {
            Console.WriteLine("Hey! I am setup");
            //dr = new ChromeDriver();
            ChromeOptions nas = new ChromeOptions();

            nas.AddArgument("start-maximized");
            //nas.AddArgument("headless");
            nas.AddArgument("disable-popup-blocking");
            //nas.AddArgument("useAutomationExtension");
            //nas.AddArgument("disable-extensions"); //disable existing Extensions
            nas.AddArgument("incognito");
            nas.AddArgument("disable-infobars");
            //nas.AddArgument("headless");

            dr = new ChromeDriver(nas);
            //dr = new EdgeDriver();
            dr.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
        [TearDown]
        public void Teardown()
        {
            Thread.Sleep(3000);
            dr.Quit();
            dr.Dispose();
        }

        [Test]
        public void incoHeadless()
        {
            dr.Navigate().GoToUrl("https://www.hrxbrand.com/home");

        }
        [Test]
        public void Cookiess()
        {
            dr.Navigate().GoToUrl("https://www.google.com/");
            Cookie co1 = new Cookie("Rajaji", "hello");
            Cookie co2 = new Cookie("course", "C#");
            Cookie co3 = new Cookie("cour", "C");
            dr.Manage().Cookies.AddCookie(co1);
            dr.Manage().Cookies.AddCookie(co2);
            dr.Manage().Cookies.AddCookie(co3);

            dr.Manage().Cookies.DeleteCookieNamed("course");
            //dr.Manage().Cookies.DeleteCookie(co1);
            //dr.Manage().Cookies.DeleteAllCookies();

            ICookieJar listCookies = dr.Manage().Cookies;
            System.Collections.ObjectModel.ReadOnlyCollection<Cookie> allacookies = listCookies.AllCookies;
            Console.WriteLine("cookies count:" + allacookies.Count);
            for (int i = 0; i < allacookies.Count; i++)
            {
                Console.WriteLine(allacookies[i].ToString());
            }

            //dr.Manage().Cookies.DeleteCookieNamed("username");

        }
        [Test]
        public void ScreenShotVerify()
        {
            dr.Navigate().GoToUrl("https://www.guru99.com/selenium-tutorial.html");

            Screenshot ss = ((ITakesScreenshot)dr).GetScreenshot();
            
            string path = ("C:\\ScreenshotsSelenium\\testimages.png");
            //Screenshot screenshot = driver.GetScreenshot();
            byte[] img = Convert.FromBase64String(ss.AsBase64EncodedString);

            System.IO.File.WriteAllBytes(path, img);
            ss = ((ITakesScreenshot)dr).GetScreenshot();
            //ss.SaveAsFile(path);
            Console.WriteLine($"Screenshot saved to: {path}");
            
        }
    }
}