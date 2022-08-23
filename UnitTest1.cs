using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;

namespace AuthorizationAndSendMail
{
    public class Tests
    {
        private IWebDriver driver;
        private readonly By _signInButton = By.XPath("/html/body/header/div/div/div/a[2]");
        private readonly By _loginInputButon = By.XPath("//input[@type='email']");
        private readonly By _signLoginInButton = By.XPath("//*[@id='identifierNext']/div/button");
        private readonly By _passwordInputButon = By.XPath("//*[@id='password']/div[1]/div/div[1]/input");
        private readonly By _signPasswordInButton = By.XPath("//*[@id='passwordNext']/div/button");
        private readonly By _writeMessageInButton = By.XPath("//*[@jscontroller='eIu7Db']");
        private readonly By _addressInputField = By.XPath("//*[@role='combobox']");
        private readonly By _subjectInputField = By.XPath("//*[@name='subjectbox']");
        private readonly By _sendMessageInButton = By.XPath("//*[@class='T-I J-J5-Ji aoO v7 T-I-atl L3']");
        

        private const string _login = "rundog751@gmail.com";
        private const string _password = "3891Kvant";
        private const string _address = "qastarway@gmail.com";
        private const string _subject = "Hello! It is a test";

        [SetUp]
        public void Setup()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com/intl/ru/gmail/about/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {
            var signIn = driver.FindElement(_signInButton);
            signIn.Click();
            var login = driver.FindElement(_loginInputButon);
            login.SendKeys(_login);
            Thread.Sleep(2000);
            var loginSignIn = driver.FindElement(_signLoginInButton);
            loginSignIn.Click();
            Thread.Sleep(2000);
            var password = driver.FindElement(_passwordInputButon);
            password.SendKeys(_password);
            Thread.Sleep(2000);
            var passwordSignIn = driver.FindElement(_signPasswordInButton);
            passwordSignIn.Click();
            Thread.Sleep(2000);
            var writeMessageSignIn = driver.FindElement(_writeMessageInButton);
            writeMessageSignIn.Click();
            Thread.Sleep(2000);
            var address = driver.FindElement(_addressInputField);
            address.SendKeys(_address);
            Thread.Sleep(1000);
            var subject = driver.FindElement(_subjectInputField);
            subject.SendKeys(_subject);
            Thread.Sleep(2000);
            var sendMessageSignIn = driver.FindElement(_sendMessageInButton);
            sendMessageSignIn.Click();
            Thread.Sleep(3000);      
        }

        [TearDown]
        public void TearDown() 
        {
            driver.Quit();
        }
    }
}