using Monbsoft.CocherBusiness.Product.Domain;
using System.Threading.Tasks;

namespace Monbsoft.CocherBusiness.Product.Domain.Interfaces
{
    public interface IProductRepository
    {
        Task<ProductItem> GetAsync(string productId);
    }
}