﻿Feature: Calculator

Scenario: Add two numbers
    Given the first number is 100
    And the second number is 300
    When the two numbers are added
    Then the result should be 400