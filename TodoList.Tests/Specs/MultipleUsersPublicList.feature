Feature: MultipleUsersViewPublicList
	In order to accomodate multiple users
	As a single user
	I should be able to view a shared list of items

@smoketest
@functional
Scenario: View a shared todo-list
	Given I have opened the todo-list app
	When The todo-list view has loaded
	Then I should see the list of items

@smoketest
@loadtest
Scenario: View a shared todo-list multiple users
	Given I have opened the todo-list app with multiple users
	When The todo-list view has loaded
	Then I should see the list of items

@nnbindedtest
Scenario: View a shared todo-list with x amount of users
	Given I have opened the todo-list app with multiple users
	When The todo-list view has loaded
	Then I should see the list of items


