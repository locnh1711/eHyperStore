using eHyperStore.ViewModels.Common;
using eHyperStore.ViewModels.System.Languages;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eHyperStore.ApiIntegration
{
    public interface ILanguageApiClient
    {
        Task<ApiResult<List<LanguageVm>>> GetAll();
    }
}