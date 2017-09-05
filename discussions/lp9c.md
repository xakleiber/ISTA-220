--Lesson Plan 9

--C#

--Name: Xavier Kleiber

1. What is the difference between deep copy and shallow copy?
 - Deep and shallow copy is in reference to using an object's clone method to create a distinct copy of the object. When an object being cloned contains fields that are reference types, if the referenced types have a clone method this is considered a deep copy. If the referenced type does not have a clone method, then only the references are copied and this is considered a shallow copy.

2. What is the value of a reference after you declare and initialize it?
 - A memory address.

3. How do you declare a value type?
 - Stating the type and a variable name.

4. How do you declare a reference type?
 - Stating the type and a variable name.

5. Does C# allow you to assign NULL to a value type?
 - No.

6. Can you assign a nullable value type to a non-nullable variable of the same type? Why or why not?
 - No, because non-nullable variables cannot contain null.

7. What is the difference between the stack and the heap?
 - Stack memory is organized like a stack of boxes piled on top of one another. When a method is called, each parameter is put in a box that is placed on top of the stack. Each local variable is likewise assigned a box, and these are placed on top of the boxes already on the stack. When a method finishes, you can think of the boxes being removed from the stack. Heap memory is like a large pile of boxes strewn around a room rather than stacked neatly on top of one another. Each box has a label indicating whether it is in use. When a new object is created, the runtime searches for an empty box and allocates it to the object. The reference to the object is stored in a local variable on the stack. The runtime keeps track of the number of references to each box. (Remember that two variables can refer to the same object.) When the last reference disappears, the runtime marks the box as not in use, and at some point in the future it will empty the box and make it available.

8. What does it mean when we say that all classes are specialized types?
 - Types refer to how the stored data is interpreted by the computer. The binary code equivalent of the double 65 is not the same as the binary code equivalent for the integer 65. Although String is considered a primitive type, it is actually a class System.String. All classes are specialized types of the System.Object class and they all store data in a unique way.

9. What does ref do?
 - If you prefix a parameter with the ref keyword, the C# compiler generates code that passes a reference to the actual argument rather than a copy of the argument.

10. What does out do?
 - It basically does the same thing as ref.

11. Describe boxing and unboxing in your own words.
 - Boxing is assigning a the value from a value type to a field in an object. Unboxing is assigning the value from the field of an object to a value type.

12. What does cast do?
 - It checks whether converting an item of one type to another is safe before making the copy.