using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

[TestFixture]
public class SeleniumTests
{
    private IWebDriver driver;

    [OneTimeSetUp]
    public void Setup()
    {

        string chromeDriverPath = @"C:\chromedriver_win32";
        driver = new ChromeDriver(chromeDriverPath);

    }

    [OneTimeTearDown]
    public void TearDown()
    {
        // Quit the driver
        driver.Quit();
    }

    [Test, Order(1)]
    public void LoginTest()
    {
        // Open the login page
        driver.Navigate().GoToUrl("https://www.saucedemo.com/");

        // Find and interact with login elements
        IWebElement usernameInput = driver.FindElement(By.Id("user-name"));
        IWebElement passwordInput = driver.FindElement(By.Id("password"));
        IWebElement loginButton = driver.FindElement(By.Id("login-button"));

        usernameInput.SendKeys("standard_user");
        passwordInput.SendKeys("secret_sauce");
        loginButton.Click();

        // Add assertions to verify login success
        // ...
    }


}
