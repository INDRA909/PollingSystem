using PollingSystem.Web.Definitions.Base;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDefinition(builder,typeof(Program));

var app = builder.Build();
app.UseDefinition();
