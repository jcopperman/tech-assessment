using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TodoList.Tests.PageModels
{
    public class TodoItems
    {
        [FindsBy(How = How.Id, Using = "newtodo")]
        IWebElement txtTodo{ get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/form/p/input[2]")]
        IWebElement btnSubmit { get; set; } 
        
        [FindsBy(How = How.XPath, Using = "/html/body/ul/li/text()")]
        IWebElement txtTodoCreated { get; set; }

        [FindsBy(How = How.LinkText, Using = "/todo/delete/0")]
        IWebElement lnkDelete { get; set; }

        internal void EnterValidDescrition(string description)
        {
            txtTodo.SendKeys(description);
        }

        internal void ClickSubmitButton()
        {
            btnSubmit.Click();
        }

        internal void VerifyRecentlyCreatedTodoItem(string description)
        {
            Assert.Contains(txtTodoCreated.Text, description);
        }

        internal void DeleteRecentlyCreatedItem()
        {
            lnkDelete.Click();
        }

        internal void NavigateToWebApp()
        {
            IWebDriver driver = new IWebDriver
        }
    }
}
