using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SpecFlowProject1.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.Steps
{
    [Binding]
    class VerificationsSteps
    {


        [Then(@"I Verify the element (.*) to be equal to alias (.*)")]
        public void WhenIVerifyTheElementToBeEqualToAlias(string elementName, string aliasName)
        {

            // Getting the element
            IWebElement element = BaseSteps.GetWebElement(elementName);
            string elementValue = BaseSteps.ReadELement(element);
            string aliasValue = ScenarioContextStorage.getContextInString(aliasName);

            Assert.IsTrue(elementValue.Equals(aliasValue));
        }

        [Then(@"I am on the (.*) page")]
        public void ThenIAmOnThePage(string pageName)
        {
            // setting the object
            BaseSteps.SetObject(pageName);

            // Getting the object and directing to the URL
            string storedUrl = BaseSteps.GetStoredPageUrl();

            string currentPageUrl = BaseSteps.GetUrl();

            Assert.IsTrue(storedUrl.Equals(currentPageUrl));
        }

    }
}
