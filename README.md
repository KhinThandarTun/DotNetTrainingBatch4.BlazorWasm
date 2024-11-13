Entity Framework Core (EF Core)

Commands to scaffold

ASP.NET Core Web API Migrations

```bash
dotnet ef dbcontext scaffold --project <ProjectName> "Server=.;Database=PointOfSale;User ID=sa;Password=123;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer -o Models -c AppDbContext -f
```

Clean Architecture Database Migration

```bash
dotnet ef migrations add InitialCreate --project <ProjectName> --output-dir Migrations --context ApplicationDbContext 
```
```bash
dotnet ef database update InitialCreate --project <ProjectName> --context ApplicationDbContext --connection "Server=.;Database=DeliCommerce;Trusted_Connection=True;TrustServerCertificate=true;" 
```

```bash
dotnet ef dbcontext scaffold --project ShoppingCart.AppCore "Server=.;Database=ShoppingCart;Trusted_Connection=True;TrustServerCertificate=true;" Microsoft.EntityFrameworkCore.SqlServer --output-dir Entities --namespace ShoppingCart.AppCore.Entities --context-dir ../ShoppingCart.Infrastructure/Data --context ShoppingCartDbContext --context-namespace ShoppingCart.Infrastructure.Data --data-annotations --no-onconfiguring
```
