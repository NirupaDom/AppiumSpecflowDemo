using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;

using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiumSpecflowDemo.Drivers
{
    [Binding]
    public class AppiumDriver
    {
        public AndroidDriver<AndroidElement>?driver;

        [Obsolete]
        public AndroidDriver<AndroidElement> InitialiseAppium()
        {            
            AppiumOptions options = new AppiumOptions();
            options.AddAdditionalCapability("PlatformName","Android");           
            options.AddAdditionalCapability("deviceName", "emulator-5554");
            options.AddAdditionalCapability("app", @"C:\Users\nirupa.neerugatti\Downloads\apk\com.bybox.selfserve834.apk");           
            options.AddAdditionalCapability("automationName", "UiAutomator2");
            options.AddAdditionalCapability("appPackage", "com.bybox.selfserve");
            options.AddAdditionalCapability("appActivity", "crc6499cfb89b12d9d446.MainActivity");
            options.AddAdditionalCapability("adbExecTimeout", 120000);

            Uri url = new Uri("http://127.0.0.1:4723/wd/hub");

            driver = new AndroidDriver<AndroidElement>(url, options);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            return driver;            
        }

        public AndroidDriver<AndroidElement> RelaunchApp()
        {
            AppiumOptions options = new AppiumOptions();
            options.AddAdditionalCapability("PlatformName", "Android");
            options.AddAdditionalCapability("deviceName", "emulator-5554");
            options.AddAdditionalCapability("App", @"C:\Users\nirupa.neerugatti\Downloads\apk\com.bybox.selfserve834.apk");
            options.AddAdditionalCapability("automationName", "UiAutomator2");
            options.AddAdditionalCapability("appPackage", "com.bybox.selfserve");
            options.AddAdditionalCapability("appActivity", "crc6499cfb89b12d9d446.MainActivity");
            options.AddAdditionalCapability("noReset",true);
           
            Uri url = new Uri("http://127.0.0.1:4723/wd/hub");

            driver = new AndroidDriver<AndroidElement>(url, options);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            
            return driver;
        }

        public void QuitApp()
        {
            if (driver != null)
            {
                driver.Quit();
            }
        }

        public void ExplicitWaitHelper()
        {
            WebDriverWait wait = new WebDriverWait(driver,TimeSpan.FromSeconds(10));
            //wait.Until(ExpectedConditions.ElementIsVisible(AndroidDriver<AndroidElement>).fi)
        }
    }
}
