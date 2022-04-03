FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src

COPY ["Volvo.TollCalculator.API/Volvo.TollCalculator.API.csproj", "Volvo.TollCalculator.API/"]
COPY ["Volvo.TollCalculation.Application.UnitTest/Volvo.TollCalculation.Application.UnitTest.csproj", "Volvo.TollCalculator.Test/"]

RUN dotnet restore "Volvo.TollCalculator.API/Volvo.TollCalculator.API.csproj"
RUN dotnet restore "Volvo.TollCalculator.Test/Volvo.TollCalculation.Application.UnitTest.csproj"

COPY . .

WORKDIR "/src"

RUN dotnet build "Volvo.TollCalculator.API/Volvo.TollCalculator.API.csproj" -c Release -o /app/build
RUN dotnet build "Volvo.TollCalculation.Application.UnitTest/Volvo.TollCalculation.Application.UnitTest.csproj" -c Release -o /app/build

RUN dotnet test "Volvo.TollCalculation.Application.UnitTest/Volvo.TollCalculation.Application.UnitTest.csproj" --logger "trx;LogFileName=TollCalculator.trx"

FROM build AS publish
RUN dotnet publish "Volvo.TollCalculator.API/Volvo.TollCalculator.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Volvo.TollCalculator.API.dll"]