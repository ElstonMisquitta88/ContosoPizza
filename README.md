# ContosoPizza
Entity Framework Core Demo 


-- Initially migration and creation of Tables in Database

PM> Add-Migration InitialCreate
PM> Update-Database

-- Additon of new property - new column in table in Database

PM> Add-Migration AddEmail



--- From Existing DB -Create class file
Scaffold-DbContext "Data Source=server;Database=ContosoPizza;User ID=sa;Password=password;Encrypt=True;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer -ContextDir Data -OutputDir Models
