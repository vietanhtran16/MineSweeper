Feature: MineSweeper
	In order to master MineSweeper game
	I want to understand how numbers in each square are calculated for a single field

@mytag
Scenario: Sweep a four by four field
	Given I have a four by four field
	When the MineSweeper sweep the field
	Then the result should be a field that each square would display the number of surrounding bombs
