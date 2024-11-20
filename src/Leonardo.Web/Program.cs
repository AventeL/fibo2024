using Leonardo;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello la catho!");

app.MapGet("/Fibonacci", async () => await Fibonacci.RunAsync(new[] { "44", "43" }));

app.Run();