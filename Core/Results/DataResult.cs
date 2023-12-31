﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.Core.Results
{
    public class DataResult<T> : Result
    {
        public T Data { get; set; }
        public DataResult(bool success, string message, T data) : base(success, message)
        {
            Data = data;
        }
    }
}
