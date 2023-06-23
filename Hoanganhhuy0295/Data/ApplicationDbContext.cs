using Hoanganhhuy0295.Models;
using Microsoft.EntityFrameworkCore;

namespace Hoanganhhuy0295.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    public DbSet<Student> Students { get; set; }
}