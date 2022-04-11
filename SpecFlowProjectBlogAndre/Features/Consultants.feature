Feature: ConsultantsKnowledge
Just a studpid scenario to demonstrate some Gherkin, Specflow and RestSharp functionalities

Scenario: Consultant has tool knowledge
	Given consultant 'Andre' is an employee of Newspark
	When his role is 'TESTAUTOMATION ENGINEER'
	Then he should have knowledge of 'Postman'
		And he gained test experience at 'Rabobank'