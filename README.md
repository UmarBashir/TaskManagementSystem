Upon loading the project, the user is presented a list of tasks. 
The user can create a new task by clicking on “Create New option” displayed above the list of tasks.
Each task has an option of editing and deleting. Upon clicking the edit and delete option associated with every task, a new screen is displayed where user can edit and delete any task opened task for the same action.

The project is built using ASP.Net MVC , C# , Entityframework and SQL Server as backend.
A model called Task is defined with all the relevant properties specified in the Task class diagram. Using C# with Entityframework resulted in creating entities to create, edit, delete and list the tasks. To apply validation accross the applicaton, DataAnnotations are used on Task model

The only thing that needs to make this project working is to edit connection string in web.config and update it with  any SQL server instance 

