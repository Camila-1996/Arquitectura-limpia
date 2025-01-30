using APIPrj.Application.Wrappers;
using APIPrj.Domain.Products.DTOs;
using MediatR;

namespace APIPrj.Application.Features.Products.Queries.GetProductById
{
    public class GetProductByIdQuery : IRequest<BaseResult<ProductDto>>
    {
        public long Id { get; set; }
    }
}
