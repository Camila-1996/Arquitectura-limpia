using APIPrj.Infrastructure.FileManager.Models;
using Microsoft.EntityFrameworkCore;

namespace APIPrj.Infrastructure.FileManager.Contexts
{
    public class FileManagerDbContext(DbContextOptions<FileManagerDbContext> options) : DbContext(options)
    {
        public DbSet<FileEntity> Files { get; set; }
    }
}
