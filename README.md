## WebsiteAutomatedTestProject
2018-05-15

### Used softwares

  - Visual Studio 2017 Community
  - Google Chrome (latest)
  - Firefox ESR
  - Selenium IDE 2.9.1	

## DoclerStudyTCs project

This is an automated test project for website testing.
In the testClass.cs please change the path of the browser driver for the required operation.

Contains:
	- UnitTest1.cs which contains the TestMethod and calls the methods from the TestClass.cs
	- TestClass.cs which calls the page objects
	- 3 page objects (covers all pages according to the study description)

Packages:
	- MSTest.TestAdapter.1.2.0
	- MSTest.TestFramework.1.2.0
	- NUnit.3.10.1
	- Selenium.Chrome.WebDriver.2.38
	- Selenium.Support.3.12.0
	- Selenium.WeDriver.3.12.0
		
This project is a unit test project (in C#) which contains the automated test.
The aim of this project is to test automatically all the 12 requirements. 
The page objects contain the commands. The HomePage.cs not just contains the
commands for the 'Home Page' but for the 'UI Testing' page as well. Also there are
some test requirements which concern to the 'Form Page' too, and it was simplier to
test those withni this .cs file. For other information please see the comments in
the code. In Visual Studio use Test Explorer to run the tests.
