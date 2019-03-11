using ABC.Northwind.Business.Abstract;
using ABC.Northwind.DataAccess.Abstract;
using ABC.Northwind.Entities.Concrete;
using System.Collections.Generic;

namespace ABC.Northwind.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDAL categoryDAL;
        public CategoryManager(ICategoryDAL _categoryDAL)
        {
            categoryDAL = _categoryDAL;
        }
        public List<Category> GetAll()
        {
            return categoryDAL.GetList();
        }
    }
}
