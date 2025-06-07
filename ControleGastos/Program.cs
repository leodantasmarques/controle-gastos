using ControleGastos.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Configurações de serviços
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configura o DbContext com a string de conexão
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

// Configura o CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader());
});

// Configura o redirecionamento HTTPS
builder.Services.AddHttpsRedirection(options =>
{
    options.HttpsPort = 5001;  // Porta HTTPS desejada
});

var app = builder.Build();

// Configuração do Swagger (apenas em desenvolvimento)
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Ativa o CORS
app.UseCors("AllowAll");

// Habilita o redirecionamento HTTPS
//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
