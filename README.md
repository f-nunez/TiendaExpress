# TiendaExpress

### Create migrations following command at repository folder

```text
dotnet ef migrations add Initial -p .\src\Infrastructure\Fnunez.TiendaExpress.Infrastructure\ -s .\src\Presentation\Fnunez.TiendaExpress.Api\ -o Persistence\Migrations -c ApplicationDbContext -v
```

### Apply migrations following command at repository folder

```text
dotnet ef database update -p .\src\Infrastructure\Fnunez.TiendaExpress.Infrastructure\ -s .\src\Presentation\Fnunez.TiendaExpress.Api\ -c ApplicationDbContext -v
```