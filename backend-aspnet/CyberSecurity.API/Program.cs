using CyberSecurity.API.Data;
using CyberSecurity.API.Middleware;
using CyberSecurity.API.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CyberDB")));

// Services
builder.Services.AddScoped<RequestLogService>();
builder.Services.AddScoped<DetectionService>();
builder.Services.AddHttpClient<ApiClientService>();
builder.Services.AddHttpClient<HttpClient>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Middleware
app.UseMiddleware<RequestLoggingMiddleware>();
app.Services.CreateScope().ServiceProvider.GetRequiredService<AppDbContext>().Database.Migrate();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
