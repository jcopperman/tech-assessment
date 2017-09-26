Feature: AddNewItemToList
	In order to track what needs to be done
	As a loskop
	I want to digitallly create todo items

@functional
Scenario: Add a todo list task
	Given I have opened the todo-list app
	And I create a new task
	When I press submit
	Then the new data is added to the list
