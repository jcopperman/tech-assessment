# Todo list exercise

### Install 

- Install https://nodejs.org/en/
- Download archive from link provided
- Unzip file and cd into it
- run `npm install`

### Run
`node app.js`

Visit http://localhost:8080 in your browser

### High level application requirements
1. Multiple users should be able to view the shared public todo list
2. Should be able to add items
3. Should be able to delete items
4. Should be able to edit items (Missing feature)
5. Must be able to deploy in docker (Missing feature)

### Tasks
1. Add missing requirement #4 to the application
2. Add sufficient test coverage to the application and update readme on howto run the tests
3. Add missing requirement #5 to the application (Dockerfile and update readme with instructions)

### Bonus
4. Display test coverage after tests are executed
5. Find and fix the XSS vulnerability in the application. Also make sure that it wont happen again by including a test.

> ### Notes
> - Update the code as needed and document what you have done in the readme below
> - Will be nice if you can git tag the tasks by number

### Solution
Explain what you have done here and why...

### High level
1.1 Run multiple sessions to verify multiple users. Attempted to create an automated test that simulates this. An ideal candidate for test automation on Selenium Grid and potential use of Docker containers.
1.2 Created automated test with Selenium to test this
1.3 Created unfinished automated test for deletion of items
1.4 Spent too much time on this so abandoned ship! Would create a seperate view for Edit functionality
1.5 Created docker file and added Todo project. Was trying to figure out an elegant way to deploy and run unit tests but ran out of time.

### Tasks
2.1 Failed heartbreakingly!
2.2 Not even close to sufficient
2.3 Gave Docker a hearty attempt

## Bonus
3.1 Started with Extent Reports which broke the build, experimented with Nure(NUnit Report), ended up with the default XML report in bin folder 
3.2 Identified code injection vulnerability, started with an automated test but would prefer a more robust approach. I suspect there is other XSS vulnerability that I missed.

## Solution
Tech used in this assessment:
.NET 4 (C#) 
Selenium - Browser automation
SpecFlow - BDD documentation
NUnit - Test Framework
Git - Tagged where I remembered
Visual Studio 2017
Docker for Windows

Happy path would have been:
Setup a Linux Dev VM
Setup a MEAN stack
Install Eclipse 
Use Serenity BDD and demo the Actor Model
Build a Test Automation Framework in Java
Learn ExpressJS
Add MongoDB to TodoApp for extra credit!
Gain a better understanding of XSS security

## Instructions:
1.Build the solution and run the Express app in the usual way (node)
2.The tests can be run with either Visual Studios test reporter or by using the console and running nunit-console.exe /xml:results.xml bin/debug/TodoList.Tests.dll