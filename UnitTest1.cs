using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;


namespace Authorization_Facebook_Tests
{
    
    public class Tests
    {
        
        private IWebDriver driver;

        private readonly By _inputmail = By.XPath("//input[@type='text']");
        private readonly By _inputpassword = By.XPath("//input[@type='password']");
        private readonly By _clickentrance = By.XPath("//button[@name='login']");
        private readonly By _clickiconbutton = By.XPath("//div[@aria-label='Обліковий запис']");
        private readonly By _findname = By.XPath("//span[@class='d2edcug0 hpfvmrgz qv66sw1b c1et5uql lr9zc1uh a8c37x1j keod5gw0 nxhoafnm aigsh9s9 d3f4x2em fe6kdd0r mau55g9w c8b282yb mdeji52x a5q79mjw g1cxx5fr lrazzd5p oo9gr5id hzawbc8m']");


        /* private readonly By _userlogin = By.XPath("//span[text()='Tomas Edison']");*/

        //private const string _mail = "pikacas521@eyeremind.com";
        private const string _password = "1234567890Test";
        private const string _expectedLogin = "Tomas Edison";
        private string[] mailArray = { "pikacas521@eyeremind.com", "pikacas5211@eyeremind.com" };
        
        [SetUp]
        
        public void Setup()
        {
            
            
            
            
            


        }

        [Test]
        public void Test1()
        {
            
            for (int i = 0; i < mailArray.Length; i++)
            {
                ChromeOptions options = new ChromeOptions();
                options.AddArguments("--disable-extensions"); // to disable extension
                options.AddArguments("--disable-notifications"); // to disable notification
                options.AddArguments("--disable-application-cache"); // to disable cache
                driver = new ChromeDriver(options);
                driver.Navigate().GoToUrl("https://www.facebook.com/");
                driver.Manage().Window.Maximize(); //полноекраний режим

                Thread.Sleep(5000);
                var signin1 = driver.FindElement(_inputmail);
                signin1.SendKeys(mailArray[i]);
                

                var signin2 = driver.FindElement(_inputpassword);
                signin2.SendKeys(_password);

                var signin3 = driver.FindElement(_clickentrance);
                signin3.Click();

                Thread.Sleep(5000);

                var signin4 = driver.FindElement(_clickiconbutton);
                signin4.Click();


                Thread.Sleep(5000);

                var actualLogin = driver.FindElement(_findname).Text;

                Assert.AreEqual(_expectedLogin, actualLogin, "Test fail, login is wrong");

                driver.Quit();
                
            }

        }
        
        [TearDown]
        public void TearDown()
        {
            
        }
    }
}