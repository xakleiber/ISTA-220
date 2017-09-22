--Lesson Plan 14

--C#

--Name: Xavier Kleiber

1. How does inheritance promote the principle of don't repeat yourself (DRY)?
- Invites you to reread your work,put the entire methods in the parent classes to inherant to the child class.

2. What is the syntax of a derived class that inherits from a base class?
- The derived class inherits the properties of the base class, and you can add or
 override methods and properties as required.

Class Porsche:Automobile
{
... CODE.
}

3. Do all useer defined types (classes and structs) inherit from some base class? If so, what is it?
- All systems inherant, the key is the based class system.structures so yes they do.

4. What happens if you do not have a default constructor in a base class when creating a derived class?
- A derived class constructor always calls a base class constructor.
  
5. Can you assign a variable of a derived class to another variable of its base class? Why or why not?
- Yes.

6. Can you assign a variable of a derived class to another variable of of a derived class of its base class? Why or why not?
- No.

7. Can you assign a variable of a base class to another variable of a derived class? Why or why not?
- Yes.    

8. Under what circumstances would you want to use the new keyword when defining a method in a derived class?
- Your code will compile and run, you should take this warning seriously. If another class derives from Horse and calls the Talk method, it might 
be expecting the method implemented in the Mammal class to be called. 

9. What is a virtual method? Why would you want to define a virtual method?
- Is intended to be written. you have to use overide.

10.What does override do? Why does it do it?
- Extaly what it means to "save over."

11.How do you define an extension type?
- The first parameter.
static class Extension
{
publuc static int MODInt(this inti)
{ 
   return i *3;
	}4
   }
	int x=5;
	inty=5.ModInt();

 
12. Why do you define an extension type?
- It allows you to do things you normally cant do.