using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace ChanlegeQA.Steps;

[Binding]
public class StepBase
{
    protected IWebDriver driver;


    [BeforeScenario]
    public void BeforeScenario()
    {
        driver = new ChromeDriver();
    }

    [After]
    public void AfterScenario()
    {
        driver.Quit();
    }
}