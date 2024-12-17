using ChainOfResponsibilityPattern.Abstract;
using ChainOfResponsibilityPattern.Concrete;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddLogging();

builder.Services.AddKeyedTransient<IHandler,DealerHandler>("dealerHandler");
builder.Services.AddKeyedTransient<IHandler,FraudCheckHandler>("fraudCheckHandler");
builder.Services.AddKeyedTransient<IHandler,PaymentHandler>("paymentHandler");


builder.Services.AddControllers();
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
