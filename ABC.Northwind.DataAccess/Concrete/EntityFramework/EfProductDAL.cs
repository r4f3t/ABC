using ABC.Core.DataAccess.EntityFramework;
using ABC.Northwind.DataAccess.Abstract;
using ABC.Northwind.DataAccess.Concrete.EntityFramework;
using ABC.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ABC.Northwind.DataAccess.Concrete
{
    public class EfProductDAL:EfEntityFrameworkBase<Products,NorthwindContext>,IProductDAL
    {
    }
}
