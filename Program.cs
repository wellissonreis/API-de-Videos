using ApiDeVideos.Data;
using ApiDeVideos.Models;
using ApiDeVideos.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Alura_Challenge_Backend_Semana_1.Migrations;
using Microsoft.EntityFrameworkCore.Migrations;
using ApiDeVideos.Services;
using Microsoft.AspNetCore.DataProtection;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
//Adicionando a função de conexão no BD
builder.Services.AddDbContext<VideoContext>(opts => opts
    .UseLazyLoadingProxies().UseNpgsql(builder.Configuration.GetConnectionString("VideoConnection")));

//Adicionando a função de conexão no BD
//Para gerar a migration com dois context houve a necessidade de gerar a migration com o seguinte comando: 
//Add - Migration TabelaUsuarios - context UsuarioDbContext
//Update-database -context UsuarioDbContext
builder.Services.AddDbContext<UsuarioDbContext>(opts => opts
    .UseLazyLoadingProxies().UseNpgsql(builder.Configuration.GetConnectionString("VideoConnection")));

//Estudar sobre pois não entendi muito bem o que isso faz :) 
builder.Services.AddScoped<UsuarioServices, UsuarioServices>();


//Não entendi também só sei que funcionou, vou estuda-lo :) 
builder.Services.AddDataProtection().PersistKeysToFileSystem(new DirectoryInfo(Path.GetTempPath()));


builder.Services
    .AddIdentity<Usuario, IdentityRole>()
    .AddEntityFrameworkStores<UsuarioDbContext>()
    .AddDefaultTokenProviders();


builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddControllers().AddNewtonsoftJson(options =>
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
);



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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
