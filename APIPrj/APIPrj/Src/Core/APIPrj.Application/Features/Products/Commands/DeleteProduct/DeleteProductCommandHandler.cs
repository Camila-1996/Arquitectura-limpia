using System.Threading;
using System.Threading.Tasks;
using APIPrj.Application.Helpers;
using APIPrj.Application.Interfaces;
using APIPrj.Application.Interfaces.Repositories;
using APIPrj.Application.Wrappers;
using MediatR;

namespace APIPrj.Application.Features.Products.Commands.DeleteProduct
{
    public class DeleteProductCommandHandler(IProductRepository productRepository, IUnitOfWork unitOfWork, ITranslator translator) : IRequestHandler<DeleteProductCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var product = await productRepository.GetByIdAsync(request.Id);

            if (product is null)
            {
                return new Error(ErrorCode.NotFound, translator.GetString(TranslatorMessages.ProductMessages.Product_NotFound_with_id(request.Id)), nameof(request.Id));
            }

            productRepository.Delete(product);
            await unitOfWork.SaveChangesAsync();

            return BaseResult.Ok();
        }
    }
}
