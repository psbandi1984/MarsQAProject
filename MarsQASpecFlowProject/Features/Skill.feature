Feature: This Test suite contains test scenarios for Skill module
      1.Create Skill
      2.Edit Skill
      3.Delete Skill

 Scenario Outline: A. Create a new Skill record 
    Given User logs into Mars portal
    When User navigate to Skill module
    And User create a new Skill record <Skill> <Level>  
    Then tooltip message should be "<Skill> has been added to your skills"

    Examples:
      | Skill       | Level            |
      | 'SpecFlow'  | 'Beginner'       |
      | 'GitHub'    | 'Intermediate'   |
      | '@1234'     | 'Beginner'       |
      | 'Music'     | 'Expert'         |

 Scenario: B. Create a Skill record without data
	Given User logs into MARS portal 
    When User navigates to skill module
	And User create a new Skill record without data
	Then tooltip message should be "Please enter skill and experience level"

 Scenario: C. Create a Skill record with duplicate data
	Given User logs into MARS portal
    When User navigates to skill module
	And User create a new Skill record 'SpecFlow' 'Beginner'
	Then tooltip message should be "This skill is already exist in your skill list." 

 Scenario Outline: D. Edit an existing Skill record
    Given User logs into Mars portal 
    When User navigate to Skill module
    And User edit an existing Skill record <oldSkill> <newSkill> <oldLevel> <newLevel> 
    Then tooltip message should be "<newSkill> has been updated to your skills"

    Examples:
      | oldSkill    | newSkill    | oldLevel        | newLevel       |
      | 'SpecFlow'  | 'Beginner'  | 'Cucumber'      | 'Intermediate' |
      | 'GitHub'    | 'Java'      | 'Intermediate'  | 'Beginner'     |

 Scenario: E. Delete an existing Skill record
    Given User logs into Mars portal 
    When User navigate to Skill module
    And User delete an existing Skill record 'Java'
    Then tooltip message should be "Java has been deleted"
