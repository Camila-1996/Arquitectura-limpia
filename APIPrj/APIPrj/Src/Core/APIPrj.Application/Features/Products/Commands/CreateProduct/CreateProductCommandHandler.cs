using System.Threading;
using System.Threading.Tasks;
using APIPrj.Application.Interfaces;
using APIPrj.Application.Interfaces.Repositories;
using APIPrj.Application.Wrappers;
using APIPrj.Domain.Products.Entities;
using MediatR;

namespace APIPrj.Application.Features.Products.Commands.CreateProduct
{
    public class CreateProductCommandHandler(IProductRepository productRepository, IUnitOfWork unitOfWork) : IRequestHandler<CreateProductCommand, BaseResult<long>>
    {
        public async Task<BaseResult<long>> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product(request.Name, request.Price, request.BarCode);

            await productRepository.AddAsync(product);
            await unitOfWork.SaveChangesAsync();

            return product.Id;
        }
    }
}
