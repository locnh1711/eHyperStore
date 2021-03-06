using eHyperStore.ViewModels.Common;
using eHyperStore.ViewModels.System.Roles;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eHyperStore.ApiIntegration
{
    public interface IRoleApiClient
    {
        Task<ApiResult<List<RoleVm>>> GetAll();
    }
}