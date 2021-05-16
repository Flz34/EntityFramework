﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Customer: IEntity //sen bir veritabanı nesnesisin
    {
        public string CustomerId { get; set; } //çalıştığımız veritabında string türünde tuttuğu için
        public string ContactName { get; set; }
        public string CompanyName { get; set; }
        public string City { get; set; }

    }
}
