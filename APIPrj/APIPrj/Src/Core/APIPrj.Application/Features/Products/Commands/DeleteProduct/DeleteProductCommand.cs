using APIPrj.Application.Wrappers;
using MediatR;

namespace APIPrj.Application.Features.Products.Commands.DeleteProduct
{
    public class DeleteProductCommand : IRequest<BaseResult>
    {
        public long Id { get; set; }
    }
}
