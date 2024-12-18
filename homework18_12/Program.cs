using homework18_12;

var builder = WebApplication.CreateBuilder(args);

builder.Logging.AddConsole();

builder.Services.AddLogging();
builder.Services.AddSingleton<Chessboard>();

var app = builder.Build();

string Chess(Chessboard chessboard)
{
    chessboard.PrintBoard();
    return "<p>Printed to console!</p>";
}

app.MapGet("/chess", Chess);

app.Run();
