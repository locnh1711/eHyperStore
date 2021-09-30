using eHyperStore.ViewModels.Common;
using eHyperStore.ViewModels.System.Languages;
using eHyperStore.ViewModels.System.Users;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eHyperStore.Application.System.Languages
{
    public interface ILanguageService
    {
        Task<ApiResult<List<LanguageVm>>> GetAll();
    }
}