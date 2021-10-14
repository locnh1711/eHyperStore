using eHyperStore.ViewModels.Catalog.Categories;
using eHyperStore.ViewModels.Catalog.Products;
using eHyperStore.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eHyperStore.WebApp.Models
{
    public class ProductCategoryViewModel
    {
        public CategoryVm Category { get; set; }

        public PagedResult<ProductVm> Products { get; set; }
    }
}