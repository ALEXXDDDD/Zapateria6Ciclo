﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponse.Response
{
    public class ReponseFilterGeneric<T>
    {
        public int TotalRegistros { get; set; }
        public List<T> Lista { get; set; } = new List<T>();
    }
}
