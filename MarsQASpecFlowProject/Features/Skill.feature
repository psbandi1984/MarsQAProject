Feature: This Test suite contains test scenarios for Skill module
      1.Create Skill
      2.Edit Skill
      3.Delete Skill

 Scenario: A. Cleanup existing data
  When User log into Mars portal
  And User click on Skill tab
  Then User clean all existing data in Skill module

 Scenario Outline: B. Create a new Skill record 
    Given User logs into Mars portal
    When User navigate to Skill module
    And User create a new Skill record <Skill> <Level>  
    Then tooltip message should be "<Skill> has been added to your skills"

    Examples:
      |  Skill                                                               | Level            |
      | 'SpecFlow'                                                           | 'Beginner'       |
      | 'GitHub'                                                             | 'Intermediate'   |
      | '@1234abc567890123456578901234567890123456789001233445556666777'     | 'Beginner'       |
      | 'Music'                                                              | 'Expert'         |

 Scenario Outline: C. Edit an existing Skill record
    Given User logs into Mars portal 
    When User navigate to Skill module
    And User edit an existing Skill record <oldSkill> <newSkill> <oldLevel> <newLevel> 
    Then tooltip message should be "<newSkill> has been updated to your skills"

    Examples:
      | oldSkill    | newSkill    | oldLevel        | newLevel       |
      | 'SpecFlow'  | 'Beginner'  | 'Cucumber'      | 'Intermediate' |
      | 'GitHub'    | 'Java'      | 'Intermediate'  | 'Beginner'     |

 Scenario: D. Delete an existing Skill record
    Given User logs into Mars portal 
    When User navigate to Skill module
    And User delete an existing Skill record 'Java'
    Then tooltip message should be "Java has been deleted"

    Scenario: E. Create a Skill record without data
	Given User logs into MARS portal 
    When User navigates to skill module
	And User create a new Skill record without data
	Then tooltip message should be "Please enter skill and experience level"

 Scenario: F. Create a Skill record with duplicate data
	Given User logs into MARS portal
    When User navigates to skill module
	And User create a new Skill record 'SpecFlow' 'Beginner'
	Then tooltip message should be "This skill is already exist in your skill list." 
