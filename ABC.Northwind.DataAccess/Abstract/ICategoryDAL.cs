using ABC.Core.DataAccess;

using ABC.Northwind.Entities.Concrete;

namespace ABC.Northwind.DataAccess.Abstract
{
    public interface ICategoryDAL : IEntityRepository<Category>
    {
        // burada özel işlemler yapılacak productse özel
    }
}
