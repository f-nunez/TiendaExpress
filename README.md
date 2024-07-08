# TiendaExpress

## Back-End

### API

#### Create migrations following command at repository folder

```text
dotnet ef migrations add Initial -p .\src\Infrastructure\Fnunez.TiendaExpress.Infrastructure\ -s .\src\Presentation\Fnunez.TiendaExpress.Api\ -o Persistence\Migrations -c ApplicationDbContext -v
```

#### Apply migrations following command at repository folder

```text
dotnet ef database update -p .\src\Infrastructure\Fnunez.TiendaExpress.Infrastructure\ -s .\src\Presentation\Fnunez.TiendaExpress.Api\ -c ApplicationDbContext -v
```

## Front-End

Feature-Sliced Design architectural methodology implemented for the frontend side. (https://feature-sliced.design/)

#### https://feature-sliced.design

### Angular Web App

#### Install dependencies

```text
npm install
```

#### Run project

```text
npm run start
```

### React Web App

#### Install dependencies

```text
npm install
```

#### Run project

```text
npm run dev
```