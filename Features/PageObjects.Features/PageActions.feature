Feature: Page Actions
	In order to interact with a web page
	As a tester
	I want to a page object that encapsulates interactions

Background:
	Given I have a browser

Scenario: Getting a page object
	Given there is a static example page
	When I request the page
	Then I should receive a page object with the url of the static example page
