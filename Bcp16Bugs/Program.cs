// See https://aka.ms/new-console-template for more information

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;


var builder = WebApplication.CreateBuilder(args);
builder.Services
    .AddGraphQLServer()
    .AddQueryType()
    .AddTypeExtension<QueryExtensions>();
    
var app = builder.Build();
app.MapGraphQL();
app.Run();