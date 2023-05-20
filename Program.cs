var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

app.MapControllers();
app.MapGet("test_slowpoke", () =>
{
    long counter = 0;
    for (var i = 0; i < 1_000_000_000; i++)
    {
        counter++;
    }
	
    return "Hello world";
});

app.Run();