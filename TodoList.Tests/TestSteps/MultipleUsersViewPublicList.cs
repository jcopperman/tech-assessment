using System;
using TechTalk.SpecFlow;

namespace TodoList.Tests.TestSteps
{
    [Binding]
    [Scope(Tag = "smoketest")]
    public class MultipleUsersViewPublicList
    {
        [Given(@"I have opened the todo-list app")]
        public void GivenIHaveOpenedTheTodo_ListApp()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I have opened the todo-list app with multiple users")]
        public void GivenIHaveOpenedTheTodo_ListApp_Multiple_Users()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"The todo-list view has loaded")]
        public void WhenTheTodo_ListViewHasLoaded()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should see the list of items")]
        public void ThenIShouldSeeTheListOfItems()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
