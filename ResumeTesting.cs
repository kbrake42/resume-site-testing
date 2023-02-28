using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium;

namespace resume_site_testing
{
    [TestFixture]
    [Parallelizable]
    class resumeTests
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            var firefoxOptions = new FirefoxOptions();
            driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), firefoxOptions);

            //var chromeOptions = new ChromeOptions();
            //driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), chromeOptions);

        }

        [Test]
        public void test1()
        {
            driver.Navigate().GoToUrl("http://www.resume.kenbrake.com");
            Thread.Sleep(30000);




        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Quit();
        }

    }
}