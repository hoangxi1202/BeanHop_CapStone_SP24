using BeanHop.API.Mapper;
using BeanHop.Bussiness.Repository;
using BeanHop.Database.EF;
using BeanHop.Model.Model;
using Microsoft.AspNetCore.Identity;
using System.IdentityModel.Tokens.Jwt;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddScoped<BeanHopDBContext>();
builder.Services.AddIdentity<AppUser, AppRole>()
    .AddEntityFrameworkStores<BeanHopDBContext>()
    .AddDefaultTokenProviders();

// Repository
builder.Services.AddScoped<UserRepository>();
// Utilities

builder.Services.AddAutoMapper(Assembly.GetAssembly(typeof(MapperProfile)));
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

app.UseAuthorization();

app.MapControllers();

app.Run();
