using ABC.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace ABC.Northwind.Entities.Concrete
{
    public class Category : IEntity
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
    }
}
