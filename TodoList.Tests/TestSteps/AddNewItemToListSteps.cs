using System;
using TechTalk.SpecFlow;
using TodoList.Tests.PageModels;

namespace TodoList.Tests
{
    [Binding]
    public class AddNewItemToListSteps : TodoItemIndex
    {
        [Given(@"I have opened the todo-list app")]
        public void GivenIHaveOpenedTheTodo_ListApp()
        {
            NavigateToWebApp();
        }
        
        [Given(@"I create a new task with a description of '(.*)'")]
        public void GivenICreateANewTask(string description)
        {
            EnterValidDescrition(description);
        }
        
        [When(@"I press submit")]
        public void WhenIPressSubmit()
        {
            ClickSubmitButton();
        }
        
        [Then(@"the new data is added to the list")]
        public void ThenTheNewDataIsAddedToTheList()
        {
            VerifyRecentlyCreatedTodoItem();
        }
    }
}
