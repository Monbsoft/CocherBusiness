using Grpc.Core;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Monbsoft.CocherBusiness.Product.Infrastructure.Data;
using System.Threading.Tasks;
using static Monbsoft.Services.Product.Api.Product;

namespace Monbsoft.Services.Product.Api.Grpc
{
    public class ProductService : ProductBase
    {
        private readonly ProductDataContext _productContext;
        private readonly ILogger _logger;

        public ProductService(ProductDataContext context, IOptions<ProductSettings> settings, ILogger<ProductService> logger)
        {
            _productContext = context;
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
