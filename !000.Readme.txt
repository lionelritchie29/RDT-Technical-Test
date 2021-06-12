Setup: 
1. In visual studio, View -> SQL Server Data Explorer
2. Connect to a sql server or use the local db version
3. Right click on the db instance-> properties
4. Properties window will show, copy the value of Connection string
   example: Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
5. copy the value to appsettings.json, and change the value of DefaultConnection to the copied string
6. Go to package manager console (tools -> nuget package manager -> package manager console), then run "Update-Database" without quote
7. Run the application

Notes:
1. the schedules will probably passed the deadline after doing step 6
2. to test the schedule in all state: register a new user, and add schedule for that user