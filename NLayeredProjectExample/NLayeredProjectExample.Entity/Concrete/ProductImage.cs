﻿using NLayeredProjectExample.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLayeredProjectExample.Entity.Concrete
{
    public class ProductImage :IEntity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string AddedBy { get; set; }
        public DateTime AddedDate { get; set; }
    }
}
