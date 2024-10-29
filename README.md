### REQ
dotnet version 
8.0.403

# Up database in docker container
docker-compose up 

# Init migrations 
dotnet ef migrations add InitialCreate

## Run migrations
dotnet ef database update

### Start App 
dotnet run

