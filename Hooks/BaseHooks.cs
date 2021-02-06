using SpecFlowProject1.FrameworkBase;
using SpecFlowProject1.Helper;
using SpecFlowProject1.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.Hooks
{
    [Binding]
    class BaseHooks
    {

        [BeforeTestRun]
        public static void allPageSetUp()
        {
            AllPageBase.AddAllPages();
        }

        [BeforeScenario]
        public static void Initialisation()
        {
           
            FrameBase.Initialization();         
            ScenarioContextStorage.createContext();
            ScenarioContextStorage.resetContext();
        }

        [AfterScenario]
        public static void dropContextSTorage() 
        {
            FrameBase.TearDown();

        }
    }
}
