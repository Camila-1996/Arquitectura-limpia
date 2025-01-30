using System.Reflection.Emit;
using System.Threading;
using System.Threading.Tasks;
using APIPrj.Application.Interfaces;
using APIPrj.Domain.Factura.Entities;
using APIPrj.Domain.Products.Entities;
using APIPrj.Infrastructure.Persistence.Extensions;
using Microsoft.EntityFrameworkCore;

namespace APIPrj.Infrastructure.Persistence.Contexts
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IAuthenticatedUserService authenticatedUser) : DbContext(options)
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<CatProducto> CatProductos { get; set; }
        public DbSet<CatTipoCliente> CatTipoClientes { get; set; }
        public DbSet<TblCliente> TblClientes { get; set; }
        public DbSet<TblFactura> TblFacturas { get; set; }
        public DbSet<TblDetallesFactura> TblDetallesFacturas { get; set; }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            ChangeTracker.ApplyAuditing(authenticatedUser);

            return base.SaveChangesAsync(cancellationToken);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            this.ConfigureDecimalProperties(builder);

            base.OnModelCreating(builder);
        }
    }
}