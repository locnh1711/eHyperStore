﻿using eHyperStore.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace eHyperStore.Application.Catalog.Products.Dtos.Public
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public int? CategoryId { get; set; }
    }
}