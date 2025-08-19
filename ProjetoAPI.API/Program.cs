using Microsoft.EntityFrameworkCore;
using ProjetoAPI.API.Data; 


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "chegou aqui!"
};

app.MapGet("/getTesteItalo", () =>
{
    var forecast =  Enumerable.Range(1, 5).Select(index =>
        new RequestTest
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast");

app.Run();

record RequestTest(DateOnly Date, int idX, string? Summary)
{
    public int value => 32 + (int)(idX / 0.5556);
}
