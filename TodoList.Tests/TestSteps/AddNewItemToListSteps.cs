using System;
using TechTalk.SpecFlow;

namespace TodoList.Tests
{
    [Binding]
    public class AddNewItemToListSteps
    {
        [Given(@"I have opened the todo-list app")]
        public void GivenIHaveOpenedTheTodo_ListApp()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I create a new task")]
        public void GivenICreateANewTask()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I press submit")]
        public void WhenIPressSubmit()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the new data is added to the list")]
        public void ThenTheNewDataIsAddedToTheList()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
