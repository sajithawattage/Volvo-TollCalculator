FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src

COPY ["Volvo.TollCalculator/Volvo.TollCalculator.csproj", "Volvo.TollCalculator/"]
COPY ["Volvo.TollCalculator.Test/Volvo.TollCalculator.Test.csproj", "Volvo.TollCalculator.Test/"]

RUN dotnet restore "Volvo.TollCalculator/Volvo.TollCalculator.csproj"
RUN dotnet restore "Volvo.TollCalculator.Test/Volvo.TollCalculator.Test.csproj"

COPY . .

WORKDIR "/src"

RUN dotnet build "Volvo.TollCalculator/Volvo.TollCalculator.csproj" -c Release -o /app/build
RUN dotnet build "Volvo.TollCalculator.Test/Volvo.TollCalculator.Test.csproj" -c Release -o /app/build

RUN dotnet test "Volvo.TollCalculator.Test/Volvo.TollCalculator.Test.csproj" --logger "trx;LogFileName=TollCalculator.trx" 

FROM build AS publish
RUN dotnet publish "Volvo.TollCalculator/Volvo.TollCalculator.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Volvo.TollCalculator.dll"]