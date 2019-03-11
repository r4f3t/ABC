using ABC.Core.DataAccess.EntityFramework;
using ABC.Northwind.DataAccess.Abstract;
using ABC.Northwind.DataAccess.Concrete.EntityFramework;
using ABC.Northwind.Entities.Concrete;

namespace ABC.Northwind.DataAccess.Concrete
{
    public class EfCategoryDAL : EfEntityFrameworkBase<Category, NorthwindContext>, ICategoryDAL
    {
    }
}
