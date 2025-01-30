using System.Linq;
using System.Threading.Tasks;
using APIPrj.Application.DTOs;
using APIPrj.Application.Interfaces.Repositories;
using APIPrj.Domain.Products.DTOs;
using APIPrj.Domain.Products.Entities;
using APIPrj.Infrastructure.Persistence.Contexts;

namespace APIPrj.Infrastructure.Persistence.Repositories
{
    public class ProductRepository(ApplicationDbContext dbContext) : GenericRepository<Product>(dbContext), IProductRepository
    {
        public async Task<PaginationResponseDto<ProductDto>> GetPagedListAsync(int pageNumber, int pageSize, string name)
        {
            var query = dbContext.Products.OrderBy(p => p.Created).AsQueryable();

            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(p => p.Name.Contains(name));
            }

            return await Paged(
                query.Select(p => new ProductDto(p)),
                pageNumber,
                pageSize);

        }
    }
}
