using homework18_12;

var builder = WebApplication.CreateBuilder(args);

builder.Logging.AddConsole();

builder.Services.AddLogging();
builder.Services.AddSingleton<Chessboard>();

var app = builder.Build();

async Task Chess(HttpContext context, Chessboard chessboard)
{
    chessboard.PrintBoard();
    await context.Response.WriteAsync("<p>Wrote to console!</p>");
}

app.MapGet("/chess", Chess);

app.Run();
