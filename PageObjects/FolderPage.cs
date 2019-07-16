using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using AutoIt;
using System.Collections;

namespace RITEQAutomation.PageObjects
{
    class FolderPage
    {

        public IWebDriver Driver;
        public FolderPage(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(Driver, this);
        }
        /*
                [FindsBy(How = How.XPath, Using = "//tr[@class='mc-table-row mc-media-row mc-media-row-border mc-media-row-clickable mc-media-row-culled brws-file-row']")]
                private IWebElement folderName;

                public IWebElement FolderName()
                {
                    return folderName;
                }
                */
        [FindsBy(How = How.XPath, Using = "//span[@class='ue-effect-container uee-FileItemRow-FirstFileSelectCheckbox']")]
        private IWebElement checkBox;

        public IWebElement CheckBox()
        {
            return checkBox;
        }

        [FindsBy(How = How.XPath, Using = "//h1[@class='ax-visually-hidden']")]
        private IWebElement folderHeader;

        public IWebElement FolderHeader()
        {
            return folderHeader;
        }


        [FindsBy(How = How.XPath, Using = "//tr[@class='mc-table-row mc-media-row mc-media-row-border mc-media-row-clickable mc-media-row-selected mc-media-row-culled brws-file-row brws-file-row-selected']")]
        private IList<IWebElement> files;

        public IList<IWebElement> Files()
        {
            return files;
        }

        [FindsBy(How = How.XPath, Using = "//*[@class='c-title-bubble c-title-bubble--respect-line-break c-title-bubble--s']")]
        private IList<IWebElement> members;

        public IList<IWebElement> Members()
        {
            return members;
        }

        [FindsBy(How = How.XPath, Using = "//img[@alt='Account photo']")]
        private IWebElement account;

        public IWebElement Account()
        {
            return account;
        }


        [FindsBy(How = How.XPath, Using = "//a[@href='https://www.dropbox.com/logout']")]
        private IWebElement logout;

        public IWebElement Logout()
        {
            return logout;
        }


        public ArrayList GetAttributes(IList<IWebElement> files ,string attr)
        {
            ArrayList fileNames = new ArrayList();
            foreach (IWebElement ele in files)
            {
               fileNames.Add(ele.GetAttribute(attr));

            }

            return fileNames;

        }



    }
}
