var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.MapGet("/", () => "Worker process name : " + System.Diagnostics.Process.GetCurrentProcess().ProcessName);

app.Run();  