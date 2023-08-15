using ApiDeVideos.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiDeVideos.Data;

public class VideoContext : DbContext
{
    public VideoContext(DbContextOptions<VideoContext> opts) : base(opts)
    {
            
    }
    public DbSet<Videos> videos { get; set; }
    public DbSet<Categorias> categorias { get; set; }
}
