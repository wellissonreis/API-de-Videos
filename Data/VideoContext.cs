using Alura_Challenge_Backend_Semana_1.Models;
using Microsoft.EntityFrameworkCore;

namespace Alura_Challenge_Backend_Semana_1.Data;

public class VideoContext : DbContext
{
    public VideoContext(DbContextOptions<VideoContext> opts) : base(opts)
    {
            
    }
    public DbSet<Videos> videos { get; set; }
    public DbSet<Categorias> categorias { get; set; }
}
