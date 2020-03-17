using BlueskyCitadelProject1.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace BlueskyCitadelProject1.StepDefinations
{
    [Binding]
    public class BlueSkyCitadelFormSteps
    {
        AutomationTestingPage automationTestingPage;
        public BlueSkyCitadelFormSteps()
        {
            automationTestingPage = new AutomationTestingPage();
        }

        [Given(@"I navigate to the Bluesky Citadel form")]
        public void GivenINavigateToTheBlueskyCitadelForm()
        {

            automationTestingPage.NavigateToForm();
        }
        
        [Given(@"I click on automation testing form")]
        public void GivenIClickOnAutomationTestingForm()
        {
            
        }
        
        [Given(@"I enter the Single line Text")]
        public void GivenIEnterTheSingleLineText()
        {
            automationTestingPage.EnterSingleLineTest();
        }
        
        [Given(@"I select one in the select box")]
        public void GivenISelectOneInTheSelectBox()
        {
            automationTestingPage.SelectOneFromSelectOneTwoThree();
        }
        
        [Given(@"I enter myemail address")]
        public void GivenIEnterMyemailAddress()
        {
            
        }
        
        [Given(@"I select the multi-select")]
        public void GivenISelectTheMulti_Select()
        {
            automationTestingPage.SelectMultiSelector();
        }
        
        [Given(@"I select the Radio List")]
        public void GivenISelectTheRadioList()
        {
            automationTestingPage.selectoneFromRadio();
        }
        
        [Given(@"I select the checkbox list")]
        public void GivenISelectTheCheckboxList()
        {
            
        }
        
        [Given(@"I select United Kingdom as Country")]
        public void GivenISelectUnitedKingdomAsCountry()
        {
            
        }
        
        [Given(@"I select (.*)th of the current month")]
        public void GivenISelectThOfTheCurrentMonth(int p0)
        {
            
        }
        
        [Given(@"I click on the summit button")]
        public void GivenIClickOnTheSummitButton()
        {
            
        }
        
        [Then(@"the message ""(.*)""")]
        public void ThenTheMessage(string p0)
        {
            
        }
    }
}
