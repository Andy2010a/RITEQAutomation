using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;



namespace RITEQAutomation.PageObjects
{
    class HomePage
    {
        public IWebDriver Driver;
        public HomePage(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(Driver, this);
        }

            [FindsBy(How = How.Id, Using = "sign-up-in")]
            private IWebElement signIn;

            [FindsBy(How = How.Name, Using = "login_email")]
            private  IWebElement email;


            [FindsBy(How = How.Name, Using = "login_password")]
            private IWebElement password;


            [FindsBy(How = How.ClassName, Using = "signin-text")]
            private IWebElement logInBtn;



            public IWebElement SignIn()
            {
                return signIn;
            }


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
