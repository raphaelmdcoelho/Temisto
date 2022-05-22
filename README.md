# BROKER

### Instalation

**Build Image**
```
docker build -t rabbitmq .
```

**Run container**
```
docker run -p 5672:5672 -p 15672:15672 --hostname my-rabbit rabbitmq
```

# DATABASE

**Build Image**
```
docker build -t league .
```

**Run container**
```
docker run -p 1433:1433 -e TIMEOUT=120 league
```

# TESTS

**Run**
```
dotnet test --no-restore --verbosity normal
```

# APLICATION INFO
