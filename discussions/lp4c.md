--Lesson Plan 4

--C#

--Name: Xavier Kleiber


1. What are all possible values of a Boolean expression?  
 - The possible values of a Boolean expression are true or false.
2. List eight Boolean operators.  
 - Eight Boolean operators in C# are ==(equal), !=(not equal), &&(logical and), ||(logical or), <(less than), <=(less than or equal to), >(greater than),and >=(greater than or equal to).
3. What are the difference in how short circuiting works for && and ||?  
 - With short circuiting, the left operand is always evaluated first. For &&, if it is false, the right operand isn’t evaluated. For ||, if the left operand is true, the right operand isn’t evaluated. For both, it is best practice to put the most likely case as the left operand to boost performance.
4. Look at the list of operators. What operator has the highest precedence? Which has the lowest?  
 - In C#, the precedence override (parenthesis) has the highest precedence and assignment (=) has the lowest.
5. In an if or else construction using multiple lines of code, what effect does the use of curly braces have?  
 - A block is simply a sequence of statements grouped between an opening brace and a closing brace. Using braces with if or else ensures the entire block of code is conditional instead of just the first line.
6. In a switch statement, what happens if you omit break?  
 - In other languages, the code falls through to the next case and executes that code as well. In C#, this is only true if there is no code for a case label. If any code exists without a break statement, it will fail to compile. For C# to mimic other languages fall-through rules, you can use goto.
