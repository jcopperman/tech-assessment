using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.PageObjects;

namespace TodoList.Tests.PageModels
{
    public class TodoItemIndex
    {
        [FindsBy(How = How.Id, Using = "newtodo")]
        IWebElement txtTodo { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/form/p/input[2]")]
        IWebElement btnSubmit { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/ul/li/text()")]
        IWebElement txtTodoCreated { get; set; }

        [FindsBy(How = How.LinkText, Using = "/todo/delete/0")]
        IWebElement lnkDelete { get; set; }

        IWebDriver driver = new FirefoxDriver();

        internal void EnterValidDescrition(string description)
        {
            txtTodo.SendKeys(description);
        }

        internal void ClickSubmitButton()
        {
            btnSubmit.Click();
        }

        internal void DeleteRecentlyCreatedItem()
        {
            lnkDelete.Click();
        }

        internal void NavigateToWebApp()
        {
            driver.Navigate().GoToUrl("http://localhost:8080/todo");
        }

        internal void DisposeDriver()
        {
            driver.Quit();
        }

        internal void InjectHtmlIntoDescription(string code)
        {
            txtTodo.SendKeys(code);
        }

        internal void VerifyXSSInjectionValidation()
        {
           
        }
    }
}
