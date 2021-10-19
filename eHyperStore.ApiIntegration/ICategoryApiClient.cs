using eHyperStore.ViewModels.Catalog.Categories;
using eHyperStore.ViewModels.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eHyperStore.ApiIntegration
{
    public interface ICategoryApiClient
    {
        Task<List<CategoryVm>> GetAll(string languageId);

        Task<CategoryVm> GetById(string languageId, int id);

        Task<ApiResult<PagedResult<CategoryVm>>> GetPagings(GetCategoryPagingRequest request);
    }
}