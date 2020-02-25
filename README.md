Student Tracking System is a sample application that helps you to understand dot net programming as a beginner.

PreRequisite :

1) Basic knowledge of programming
2) Understanding of Dot Net framework

Audience : 

Preferabaly for some one who would like to understand Three Tier Architecture with sql server as a database

Project Scenario :

1) Student Tracking System is a fictious project, taking into account of basic student information, fed through a simple form, whereby one can manage students data and view them in the grid.

2) Sql server express can be used for simplified development with out requiring much setup

Note : One should choose only '.Net Framework Library' as a project template to easify the development approach

Installation:
1) visual Studio any version
2) appropriate sql express edition that supports the Visual Studio version and Operating System (in my case I used Windows 7 + sql server express edition 2012)

How to install the sql server express edition:

Sql Server Express edition download
* For windows 10 This is supported https://www.microsoft.com/en-in/sql-server/sql-server-downloads 

* For windows 7 https://www.microsoft.com/en-in/download/details.aspx?id=29062

Database essentials:

In working with databases, the following are the concepts which are common to all databases.

1.	Connection – To work with the data in a database, the first obvious step is the connection. The connection to a database normally consists of the below-mentioned parameters.

 1.	Database name or Data Source – The first important parameter is the database name to which the connection needs to be established. Each connection can only work with one database at a time.
 2.	Credentials – The next important aspect is the username and password which needs to be used to establish a connection to the database. It ensures that the username and password have the necessary privileges to connect to the database.
 3.	Optional parameters - For each database type, you can specify optional parameters to provide more information on how .net should handle the connection to the database. For example, one can specify a parameter for how long the connection should stay active. If no operation is performed for a specific period of time, then the parameter would determine if the connection has to be closed.
 2.	Selecting data from the database – Once the connection has been established, the next important aspect is to fetch the data from the database. C# can execute 'SQL' select command against the database. The 'SQL' statement can be used to fetch data from a specific table in the database.

3.	Inserting data into the database – C# can also be used to insert records into the database. Values can be specified in C# for each row that needs to be inserted into the database.
4.	Updating data into the database – C# can also be used to update existing records into the database. New values can be specified in C# for each row that needs to be updated into the database.
5.	Deleting data from a database – C# can also be used to delete records into the database. Select commands to specify which rows need to be deleted can be specified in C#.
Ok, now that we have seen the theory of each operation, let's jump into the further sections to look at how we can perform database operations in C#.


 
 

