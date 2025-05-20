using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGeneration.EntityFrameworkCore;
using NuGet.Protocol.Plugins;
using WebApplication1.Models;

namespace WebApplication1.DataAccessLayer;

public class SafeCamDbContext : DbContext
{
    public SafeCamDbContext(DbContextOptions options): base(options)
    {
        
    }
    public DbSet<Person> People { get; set; }
    public DbSet<Profession> Professions { get; set; }

}
