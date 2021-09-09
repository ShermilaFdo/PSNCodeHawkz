# Welcome to the Simple Coding Challenge

To get started, create your own repository using this as a template repository.
[Click here](https://docs.github.com/en/github/creating-cloning-and-archiving-repositories/creating-a-repository-on-github/creating-a-repository-from-a-template) to learn to how to do it.

You would need:
1. Visual Studio 2019 Community Edition (VS Code can help too)
2. .NET Core 5.0
3. SQL Server Express (or some edition)

Once you have everything installed, and you've created your own repository from this repository, read the following. 

- Open "Simple Coding Challenge.sln" file. The solution contains 4 projects
- Open up the "appsettings.json" and make sure you have a valid connection string that works in your machine
- Right click the "SimpleCodingChallenge.API" project and mark it as the "Start-up Project"
- If everything is right, the project should run, and it should show "Hello from Simple Coding Challenge API!" on your default web browser

Great! Now let's move on to what you have to do
1. Navigate to "https://localhost:44353/employees/all" on your browser. You should see some data there already. If you look at "FullName" property it is null. <u>Change the code to populate "FullName" property. It should be a concatenated string combining the two fields "FirstName" and "LastName"</u>. (Hint: the code is located in the "Index" method of "EmployeesController" class)
2. Open up "appsettings.json". For "Author" set your name. For "Website" set a link to a good website or article. Navigate to "https://localhost:44353/about" on your browser. You should see your name under "Author". But the "Website" is null. <u>Change the code to populate the "Website" property. It should be populated with the value you set in the appsettings.json</u>. (Hint: the code is located in the "Index" method of "AboutController" class)
3. Create a new API method in "EmployeesController" to add employees
   - The method name should be "Create"
   - The API should be only accessible through "PUT" method. ([Click here](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-5.0&tabs=visual-studio) for more details)
   - The route should be "https://localhost:44353/employees/"
   - The response should contain the newly created Employee
4. Create a new API method in "EmployeesController" to get one employee by ID
   - The method name should be "GetByID"
   - The API should be only accessbile through "GET" method
   - The route should be "https://localhost:44353/employees/{id}"
   - The response should contain the requested Employee details or show an error if not found
5. Add a new column to the "Employee" class
   - The name of the column should be "Country"
   - The data type should be "string"
   - The default vaue should be "N/A" for all existing data
6. Change the maximum length of "FirstName" and "LastName" columns to be 100 characters
7. Add a database migration to do apply the changes you did to the "Employee" class

That's all you have to do. Give these your best shot. You will be assessed at all 7 points. So give each one a shot. If you can't figure something out completely, move on to the next one.

<b><u>Please, remember this is NOT a coding exam. This is mere exercise to understand your capabilities. It's totally OK to be confused by this exercise - in that case, give me a call or send me an e-mail. All I am looking for is whether you gave it your best shot.</u><b/>