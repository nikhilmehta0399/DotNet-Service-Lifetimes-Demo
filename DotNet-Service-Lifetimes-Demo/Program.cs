using DotNet_Service_Lifetimes_Demo.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

// Change one of these lines to test different lifetimes:
 //builder.Services.AddTransient<IGuidService, GuidService>();
 builder.Services.AddScoped<IGuidService, GuidService>();
//builder.Services.AddSingleton<IGuidService, GuidService>();

builder.Services.AddSwaggerGen();

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
