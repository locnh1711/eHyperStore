using eHyperStore.ViewModels.Catalog.Products;
using eHyperStore.ViewModels.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eHyperStore.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetPublicProductPagingRequest request);

        Task<List<ProductViewModel>> GetAll(string languageId);
    }
}