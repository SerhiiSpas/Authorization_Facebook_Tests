using Authorization_Facebook_Tests.POM;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;


namespace Authorization_Facebook_Tests
{
    
    public class Tests
    {
        private IWebDriver driver;

        private readonly By _findname = By.XPath("//span[@class='d2edcug0 hpfvmrgz qv66sw1b c1et5uql lr9zc1uh a8c37x1j keod5gw0 nxhoafnm aigsh9s9 d3f4x2em fe6kdd0r mau55g9w c8b282yb mdeji52x a5q79mjw g1cxx5fr lrazzd5p oo9gr5id hzawbc8m']");
        private const string _password = "1234567890Test";
        private const string _expectedLogin = "Tomas Edison";
        private const string _number = "0669637279";
        private string[] mailArray = { "pikacas521@eyeremind.com", "hobasa7621@activesniper.com", "hobasa@activesniper.com" };
        [SetUp]
        
        public void Setup()
        {

            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--disable-extensions"); // to disable extension
            options.AddArguments("--disable-notifications"); // to disable notification
            options.AddArguments("--disable-application-cache"); // to disable cache
            driver = new ChromeDriver(options);
            driver.Navigate().GoToUrl("https://www.facebook.com/");
            driver.Manage().Window.Maximize(); //полноекраний режим

        }

        [Test]
        public void Test1()
        {
            var mainpage = new mainpagePOM(driver);

            mainpage.inputmail(mailArray);
            mainpage.inputpassword(_password);
            mainpage.clickentrance();
            mainpage.clickiconbutton();

            var actualLogin = driver.FindElement(_findname).Text;

            Assert.AreEqual(_expectedLogin, actualLogin, "Test fail, login is wrong");


        }
        [Test]
        public void Test2()
        {
            var mainpage = new mainpagePOM(driver);

            mainpage.inputmail2(mailArray);
            mainpage.inputpassword(_password);
            mainpage.clickentrance();
            mainpage.clickiconbutton();


            var actualLogin = driver.FindElement(_findname).Text;

            Assert.AreEqual(_expectedLogin, actualLogin, "Test fail, login is wrong");

        }

        [Test]
        public void Test3()
        {
            var mainpage = new mainpagePOM(driver);

            mainpage.inputnumber(_number);
            mainpage.inputpassword(_password);
            mainpage.clickentrance();
            mainpage.clickiconbutton();


            var actualLogin = driver.FindElement(_findname).Text;

            Assert.AreEqual(_expectedLogin, actualLogin, "Test fail, login is wrong");

        }
        [Test]
        public void Test4_negative()
        {
            var mainpage = new mainpagePOM(driver);

            mainpage.inputmail3(mailArray);
            mainpage.inputpassword(_password);
            mainpage.clickentrance();
            mainpage.clickiconbutton();


            var actualLogin = driver.FindElement(_findname).Text;

            Assert.AreEqual(_expectedLogin, actualLogin, "Test fail, login is wrong");
            
        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
            if (driver != null)
            {
                driver.Quit();
            }
        }
    }
}