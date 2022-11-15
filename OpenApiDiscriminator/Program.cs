using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

// Specify multiple swagger docs. By convention, Swashbuckle will the map each document's name to operations with a
// matching ApiExplorerSettingsAttribute on GroupName. See Controllers for details.
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("private", new OpenApiInfo());
    c.SwaggerDoc("public", new OpenApiInfo());
});

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/public/swagger.json", "public");
        c.SwaggerEndpoint("/swagger/private/swagger.json", "private");
    });
}

app.UseAuthorization();
app.MapControllers();
app.Run();