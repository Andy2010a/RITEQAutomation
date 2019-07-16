using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using AutoIt;

namespace RITEQAutomation.PageObjects
{
    class DropBox
    {

        public IWebDriver Driver;
        public DropBox(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(Driver, this);
        }


        [FindsBy(How = How.XPath, Using = "//*[@class='ue-effect-container uee-AppActionsView-SecondaryActionMenu-text-new-shared-folder']")]
        private IWebElement newShFolder;

        public IWebElement NewSharedFolder()
        {
            return newShFolder;
        }




        [FindsBy(How = How.ClassName, Using = "mc-util-modal-actions-buttons")]
        private IWebElement next;

        public IWebElement Next()
        {
            return next;
        }

        [FindsBy(How = How.XPath, Using = "//input[@class='scl-input scl-sharing-modal-header__input scl-input--borderless mc-input']")]
        private IWebElement folderName;

        public IWebElement FolderName()
        {
            return folderName;
        }

        [FindsBy(How = How.ClassName, Using = "mc-tokenized-input-input")]
        private IWebElement shrEmail;

        public IWebElement ShareEmail()
        {
            return shrEmail;
        }

        [FindsBy(How = How.ClassName, Using = "scl-textarea")]
        private IWebElement message;

        public IWebElement Message()
        {
            return message;
        }

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Share']")]
        private  IWebElement share;

        public IWebElement Share()
        {
            return share;
        }

        [FindsBy(How = How.XPath, Using = "//button[@class='mc-tertiary-link-button secondary-action-menu__button action-upload']")]
        private  IWebElement upload;

        public IWebElement UploadLink()
        {
            return upload;
        }

    

        /*       [FindsBy(How = How.XPath, Using = "//div[@class='brws-file-name-element']")]
               private IWebElement [] files;

               public IWebElement[] Files()
               {
                   return files;
               }

           */



        public void Fileupload(string filepath)
        {
            AutoItX.WinWaitActive("Open");

            AutoItX.ControlFocus("Open", "", "Edit1");
            Thread.Sleep(1000);
            AutoItX.ControlSend("Open", "", "Edit1",filepath);
            Thread.Sleep(1000);
            AutoItX.Send("{ENTER}");

        }


    

    }
}
