<div id="container" style="white-space:nowrap">

  <div id="image" style="display:inline float: right;">
        <img style="float: left;" src="https://github.com/AI-Assistant/conditionals_challenge_autograding/blob/main/AddFiles/C%23_logo.png" alt="drawing" width="8%"/>
  </div>

  <div id="texts" style="display:inline; white-space:nowrap; float: right;"> 
        <h1>C#-Basics assignment if-statements and switch-case</h1>
</div>

# :dart: Purpose

This assignment has the following purposes:

+ Simple codingproblems to reinforce topics covered in Modules 1, 2, 3 and 4
+ Practise decompositon into a sequence of tasks
+ Practise looking up information not expliticly stated in the problem statement
+ Practise creating, cloning and submitting assignments via Visual Studio Code and GitHub

##  :school_satchel: Skills

+ Decomposing a problem into a sequence of simple tasks or calculations
+ Using the internet to find information or formulas needed to complete programming problems
+ Use of assignment workflow steps

## :bulb:Knowledge
+ Format console output and read information via the console
+ Use and convert variables with different data types
+ Processing variables and literals by operators
+ Instructions under multiple conditions

## :white_check_mark: Tasks 

### Accept and Clone Assignment

To create the assignment repository, use this [link](https://classroom.github.com/a/LTy1ZWOs).

### General Steps in Writing Programs

Most of our programs are going to follow the same general flow, get info from user, do dome processing/calculatons, generate some output. One way to organize your thoughts is to write comments. Use as an outline for the code you are going to write. Start by creating sections for each of the groups above.

For each problem, you need to identify the tasks and order them. Write out the tasks in English in your code comments before you code. If you can't write in English, you don't know enough to code it. 

Before you code, read the problem and put information into the following categories. Do this in comments in yout code file. 

1. Inputs - what information is needed from the user? Come up with some sample inputs. The input function returns information as a string (text). If you are asking for a number, don't forget to convert the text to a number that can be used in subsequent calculations. 

2. Calculations (Processes) - write out formulas. By hand apply the sample input values to your formulas to check for correctness.

3. Outputs- what are the desired outputs? Do your calculations provide everything you need? If not, update 2 above.

Only after you have figured out what you need to do, start writing code. Start with the inputs section. Write a statement that gets a value from the user. You will need to create variables to hold the Information. Use descriptive names. Follow the input statement with a print statement that prints the value out. Run the program to test to make sure your code works. If it does you can remove or comment out the print statement an cointinue with the next input value. If not, you need to fix your code until it does work. Continue this code and test cycle - write a line of code, then test.

Once you have all the input values, proceed to the processing section. You may need to create additional variables to hold calculated data. Print out these calues as you go. Do they correspond to the hand calculations you made above? If not, fix your code to get the correct results.

Finally, write the print statemants that generate the output. For a first pass, just orint out the desired output. Then go back and add formatting. For example to generate the output in some of the samples you may need to ass tab characters to your output strings.

---

### Task 1: Calculate Trip Duration

This program should ask the user where his journey begins and where it ends. Afterwards the distance of these two places is queried. The program calculates the travel time when traveling at **60km/h**.

> :information_source: **Hint**:exclamation:
> + You must heal the formatting in the example exactly to pass the unittest
> + Note that the distance and duration must be rounded to **two** decimal places
> + Give the labels "Start:", "End:", "Distance" and "Duration:" a total of **ten** characters

Example output/result:
![alt text](https://github.com/AI-Assistant/conditionals_challenge_autograding/blob/main/AddFiles/Task1_example.jpg)

---

### Task 2: Get Minimum Number

This program reads two numbers from the user and outputs the **smaller** of the two numbers.

> :information_source: **Hint**:exclamation:
> + You must heal the formatting in the example exactly to pass the unittest
> + Note that the output is **not** rounded
> + Note the after "... first value:" and "... second value:" must not be followed by any character (including spaces)

Example 1 (Same value) output/result:
![alt text](https://github.com/AI-Assistant/conditionals_challenge_autograding/blob/main/AddFiles/Task2_example1.jpg)

Example 2 outpu/result:
![alt text](https://github.com/AI-Assistant/conditionals_challenge_autograding/blob/main/AddFiles/Task2_example2.jpg)

---
  
### Task 3: Risk Of Heart Attack

This program asks the user if he is overweight and/or stressed. It then outputs the risk of suffering a heart attack. 
  
|                  | Stress        | No stress|
| ---------------- |:-------------:| --------:|
| **Overweight**   | 62%           | 18%      |
| **No overweight**| 15%           | 5%       |

Note: If a person has stress and is overweight, his risk of heart attack according to the 
Table 62%.
  
> :information_source: **Hint**:exclamation:
> + You must heal the formatting in the example exactly to pass the unittest
> + Note that the user answers the questions with **true** or **false**

Example output/result:
![alt text](https://github.com/AI-Assistant/conditionals_challenge_autograding/blob/main/AddFiles/Task3_example.jpg)
  
---

### Task 4: Calculator

This program asks the user first for two numerical values and then 
an arithmetic operation to calculate the two numbers to a result to be output. 
to be calculated.

You calculate the power of a number with the method 'Math.Pow()'.

    double x = Math.Pow(2,3) // x=2^3
  
> :information_source: **Hint**:exclamation:
> + You must heal the formatting in the example exactly to pass the unittest
> + 
> +  You calculate the power of a number with the method 'Math.Pow()'.

Example output/result:
![alt text](https://github.com/AI-Assistant/conditionals_challenge_autograding/blob/main/AddFiles/Task4_example.jpg)

