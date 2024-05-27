using LambdaTest.Selenium.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace LambdaTest.Selenium.TestProject
{
    public static class LocalOptionsTest
    {
        public static async Task Run()
        {
            using IWebDriver driver = new ChromeDriver();
            try
            {   
                var options = new
                {
                    selectDOM = new
                    {
                        id = new[] { "ID-1", "ID-2" }
                    }
                };

                Console.WriteLine("Driver started");
                driver.Navigate().GoToUrl("https://www.pinterest.com/pin/16958936087791895/");
                await SmartUISnapshot.CaptureSnapshot(driver, "SS-1",options);
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
