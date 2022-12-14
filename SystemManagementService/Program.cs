using Microsoft.EntityFrameworkCore;
using SystemManagementService.Context;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//for database connection
string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ProductContext>(opt => opt.UseSqlServer(connectionString));
builder.Services.AddDbContext<PalletsContext>(opt => opt.UseSqlServer(connectionString));
builder.Services.AddDbContext<NodesContext>(opt => opt.UseSqlServer(connectionString));
builder.Services.AddDbContext<LPNContext>(opt => opt.UseSqlServer(connectionString));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
