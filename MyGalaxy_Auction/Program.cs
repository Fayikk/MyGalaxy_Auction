using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyGalaxy_Auction.Extensions;
using MyGalaxy_Auction.Hubs;
using MyGalaxy_Auction_Business.Abstraction;
using MyGalaxy_Auction_Business.Concrete;
using MyGalaxy_Auction_Core.Models;
using MyGalaxy_Auction_Data_Access.Context;
using MyGalaxy_Auction_Data_Access.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddPersistenceLayer(builder.Configuration);
builder.Services.AddApplicationLayer(builder.Configuration);
builder.Services.AddSwaggerCollection(builder.Configuration);
builder.Services.AddInfrastructureLayer(builder.Configuration);
builder.Services.AddCors();
builder.Services.Configure<ApiBehaviorOptions>(options => options.SuppressModelStateInvalidFilter = true);
builder.Services.AddSwaggerGen();
//builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddSignalR();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseCors(x => x.AllowAnyMethod().AllowAnyHeader().SetIsOriginAllowed(origin => true).AllowCredentials());
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.MapHub<BidUpdateHub>("/BidUpdate/Hub");
app.UseStaticFiles();   
app.MapControllers();

app.Run();
