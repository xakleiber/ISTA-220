--Lesson Plan 17

--C#

--Name: Xavier Kleiber

1. What is the di?erence between a managed resource and an unmanaged resource?

- Usually used to describe something not directly under the control of the garbage collector. 
For example, if you open a connection to a database server this will use resources on the server 
(for maintaining the connection) and possibly other non-.net resources on the client machine, 
if the provider isn't written entirely in managed code.



2. When is memory for an object (reference type) allocated? When is the memory deallocated?

- Typically, an application will only have a single appdomain running user code, but Asp.Net 
and other hosting applications may have many.



3. What is a destructor?

- A destructor is a special method, a little like a constructor, 
except that the CLR calls it after the reference to an object has disappeared.



4. What is the difference in syntax between a constructor and a destructor?

5. Give some examples of scarce resources. Why would you want to manage scarce resources?

- Examples of scarce resources include file streams, network connections, database connections, and memory. 
You want to manage resources to increase performance and to prevent errors caused by a resource not being available. 
If the resource is a file, not releasing it could prevent other users from being able to access that file; 
if the resource is a database connection, your application could prevent other users from being able to connect to the same database.



6. What is exception-safe disposal?

- Exception-safe disposal releases resources even if an error occurs.


7. How do you think that the using statement works for resource management? Give an informal, 

- English language, explanation of how it works.



8. What ill effects could result from attempting to dispose of a resource more than once?

- You will not compromise the security of your computer, 
but you might affect the logical integrity of your application 
if you attempt to dispose of a managed object that no longer exists.



9. We will look at threads later in the term. For now, what is your understanding of how 

- Threads interact with resource management? A good guess is a sufficient answer to this question.
You do not know what is going o happen could be a small problem or catastrophic.



10. Why does the book recommend not attempting to force the garbage collector? Are their 
any exceptions to this recommendation?

- The GC.Collect method starts the garbage collector, but the process runs asynchronously—the GC.
Collect method does not wait for garbage collection to be complete before it returns, 
so you still don’t know whether your objects have been destroyed.