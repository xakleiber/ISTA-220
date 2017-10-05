--Lesson Plan 27

--C#

--Name: Xavier Kleiber

1. What is an enumerable collection?  
 - An enumerable collection is a collection that implements the System.Collections.IEnumerable interface.

2. What properties and methods does the IEnumerable interface contain?  
 - The IEnumerable interface contains a single method called GetEnumerator.

3. What properties and methods does the IEnumerator interface contain?
    csharp
    object Current { get; }
    bool MoveNext();
    void Reset();
    
4. What values does the MoveNext() method return? What does it do?  
 - True or false. It moves the pointer down to the next item in the list.

5. What values does the Reset() method return? What does it do?  
 - It doesn't return a value. It returns the pointer back to the first item in the list.

6. Are IEnumerable and IEnumerator type safe? Why or why not? If not, how do you implement type safety?  
 - The IEnumerator is unsafe.

7. Why don't recursive methods retain state when used with data structures like binary trees?  
 - They don't lend themselves to maintaining state information between method calls in an easily accessible manner.

8. How do you define an enumerator?  
 - By defining a class that implements the IEnumerator\<T>

9. What is an iterator?  
 - A block of code that yields an ordered sequence of values.

10. What does yield do?  
 - It indicates the value that should be returned by each iteration.