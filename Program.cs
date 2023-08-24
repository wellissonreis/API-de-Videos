using ApiDeVideos.Data;
using ApiDeVideos.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ApiDeVideos.Services;
using Microsoft.AspNetCore.DataProtection;
using ApiDeVideos.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.AspNetCore.Authorization;


var builder = WebApplication.CreateBuilder(args);
var ConnString = builder.Configuration.GetConnectionString("VideoConnection");

builder.Services.AddSingleton<
    IAuthorizationMiddlewareResultHandler, UsuarioFail>();

// Add services to the container.
//Adicionando a função de conexão no BD
builder.Services.AddDbContext<VideoContext>(opts => opts
    .UseLazyLoadingProxies().UseNpgsql(ConnString));

//Adicionando a função de conexão no BD
//Para gerar a migration com dois context houve a necessidade de gerar a migration com o seguinte comando: 
//Add - Migration TabelaUsuarios - context UsuarioDbContext
//Update-database -context UsuarioDbContext
builder.Services.AddDbContext<UsuarioDbContext>(opts => opts
    .UseLazyLoadingProxies().UseNpgsql(ConnString));

//Estudar sobre pois não entendi muito bem o que isso faz :) 
builder.Services.AddScoped<UsuarioServices, UsuarioServices>();


//Não entendi também só sei que funcionou, vou estuda-lo :) 
builder.Services.AddDataProtection().PersistKeysToFileSystem(new DirectoryInfo(Path.GetTempPath()));

builder.Services.AddScoped<UsuarioServices>();
builder.Services.AddScoped<TokenService>();

builder.Services
    .AddIdentity<Usuario, IdentityRole>()
    .AddEntityFrameworkStores<UsuarioDbContext>()
    .AddDefaultTokenProviders();


builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddControllers().AddNewtonsoftJson(options =>
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
);

//builder.Services.AddSingleton<IAuthorizationHandler, UsuarioAuthorization>();

builder.Services.AddScoped<TokenService>();

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme =
        JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("WellissonCredentialEtomalecaracteresxdxdxd")),
        ValidateAudience = false,
        ValidateIssuer = false,
        ClockSkew = TimeSpan.Zero,
    };
});

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

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
