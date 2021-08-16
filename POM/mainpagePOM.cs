using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Authorization_Facebook_Tests.POM
{
    class mainpagePOM
    {
        private IWebDriver driver;

        public mainpagePOM(IWebDriver driver)
        {
            this.driver = driver;
        }

        private readonly By _inputmail = By.XPath("//input[@type='text']");
        private readonly By _inputpassword = By.XPath("//input[@type='password']");
        private readonly By _clickentrance = By.XPath("//button[@name='login']");
        private readonly By _clickiconbutton = By.XPath("//div[@aria-label='Обліковий запис']");
        
        private readonly By _clickiconbutton_notme = By.XPath("//a[@class='_39g9']");
        

        public mainpagePOM inputmail(string[] mailArray)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(x => driver.FindElement(_inputmail));
            driver.FindElement(_inputmail).SendKeys(mailArray[0]);
            return this;

        }
        public mainpagePOM inputmail2(string[] mailArray)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(x => driver.FindElement(_inputmail));
            driver.FindElement(_inputmail).SendKeys(mailArray[1]);
            return this;

        }
        public mainpagePOM inputmail3(string[] mailArray)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(x => driver.FindElement(_inputmail));
            driver.FindElement(_inputmail).SendKeys(mailArray[2]);
            return this;

        }
        public mainpagePOM inputnumber(string _number)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(x => driver.FindElement(_inputmail));
            driver.FindElement(_inputmail).SendKeys(_number);
            return this;

        }
        public mainpagePOM inputpassword(string _password)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(x => driver.FindElement(_inputpassword));
            driver.FindElement(_inputpassword).SendKeys(_password);
            return this;

        }
        public mainpagePOM clickentrance()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(x => driver.FindElement(_clickentrance));
            driver.FindElement(_clickentrance).Click();
            return this;

        }
        public mainpagePOM clickiconbutton()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(x => driver.FindElement(_clickiconbutton));
            driver.FindElement(_clickiconbutton).Click();
            return this;

        }
        public mainpagePOM clickiconbutton_notme()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(x => driver.FindElement(_clickiconbutton_notme));
            driver.FindElement(_clickiconbutton_notme).Click();
            return this;

        }
       
    }
}
