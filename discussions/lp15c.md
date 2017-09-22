--Lesson Plan 15

--C#

--Name: Xavier Kleiber

1. What is an interface as the term is used in object-oriented programming?
- Methods and specify that classes implement this interface. In this way, an interface is similar to a contract. 
If a class implements an interface, the interface guarantees that the class contains all the methods specified in the interface.

2. How do you define an interface?
- You use the interface keyword.

3. Can an interface have variables, fields, or properties?
- An interface cannot have variables, fields, or properties because an interface cannot implement functionality.

4. How do you define a method in an interface?
- In a class or a structure.

5. Can you instantiate an object through an interface? Why or why not?
- No, because you can't create through an interface.

6. Using the new keyword, can you declare a reference to an interface?
- No

7. Can an object inherit from multiple interfaces? Can a class implement multiple interfaces? If so, how can it do so?
- Yes & Yes

8. What does it mean to explicitly implement an interface?
- Include the interface name with the method definition..

9. What are the restrictions on interfaces?
- An interface is not allowed to inherit from a structure or a class. What is the difference between an abstract class and an interface? An abstract class can use access modifiers like private, protected, public, and sealed. An abstract class can also define a method as abstract, virtual, override, or sealed override.

10. What is an abstract method?
- An abstract method is similar in principle to a virtual method, except that it does not contain a method body. A derived class must override this method.

11. What is a sealed class?
- You can not use a sealed class as a parent class.

12. What is a sealed method?
- You can use the sealed keyword to declare that an individual method in an unsealed class is sealed. 
This means that a derived class cannot override this method. 
You can seal only a method declared with the override keyword, and you declare the method as sealed override.