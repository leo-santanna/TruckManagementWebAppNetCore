# Truck Management App with .NET Core MVC and EF Core

A project using .NET Core, EF Core and Unit Tests developed to manage truck fleet data with basic validation based on previously provided documentation.

## Prerequisites

*	Local SQL Server Instance
*	Visual Studio (project was developed using version 2019) - only needed if you want to see the unit tests in greater detail


## Running the tests

From the terminal, in the project root, simply run:

```shell
cd .\TruckManagementWebAppUnitTest
dotnet test
```

Or run them from test project (`TruckManagementWebAppUnitTest`)
directly from Visual Studio for greater detail and description for each test.

## Running the MVC app

From the terminal, in the project root, simply run:

```shell
cd .\TruckManagementWebAppNetCore
dotnet run
```

Now, simply navigate to `http://localhost:5000`

Check for the port in which the project will be executing in your machine. Usually it is on port 5000.

## Supported .NET SDK and CLI versions

This was compiled with the v3.1 sdk (dotnet version 3.1.410). Anything after
that should run.

[Download the SDK](https://dotnet.microsoft.com/download/dotnet-core/3.1).


## Author

[Leonardo Sant'Anna](https://github.com/leo-santanna)

## License

Licensed under the Apache License, Version 2.0.