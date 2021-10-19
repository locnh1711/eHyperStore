using eHyperStore.ViewModels.Catalog.Categories;
using eHyperStore.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eHyperStore.Application.Catalog.Categories
{
    public interface ICategoryService
    {
        Task<List<CategoryVm>> GetAll(string languageId);

        Task<CategoryVm> GetById(string languageId, int id);

        Task<ApiResult<PagedResult<CategoryVm>>> GetCategoryPaging(GetCategoryPagingRequest request, string languageId);
    }
}