--Lesson Plan 6

--C#

--Name: Xavier Kleiber


1.	What is an exception?  
 - Exceptions signal that an error has occurred.
2.	What happens in a try block if the program executes without errors?  
 - If the program executes without errors, all of the statements in the try block run, one after the other, to completion.
3.	How does the catch mechanism work for unhandled exceptions?  
 - If a try block throws an exception, there is no corresponding catch handler, and the try block is part of a method, the method immediately exits and execution returns to the calling method. If the calling method uses a try block, the runtime attempts to locate a matching catch handler for this try block and execute it. If the calling method does not use a try block or there is no matching catch handler, the calling method immediately exits and execution returns to its caller, where the process is repeated. If a matching catch handler is eventually found, the handler runs and execution continues with the first statement that follows the catch handler in the catching method.
4.	What happens in a program if an exception block fails to handle a particular error?  
 - If, after cascading back through the list of calling methods, the runtime is unable to find a matching catch handler, the program will terminate with an unhandled exception.
5.	What is the parent class for all exceptions? How does this work?  
 - Exception is the parent class of all exceptions. If you catch Exception, the handler traps every possible exception that can occur.
6.	How do you determine the type of an error?  
 - You can determine the type of an error by examining the details in the Message property of the thrown exception.
7.	What is the purpose of integer checking?  
 - The purpose of integer checking is to prevent overflow (when the value is less than the minimum value or greater than the maximum value of an integer).
8.	What does the finally block do?  
 - A finally block occurs immediately after a try block or immediately after the last catch handler after a try block. As long as the program enters the try block associated with a finally block, the finally block will always be run, even if an exception occurs. If an exception is thrown and caught locally, the exception handler executes first, followed by the finally block. If the exception is not caught locally (that is, the runtime has to search through the list of calling methods to find a handler), the finally block runs first. In any case, the finally block always executes.
