using eHyperStore.Data.EF;
using eHyperStore.ViewModels.Common;
using eHyperStore.ViewModels.System.Languages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eHyperStore.Application.System.Languages
{
    public class LanguageService : ILanguageService
    {
        private readonly IConfiguration _config;
        private readonly EHyperDbContext _context;

        public LanguageService(EHyperDbContext context, IConfiguration config)
        {
            _config = config;
            _context = context;
        }

        public async Task<ApiResult<List<LanguageVm>>> GetAll()
        {
            var languages = await _context.Languages.Select(x => new LanguageVm()
            {
                Id = x.Id,
                Name = x.Name
            }).ToListAsync();
            return new ApiSuccessResult<List<LanguageVm>>(languages);
        }
    }
}