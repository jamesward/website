﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NJekyll.Engine
{
    public class CollectionMetadata
    {
        public string Name { get; set; }
        public string Permalink { get; set; }
        public bool Output { get; set; }
    }
}