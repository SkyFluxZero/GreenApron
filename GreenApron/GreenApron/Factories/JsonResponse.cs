﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenApron
{
    public class JsonResponse
    {
        public bool success { get; set; }
        public string message { get; set; }
        public User user { get; set; }
    }
}
