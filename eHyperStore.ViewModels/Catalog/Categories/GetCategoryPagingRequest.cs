using eHyperStore.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace eHyperStore.ViewModels.Catalog.Categories
{
    public class GetCategoryPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }

        public string LanguageId { get; set; }
    }
}