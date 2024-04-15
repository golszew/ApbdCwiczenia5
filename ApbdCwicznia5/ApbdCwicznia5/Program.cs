using ApbdCwicznia5.Database;
using Microsoft.AspNetCore.Http.HttpResults;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//To trzeba dodac tworzac kontrolery
builder.Services.AddControllers();
//Zawsze bedzie ta sama instancja tej klasy
// builder.Services.AddSingleton<MockDb>();

var app = builder.Build();

// Configure the HTTP request pipeline.
// to wyzej to to samo co cat file / grep to co bylo w poprzedniej komendzie przekazujemy do nastepnej
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


// Controlers
//to rowniez przy tworzeniu kontrolerow
app.MapControllers();

app.Run();

