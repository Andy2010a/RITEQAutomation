using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace RITEQAutomation.PageObjects
{
    class LoginPage
    {
        public IWebDriver Driver;
        public LoginPage(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(Driver, this);
        }


        [FindsBy(How = How.Name, Using = "login_email")]
        private IWebElement email;


        [FindsBy(How = How.Name, Using = "login_password")]
        private IWebElement password;


        [FindsBy(How = How.ClassName, Using = "login-button signin-button button-primary")]
        private IWebElement logInBtn;


        public IWebElement Email()
        {
            return email;
        }

        public IWebElement Password()
        {
            return password;
        }

        public IWebElement LogInBtn()
        {
            return logInBtn;
        }

    }
}
