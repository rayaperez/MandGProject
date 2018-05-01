Feature: Scenarios
        As a QA tester I would like to confirm
		That SEDOL UI responding correctly to possitive and negative scenarios

Background: 
     Given I am on SEDOL webpage 
	 And page is fully loaded

@UnitTest
 Scenario Outline: Acceptance Criteria Scenarios
	Given I enter following sedol number <SedolNumber>
	And Is Valid Sedol status is  <IsValidSedol>
	And Is User Defined status is  <IsUserDefined>
	When I press Submit
	Then I receive the message  <ErrorMessage>

	Examples:
	| SedolNumber | IsValidSedol | IsUserDefined | ErrorMessage                                              |
	| 1234567     | False        | False         | Checksum digit does not agree with the first 6 characters |
	| 9123451     | False        | True          | Checksum digit does not agree with the first 6 characters |
	| 9ABCDE8     | False        | True          | Checksum digit does not agree with the first 6 characters |
	| Null        | False        | False         | Input string was not 7-characters long                    |
	| “”          | False        | False         | Input string was not 7-characters long                    |
	| 12          | False        | False         | Input string was not 7-characters long                    |
	| 123456789   | False        | False         | Input string was not 7-characters long                    |
	| 0709954     | True         | False         | No message                                                |
	| B0YBKJ7     | True         | False         | No message                                                |
	| 9123458     | True         | True          | No message                                                |
	| 9ABCDE1     | True         | True          | No message                                                |
	
	
	
	