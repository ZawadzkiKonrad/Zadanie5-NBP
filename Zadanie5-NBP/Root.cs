﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie5_NBP
{
    public class Root
    {
        public string table { get; set; }
        public string currency { get; set; }
        public string code { get; set; }
        public List<Rate> rates { get; set; }
    }
}
