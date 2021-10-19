﻿using System;
using System.Collections.Generic;
using System.Text;

namespace eHyperStore.ViewModels.Catalog.Categories
{
    public class CategoryCreateRequest
    {
        public string Name { get; set; }

        public string SeoDescription { get; set; }

        public string SeoTitle { get; set; }

        public string LanguageId { get; set; }

        public string SeoAlias { get; set; }
    }
}