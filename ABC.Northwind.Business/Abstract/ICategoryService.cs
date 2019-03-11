using ABC.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ABC.Northwind.Business.Abstract
{
   public interface ICategoryService
    {
        List<Category> GetAll();
    }
}
