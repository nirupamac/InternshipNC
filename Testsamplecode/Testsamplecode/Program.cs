using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V111.Profiler;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Firefox;
public class Program
{
    private static void Main(string[] args)
    {
        // open the Firefox browser //
        IWebDriver driver = new FirefoxDriver();


        //launch TurnUp portal //
        driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
        driver.Manage().Window.Maximize();

        // identify username textbox and enter valid username //
        IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
        usernameTextbox.SendKeys("hari");

        // identify password textbox and enter valid password //
        IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
        passwordTextbox.SendKeys("123123");

        //click remember me //
        IWebElement rememberMebox = driver.FindElement(By.Id("RememberMe"));
        rememberMebox.Click();

        // click on the login button //
        IWebElement LoginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
        LoginButton.Click();


        //check if the user has logged in succesfully//
        IWebElement HelloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));

        if (HelloHari.Text == ("HelloHari"))


        {
            Console.WriteLine("User has logged in succesfully.");


        }
        else
        {
            Console.WriteLine("User has failed to login.");

        }
          }
           }