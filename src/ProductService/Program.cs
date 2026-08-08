using Azure.Identity;
using Microsoft.EntityFrameworkCore;
using ProductService.Data;

var builder = WebApplication.CreateBuilder(args);

// Load Key Vault if configured
var keyVaultUri = builder.Configuration["KeyVaultUri"];
if (!string.IsNullOrEmpty(keyVaultUri))
{
    builder.Configuration.AddAzureKeyVault(
        new Uri(keyVaultUri),
        new DefaultAzureCredential());
}

// Get connection string (from Key Vault or appsettings.json fallback)
var connectionString = builder.Configuration.GetConnectionString("PravalConnectionString");

// Register services
builder.Services.AddControllers();
builder.Services.AddDbContext<AppDBContext>(options =>options.UseSqlServer(connectionString));

builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.MapControllers();

app.Run();
