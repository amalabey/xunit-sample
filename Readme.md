# Steps

[Ref](https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-dotnet-test)  

```
dotnet new sln

dotnet new classlib -n fizzbuzz.services
dotnet sln add .\fizzbuzz.services\fizzbuzz.services.csproj

dotnet new xunit -n fizzbuzz.unittests
dotnet sln add .\fizzbuzz.unittests\fizzbuzz.unittests.csproj

cd fizzbuzz.unittests
dotnet add reference ..\fizzbuzz.services\fizzbuzz.services.csproj

dotnet add package fluentassertions

```



