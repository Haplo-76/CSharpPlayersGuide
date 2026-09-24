Exercises from Cs Player's Guide 5th Edition by RB Whitaker


Add project to new solution:
dotnet new sln --name MySolution
dotnet new console --output HelloCS
dotnet sln add HelloCS
code .

add project to existing solution. Start in folder w/ sln, make proj and use -o to put in own folder
dotnet new console -n DominionOfKings -o DominionOfKings
dotnet sln Solution7.slnx add DominionOfKings/DominionOfKings.csproj
    //check build
    dotnet sln Solution7.slnx list
    dotnet build Solution7.slnx

    //run it
    dotnet run --proj DominionOfKings


