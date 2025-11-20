using System;
using System.IO;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using LambdaTest.Selenium.Driver;

namespace LambdaTest.Selenium.TestProject
{
    public static class LocalTest
    {
        public static async Task Run()
        {
            var options = new ChromeOptions();
            var driverPath = Path.Combine(AppContext.BaseDirectory, "chromedriver");
            var service = ChromeDriverService.CreateDefaultService(Path.GetDirectoryName(driverPath));
            using IWebDriver driver = new ChromeDriver(service, options);
            try
            {   
                Console.WriteLine("Driver started");
                driver.Navigate().GoToUrl("https://www.lambdatest.com");
                await SmartUISnapshot.CaptureSnapshot(driver, "screenshot");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                driver.Quit();
            }
        }
    }
}
