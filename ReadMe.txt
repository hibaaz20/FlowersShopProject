** New ReadMe File ***

Here is the revised project.

List of changes that have done in the project according to what you asked:

1. Unused statements have been deleted.

2. I have uploaded the project to Github.

3. The "Tables" file changed to "Models".

4. Changed the project name to a better one.

5. Moved the 'Methods" file to the DataAccess layer.

6. I added a Max and Min Length to the fields and I turned them over a required fields in Creating account process.

7. The files in  "_CreateNewNuGetPackage" and "DoNotModify" Folders can't be delete. I tried to but the project crashed.

8. I split the CRUD File into many classes for each model.

9. I have deleted the not acceptable code in UserForm, and I have wrote another code that access the DB in the Data Access layer to do what required.

10. Empty Events have been deleted.

11. System.ArgumentNullException Error Fixed.

12. When entering a password displays asterisks + Show Password checkbox Added.

13. The Datagridview immediately refresh when canceling any order.


********************************


#Flower Shop Project

This project contains registration and login to an online flowers shop, all the details are saved in Sql server.

*The Project based on Code-First approach*

-> The registration process asks the user for his details, checks if the username doesn't already exist then its insert the details to a sql table.

-> The login process asks for username and password, if the input matching one of the users table records, the users form appears, else if the input maching one of the admins table records the admins form appears.

*The admins details are created while running the project.

**in the users form the users can (add/delete/edit/view) orders.
**in the admins form the admins have access to the users details and they have the options to (add/delete/edit/view)orders for a specific user.

** There is an option to set a new password in case the user forgot his pw, and another option to delete the account.


->In this project we used:
1.OOP=> classes, enum, interface,Inheritance.
2.EF+LINQ.
3.sql joins(join,left join,right join, outer join).

**No design patterns were used**

## How to run the program? ##

1. open the project
2. go to SqlConnection Folder -> SqlConn.cs -> change the server name to your server name.
3. Tools -> NuGet Package Manager -> Package Manager console
4. 1.Give the console the command:update-database
	2. run the project
	

# Admin details: 
username: hiba
pw: 123
# you can add users by click the Create Account button and fill the fields.
