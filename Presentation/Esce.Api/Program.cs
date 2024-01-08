using Esce.Persistence;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddPersistenceServices();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var env = builder.Environment;
builder.Configuration
    .SetBasePath(env.ContentRootPath) // Uygulamanın kök dizinini yapılandırma dosyalarını aramak için belirler.
    .AddJsonFile("appsettings.json", optional: false) // Ana yapılandırma dosyası (appsettings.json) yüklenir. Bulunmazsa hata verir.
    .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true); // Ortama özgü yapılandırma dosyası yüklenir (örneğin, appsettings.Development.json). Bulunmazsa sorun çıkarmaz.



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
