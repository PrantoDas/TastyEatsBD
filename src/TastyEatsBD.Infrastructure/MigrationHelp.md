## Add Migrations

### AppIdentityDbContext
~~~ C#
Add-Migration -Name MigrationName  -Context AppIdentityDbContext -OutputDir Data/Migrations/AppIdentityMigrations

Update-Database MigrationFullName  -Context AppIdentityDbContext
~~~


### TastyEatsDbContext
~~~ C#
Add-Migration -Name MigrationName  -Context TastyEatsDbContext -OutputDir Data/Migrations/TastyEatsMigrations

Update-Database MigrationFullName  -Context TastyEatsDbContext
~~~