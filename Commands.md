# Common Commands in C# and .NET CLI

## Scaffold new project template

`dotnet new <template-name> -f net6.0`

## Adding a new package (latest)

`dotnet add package <package-name>`

## Adding a new package by version (ie. 2.7.9)

` dotnet add package <package-name> --v 2.7.9`

## List all outdated dependencies in your project

`dotnet list package --outdated`

## List .NET SDK versions

`dotnet --list-sdks`

## Running .NET project

`dotnet run`
