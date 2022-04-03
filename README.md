# Toll Fee Calculator

## Background

The following code calculates the toll fee for a vehicle based on the type of vehicle. Code has few issues in the toll fee calculation logic and need to refactor the code to make it more readable and maintainable. 

Frameworks and Libraries used:

 - .NET Core 5.0
 - MediatR
 - XUnit
 - Docker
 - FluentValidation
 - OpenAPI Standard

## Implementation

Below changes are added to the base code to make sure all the requirements are covered.

1. Fix below logic errors.
- Add ```intervalStart = date``` to correctly handle multiple times per vehicle correctly.
- Add ```dates.OrderBy(d => d).ToList()``` to handle unordered toll time array calculation correctly.
- Create an extension method to calculate the time difference of each toll time to calculate amount for the time. It fixed the 8.30 to 14.59 time range amount calculation error.
- Check array length to avoid calculation errors in calculation logic.
2. Refactor the code for better readability and maintainability.
3. Create extension methods for common functions.
4. Add unit tests for testability.

There are two implementations in this coding assignment. Fixed logical errors and optimize the coding in **Logic Implementation** which can be find [here](Code-Refactor/Logic-Implementation) and micro service implementation in **API Implementation** which can be find [here](Code-Refactor/API-Implementation).

### Logic Implementation

Logic Implementation is the refactor of the logic of the toll fee calculation. By refactor the logic, we can make the code more readable and maintainable. And also to make the code testable, a unit test project has been added. The unit test project is [here](Code-Refactor/Logic-Implementation/Volvo.TollCalculator.Test). And also the Docker support has been added to the project to make it runnable in containerization platforms.

#### Running the Toll Calculator logic project.

```
docker build -f Volvo.TollCalculator\Dockerfile -t tollcalculator . 
```
This will run the unit tests automatically, and if they fail it will fail the Docker build.

### API Implementation

API Implementation is the real world application of the logic. It follows the api pattern and has a micro service architecture. CQRS and Mediator patterns are used to develop the API. Unit tests are added to the API to make sure the API is testable. Xunit is the unit testing framework used in this project. And also FluentValidation is used to validate the input data. OpenAPI is used to generate the API documentation. API is dockerization ready and can be run in containerization platforms.

#### Running the API

Use the following docker commands to build and run the API. Navigate to the following location [here](Code-Refactor/API-Implementation)

```
docker build -f Volvo.TollCalculator.API\Dockerfile -t tollcalculatorapi .

docker run -p 5000:80 -t tollcalculatorapi
```
Then import the postman collection file ```tollcalculation.postman_collection.json``` and execute the APIs.
