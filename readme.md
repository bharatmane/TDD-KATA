dotnet new sln  --name BM.TDDKata

mkdir Queue

dotnet new classlib --name BM.Queue --output Queue\BM.Queue

dotnet new nunit --name BM.Queue.Test --output Queue\BM.Queue.Test

dotnet sln BM.TDDKata.sln add Queue/BM.Queue/BM.Queue.csproj

dotnet sln BM.TDDKata.sln add Queue/BM.Queue.Test/BM.Queue.Test.csproj

dotnet add Queue/BM.Queue.Test/BM.Queue.Test.csproj reference Queue/BM.Queue/BM.Queue.csproj

dotnet add Queue/BM.Queue.Test/BM.Queue.Test.csproj package FluentAssertions --version 5.10.3