using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace SpecflowFirst.Drivers
{
    //  logging here to be done
    [Binding]
    public sealed class Hooks
    {
        DriverHelper _driverHelper;

        public Hooks(DriverHelper driverHelper) => _driverHelper = driverHelper;

        [BeforeScenario]
        public void BeforeScenario()
        {
            _driverHelper.webDriver = new ChromeDriver();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _driverHelper.webDriver.Quit();
        }
    }
}
