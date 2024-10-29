### REQ
dotnet version 
8.0.403

# Up database in docker container
```shell
docker-compose up
```

# Init migrations 
```shell
dotnet ef migrations add InitialCreate
```

## Run migrations
```shell
dotnet ef database update
```

### Start App 
```shell
dotnet run
```

