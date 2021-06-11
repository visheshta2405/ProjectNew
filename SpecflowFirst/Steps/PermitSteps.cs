using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecflowFirst.Steps
{
    [Binding]
    public sealed class PermitSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly DriverHelper _driverHelper;
        public PermitSteps(DriverHelper driverHelper, ScenarioContext scenarioContext)
        {
            _driverHelper = driverHelper;
            _scenarioContext = scenarioContext;
        }

    }
}
