using System.Threading;
using System.Threading.Tasks;
using APIPrj.Application.Interfaces.Repositories;
using APIPrj.Application.Wrappers;
using APIPrj.Domain.Products.DTOs;
using MediatR;

namespace APIPrj.Application.Features.Products.Queries.GetPagedListProduct
{
    public class GetPagedListProductQueryHandler(IProductRepository productRepository) : IRequestHandler<GetPagedListProductQuery, PagedResponse<ProductDto>>
    {
        public async Task<PagedResponse<ProductDto>> Handle(GetPagedListProductQuery request, CancellationToken cancellationToken)
        {
            return await productRepository.GetPagedListAsync(request.PageNumber, request.PageSize, request.Name);
        }
    }
}
