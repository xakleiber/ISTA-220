--Lesson Plan 25

--C#

--Name: Xavier Kleiber

1. You are building a help ticket system. You want to ensure that the older the ticket, the sooner it will be handled by the team. For example, a ticket submitted a week ago has a higher priority than a ticked just submitted. What kind of data structure would you use, and why?  
 - Queue, it's First In, First Out.

2. You are building a tracking system for seasonal agricultural farm labor. The labor requirements vary widely, depending on the season. Your requirement is that the newest hires are terminated first, and that our more experienced hires are kept longer. What kind of data structure would you use, and why?  
 - Stack, it's First In, Last Out.

3. You are building a transaction database. Your requirement is that the database adds data very quickly, and that deletions, updates, and searches happen infrequently. In other words, data is typically added in the order in which the transaction occurs. What kind of data structure would you use, and why?  
 - List

4. You are building an analytical database. Your requirement is that the database handles queries very quickly, but that the data never changes, i.e., there are no inserts, deletions, or updates. What kind of data structure would you use, and why?  
 - Dictionary, because the searches using keywords would go directly to the value for that key.

5. You are building a personnel directory, where searches are performed by last name, first name, middle name. What kind of data structure would you use, and why?  
 - HashSet, it's optimized for fast retrieval.

6. You are building a username/password database. Your requirement is that updates happen frequently (when users change their passwords) and that searches (to authenticate users) happen extremely quickly. What kind of data structure would you use, and why?  
 - Dictionary because it offers fast searching and prevents duplicate usernames.

7. What is a lambda expression? Give an example. Why would we use a lambda expression?  
 - An expression that returns a method. To add functionality without writing a new method.

8. What is the difference between lambda expressions and anonymous methods? What are the advantages of each?  
 - Anonymous methods were added primarily so that you can define delegates without having to create a named method�you simply provide the definition of the method body in place of the method name. Whenever you introduce an anonymous method, you must prefix it with the delegate keyword. Also, any parameters needed are specified in parentheses following the delegate keyword. Lambda expressions provide a more succinct and natural syntax than anonymous methods, and they pervade many of the more advanced aspects of C#.