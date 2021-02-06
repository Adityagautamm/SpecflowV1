using OpenQA.Selenium;
using SpecFlowProject1.Helper;
using SpecFlowProject1.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.Steps
{
    [Binding]
    class ActionSteps 
    {

        [When(@"I navigate to (.*) page")]
        [Given(@"I navigate to (.*) page")]
        public void GivenINavigateToPage(string pageName)
        {
            // setting the object
            BaseSteps.SetObject(pageName);

            // Getting the object and directing to the URL
            BaseSteps.NavigateToUrl(BaseSteps.GetStoredPageUrl());

        }

        [When(@"I click on (.*) element")]
        public void WhenIClickOnElement(string elementName)
        {
            // Getting the element
           IWebElement element= BaseSteps.GetWebElement(elementName);
            BaseSteps.ClickELement(element);
        }

        [When(@"I save the value of (.*) element as alias (.*)")]
        public void WhenISaveTheValueOfElementAsAlias(string elementName, string aliasName)
        {
            // Getting the element
            IWebElement element = BaseSteps.GetWebElement(elementName);
            ScenarioContextStorage.setContext(aliasName, BaseSteps.ReadELement(element));
        }

    }
}
