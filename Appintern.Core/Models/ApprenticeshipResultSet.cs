﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Core.Models.PublishedContent;

namespace Appintern.Core.Models
{
    public class ApprenticeshipResultSet
    {
        public IEnumerable<IPublishedContent> Results { get; set; }

        public int PageSize { get; set; }

        public int PageNumber { get; set; }

        public double PageCount { get; set; }

        public bool IsApprenticeshipListPage { get; set; }

        public string Url { get; set; }

    }
}
