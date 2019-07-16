using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using RITEQAutomation.PageObjects;
using System.Collections;

namespace RITEQAutomation
{

    
    [TestFixture]
    public class BaseTest
    {
      
         IWebDriver driver;


        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
          
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.dropbox.com");
        }

        [Test]
        public void Dropboxflow()
        {
            try
            {
                HomePage home = new HomePage(driver);//intializing homepage object
                home.SignIn().Click();  //click signin
                Thread.Sleep(1000);
                home.Email().SendKeys("anandmailed@gmail.com");//username
                home.Password().SendKeys("password");//password
                home.LogInBtn().Click();//login
            }

            catch (Exception ex)
            {

                throw new Exception("login Failed"+ex.Message.ToString());
            }

           Thread.Sleep(10000);
            DropBox dpbox = new DropBox(driver);//intializing dropbox page object
            String folderName = "Test" + DateTime.Now.ToString("yyyyMMddHHmmss");

            try
            {
                
                dpbox.NewSharedFolder().Click();//New Shared folder
                Thread.Sleep(2000);
                dpbox.Next().Click();           
                dpbox.FolderName().SendKeys(folderName);
                Thread.Sleep(2000);
                dpbox.ShareEmail().SendKeys("andymailed@gmail.com");//Shared Email
                dpbox.Message().SendKeys("Testing");
                Thread.Sleep(1000);
                dpbox.Share().Click();
            }
            catch (Exception ex)
            {
                throw new Exception("Shared folder Failed" + ex.Message.ToString());

            }
            Thread.Sleep(8000);
            FolderPage folPage = new FolderPage(driver);
            try
            {
             dpbox.UploadLink().Click();
             dpbox.Fileupload("C:\\Users\\anand\\Desktop\\download.jpeg");     
            Thread.Sleep(8000);         
            folPage.CheckBox().Click();
            Thread.Sleep(1000);
            dpbox.UploadLink().Click();
            dpbox.Fileupload("C:\\Users\\anand\\Desktop\\Run1.json");
            Thread.Sleep(8000);
            }
            catch (Exception ex)
            {
                throw new Exception("File Uplaoad failed" + ex.Message.ToString());

            }

            Assert.AreEqual(folderName, folPage.FolderHeader().GetAttribute("textContent")); //verifying folder name
            ArrayList Names = folPage.GetAttributes(folPage.Files(), "data-filename"); //gettin the file names
            Assert.Contains("download.jpeg", Names);//verifying the filenames 
            Assert.Contains("Run1.json", Names);

            ArrayList members = folPage.GetAttributes(folPage.Members(), "data-title");//getting the shared email 


            foreach(string member in members)
            {

                Assert.IsTrue(member.Contains("andymailed@gmail.com"));//verifying the shared email
            }


            folPage.Account().Click();

            folPage.Logout().Click();


        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }




    }
}


