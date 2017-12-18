Feature: MineSweeper
	In order to master MineSweeper game
	I want to understand how numbers in each square are calculated for a single field

@mytag
Scenario: Sweep a four by four field
	Given I have a four by four field
	When the MineSweeper sweep the field
	Then the result should be a field that each square would display the number of surrounding bombs

@mytag
Scenario: Sweep a two by three and a three by five fields 
	Given I have a two by three and a three by five fields
	When the MineSweeper sweep multiple fields
	Then the result should be two fields that each square would display the number of surrounding bombs
	
@mytag
Scenario: Sweep an empty field
	Given I have a zero by zero (empty) field
	When the MineSweeper sweep the empty field
	Then the result should only return count name of field

