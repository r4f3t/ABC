using ABC.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ABC.Northwind.Business.Abstract
{
    public interface IProductService
    {
        //burada product için özel kurallı işlemler yer alır.
        List<Products> GetAll();
        Products GetById(int id);
        List<Products> GetByCategoryId(int categoryId);
    }
}
