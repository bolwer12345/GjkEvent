To run the application, download .NET 8.0.0 SDK

********

In order to setup a functional database,
head into the project folder from CLI
and run following 2 commands:

dotnet ef migrations add InitialModel
dotnet ef database update

(if experiencing problems with dotnet
not being able to find the project,
specify the --project flag to GjkEvent)

********

For execution of the program, 
navigate to the project folder and run in CLI:

dotnet run
