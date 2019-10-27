# selenium-dotnet-docker
- I create an automation framework in C# using Nunit
## Getting Started
- Tests can be run via selenium grid
- Jenkins file was created for:
    - building repostiory
    - building docker image
    - sending new image to dockerhub
### Prerequisites
It is recommended to have docker installed(https://docs.docker.com/docker-for-windows/)

## Running the tests

1. Open powershell.
2. Go to NUnitTestProject\NUnitTestProject\TestResults folder
3. Write command 
```
docker-compose up
```
Test create the docker containers and run all test cases.