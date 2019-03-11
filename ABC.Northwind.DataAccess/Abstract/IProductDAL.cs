using System;
using System.Collections.Generic;
using System.Text;
using ABC.Core.DataAccess;

using ABC.Northwind.Entities.Concrete;

namespace ABC.Northwind.DataAccess.Abstract
{
    public interface IProductDAL:IEntityRepository<Products>
    {
        // burada özel işlemler yapılacak productse özel
    }
}
