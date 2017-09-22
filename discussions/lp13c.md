--Lesson Plan 13

--C#

--Name: Xavier Kleiber

1. How do you define a method that takes an arbitrary number of arguments?
- Public static int Example(params int[] paramList).

2. How do you call a method that takes an arbitrary number of arguments?
- Example(1,2,3,4,5)

3. Why can't you use an array to pass an arbitrary number of arguments to a method?
- You can't use an array to pass an arbitrary number of arguments to a method because an array's size is fixed so it wouldn't be arbitrary.

4. How many parameters can a method have?
- As many as you want it to.

5. Do parameter arguments have to have the same type?
- Yes

6. What is the difference between a method that takes a parameter argument and one that takes optional arguments?
- Has a fixed parameter list, and you cannot pass an arbitrary list of arguments.

7. How do you define a method that takes different (and arbitrary) types of arguments?
- To define a method that takes different and arbitrary types of arguments, you use the object type params array. For example: public static void Example(params object[] paramList)