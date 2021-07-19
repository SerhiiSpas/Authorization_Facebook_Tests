using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;


namespace Authorization_Facebook_Tests
{
    
    public class Tests
    {
        
        private IWebDriver driver;

        private readonly By _inputmail = By.XPath("/html/body/div[1]/div[2]/div[1]/div/div/div/div[2]/div/div[1]/form/div[1]/div[1]/input");
        private readonly By _inputpassword = By.XPath("/html/body/div[1]/div[2]/div[1]/div/div/div/div[2]/div/div[1]/form/div[1]/div[2]/div/input");
        private readonly By _clickentrance = By.XPath("/html/body/div[1]/div[2]/div[1]/div/div/div/div[2]/div/div[1]/form/div[2]/button");
        private readonly By _clickiconbutton = By.XPath("/html/body/div[1]/div/div[1]/div/div[2]/div[4]/div[1]/span/div");
        private readonly By _findname = By.XPath("/html/body/div[1]/div/div[1]/div/div[2]/div[4]/div[2]/div/div[2]/div[1]/div[1]/div/div/div/div/div/div/div/div/div[1]/div/div[1]/a/div[1]/div[2]/div/div/div/div[1]/span");


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

                Thread.Sleep(10000);
                var signin1 = driver.FindElement(_inputmail);
                signin1.SendKeys(mailArray[i]);
                

                var signin2 = driver.FindElement(_inputpassword);
                signin2.SendKeys(_password);

                var signin3 = driver.FindElement(_clickentrance);
                signin3.Click();

                Thread.Sleep(10000);

                var signin4 = driver.FindElement(_clickiconbutton);
                signin4.Click();


                Thread.Sleep(10000);

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