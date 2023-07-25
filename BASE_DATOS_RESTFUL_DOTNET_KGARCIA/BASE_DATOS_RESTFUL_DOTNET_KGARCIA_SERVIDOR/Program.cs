using BASE_DATOS_RESTFUL_DOTNET_KGARCIA_SERVIDOR.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
            policy =>
            {
                policy.AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod();
            });
});

var conexion = builder.Configuration.GetConnectionString(name: "DefaultConnection");

builder.Services.AddDbContext<IntegracionContext>(optionsAction: options =>
    options.UseMySql(conexion, ServerVersion.AutoDetect(conexion)));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
