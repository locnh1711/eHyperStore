using eHyperStore.Application.Catalog.Products.Dtos;
using eHyperStore.Application.Catalog.Products.Dtos.Public;
using eHyperStore.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eHyperStore.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetProductPagingRequest request);
    }
}