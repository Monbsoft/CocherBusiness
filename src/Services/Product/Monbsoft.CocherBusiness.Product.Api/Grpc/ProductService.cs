using Grpc.Core;
using Microsoft.Extensions.Logging;
using Monbsoft.CocherBusiness.Product.Domain.Interfaces;
using System.Threading.Tasks;
using static Monbsoft.Services.Product.Api.Product;

namespace Monbsoft.Services.Product.Api.Grpc
{
    public class ProductService : ProductBase
    {
        private readonly IProductRepository _productRepository;
        private readonly ILogger _logger;

        public ProductService(IProductRepository productRepository, ILogger<ProductService> logger)
        {
            _productRepository = productRepository;
            _logger = logger;
        }


        public override Task<ProductResponse> GetProductById(ProductRequest request, ServerCallContext context)
        {
            _logger.LogDebug("Getting Product id: {Id}...", request.Id);
            if(string.IsNullOrEmpty(request.Id))
            {
                context.Status = new Status(StatusCode.FailedPrecondition, $"Id must not be null (received {request.Id}).");
                return null;
            }


            return base.GetProductById(request, context);
        }
    }
}
