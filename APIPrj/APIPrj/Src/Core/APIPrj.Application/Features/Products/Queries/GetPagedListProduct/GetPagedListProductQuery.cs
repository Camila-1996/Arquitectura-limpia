using APIPrj.Application.Parameters;
using APIPrj.Application.Wrappers;
using APIPrj.Domain.Products.DTOs;
using MediatR;

namespace APIPrj.Application.Features.Products.Queries.GetPagedListProduct
{
    public class GetPagedListProductQuery : PaginationRequestParameter, IRequest<PagedResponse<ProductDto>>
    {
        public string Name { get; set; }
    }
}
