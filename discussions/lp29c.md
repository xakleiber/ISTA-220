--Lesson Plan 29

--C#

--Name: Xavier Kleiber


1. What is a delegate? Explain delegates in terms of pointers and reference types.  
 - An object that refers to a method. It creates a function that will run a method.

2. How do you declare a delegate? Include a discussion of types, return values, names, and parameters.  
 - Use the delegate keyword and specify the return type, a name for the delegate, and any parameters.

3. How do you create instances of delegates and assign values to the instance? What are the values?  
 - Optionally specify an access modifier, specify the type, variable name, stop with a semicolon and assign values later, or include value assignment. Values are methods without parenthesis or parameters.

4. How do you invoke a method that has been added to a delegate?  
 - Same as a method.

5. What is an event? Why do we have events?  
 - Events define and trap significant actions. Events run code automatically when something happens.

6. How do you declare events?  
 - Similarly to how you declare a field but with the event key word.

7. How do delegates recognize event subscriptions? How do you unsubscribe an event from a delegate?  
 - The += operator. The –= operator.

8. How do you raise an event? How do you declare code that raises an event?  
 - Call it like a method.

9. Explain with specificity what happens when an event fires and that event has been attached to a delegate.  
 - When an event fires, the methods that are subscribed are called in sequence. It functions exactly like calling a delegate, but with the protection that it cannot be called from outside the class and the subscribed methods must be unsubscribed individually (they can't all be overwritten by one method using the assignment operator like a delegate).