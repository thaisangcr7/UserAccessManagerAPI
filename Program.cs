var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi


// 👇 Service registration section
builder.Services.AddEndpointsApiExplorer();   // enables minimal-API discovery
builder.Services.AddSwaggerGen();             // generates Swagger/OpenAPI docs
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();             // ← add this
    app.UseSwaggerUI();          // ← and this
}

app.UseHttpsRedirection();



app.Run();

