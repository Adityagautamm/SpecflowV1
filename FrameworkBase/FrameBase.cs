using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SpecFlowProject1.FrameworkBase
{
    class FrameBase
	{
		public static IWebDriver driver;
		//public static WebDriverWait wait;
		//public static Properties prop;
		//public static EventFiringWebDriver e_driver;
		//public static EventListenerClass eventListener;
		//public static AllPageDictionary allPageDictionary;

		public static void Initialization()
		{
			// setting driver statically
			driver = new ChromeDriver(@"C:\Users\Aditya Gautam\Desktop\curious fella\Automation\webdriver\chrome");

			// maximizing the window
			driver.Manage().Window.Maximize();
			
			//Implicit wait
			driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);


			//Page Load 
			driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);



		}


		public static void TearDown()
		{
			try
			{
				Thread.Sleep(2000);
			}
			catch (Exception e)
			{
				// TODO Auto-generated catch block

			}
			driver.Quit();
		}



	}

}

