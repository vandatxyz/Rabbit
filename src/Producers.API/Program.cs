using Api.DependencyInjection.Extensions;
using Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Configure database context
builder.Services.AddDbContext<ApplicationContext>(options =>
          options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
                                o => o.MigrationsAssembly("Data")));

builder.Services.AddCors(options => options.AddPolicy("CorsPolicy",
buiders =>
{
    buiders
        .AllowAnyMethod()
        .AllowAnyHeader()
        .AllowCredentials()
        .SetIsOriginAllowedToAllowWildcardSubdomains()
        .WithOrigins("http://localhost:4200", "https://localhost:4200");
}));
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//RabbitMQ
builder.Services.AddConfigMasstransitRabbitMQ(builder.Configuration);

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
