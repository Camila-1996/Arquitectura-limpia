using System.Threading.Tasks;
using APIPrj.Application.DTOs;
using APIPrj.Domain.Products.DTOs;
using APIPrj.Domain.Products.Entities;

namespace APIPrj.Application.Interfaces.Repositories
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Task<PaginationResponseDto<ProductDto>> GetPagedListAsync(int pageNumber, int pageSize, string name);
    }
}
