using Microsoft.AspNetCore.Builder;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.MapGet("/version", () => new { name = "IsLabApp", version = "0.1.0-lab8" });
app.MapGet("/health", () => new { status = "ok", time = DateTime.UtcNow });
app.MapGet("/db/ping", () => new { status = "ok" });
app.MapGet("/", () => "IsLabApp is working!");
app.Run();
