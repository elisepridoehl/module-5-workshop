# FizzBuzz TDD Workshop

This is a test-driven development kata inspired by the Pluralsight Unit Testing course by Jason Olson.

## Set Up

To get started, we need to create a solution.

1. `dotnet new sln -n FizzBuzz`
1. `dotnet new classlib -n FizzBuzz.Core`
1. `dotnet new xunit -n FizzBuzz.Core.Tests`
1. `dotnet sln add .\FizzBuzz.Core\FizzBuzz.Core.csproj`
1. `dotnet sln add .\FizzBuzz.Core.Tests\FizzBuzz.Core.Tests.csproj`
1. `dotnet add .\FizzBuzz.Core.Tests\FizzBuzz.Core.Tests.csproj reference .\FizzBuzz.Core\FizzBuzz.Core.csproj`
1. `dotnet build`
1. `dotnet new gitignore`
1. `git init`


