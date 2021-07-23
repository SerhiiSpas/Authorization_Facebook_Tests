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
        private readonly By _findname = By.XPath("//span[@class='d2edcug0 hpfvmrgz qv66sw1b c1et5uql lr9zc1uh a8c37x1j keod5gw0 nxhoafnm aigsh9s9 d3f4x2em fe6kdd0r mau55g9w c8b282yb mdeji52x a5q79mjw g1cxx5fr lrazzd5p oo9gr5id hzawbc8m']");


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

    }
}
