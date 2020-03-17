using BlueskyCitadelProject1.Hooks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlueskyCitadelProject1.PageObjects
{
    class AutomationTestingPage
    {
        IWebDriver driver;

        IWebElement singleLineTest => driver.FindElement(By.Id("nf-field-135"));
        IWebElement selectoneOneTwoThree => driver.FindElement(By.XPath("//*[@id=\"nf - field - 136\"]"));
        IWebElement multiselct123 => driver.FindElement(By.CssSelector("#nf-field-137"));
        IWebElement selectRadio => driver.FindElement(By.Id("nf-field-138-0"));

        public void selectoneFromRadio()
        {
            selectRadio.Click();
        }

        public void SelectMultiSelector()

        {
            SelectElement multiselector = new SelectElement(multiselct123);
            multiselector.SelectByText("Two");
            multiselector.SelectByText("Three");
        }

        public void SelectOneFromSelectOneTwoThree()

        {
            SelectElement select = new SelectElement(selectoneOneTwoThree);
            select.SelectByValue("one");


        }

        public void EnterSingleLineTest()
        {
            singleLineTest.SendKeys("Muyiwa");
        }
        public AutomationTestingPage()
        {
            driver = Hook.driver;
        }
        
        public void NavigateToForm()
        {
            driver.Navigate().GoToUrl("http://blueskycitadel.com/automation-testing-form/");
        }

        
    
    }
}
