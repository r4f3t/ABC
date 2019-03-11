using ABC.Northwind.Business.Abstract;
using ABC.Northwind.DataAccess.Abstract;
using ABC.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ABC.Northwind.Business.Concrete
{
    public class ProductManager:IProductService
    {
        private IProductDAL productDAL; 
        public ProductManager(IProductDAL _productDAL)
        {
            productDAL = _productDAL;
        }

        public List<Products> GetAll()
        {
            return productDAL.GetList();
        }

        public List<Products> GetByCategoryId(int categoryId)
        {
            return productDAL.GetList(p=>p.CategoryID==categoryId);
        }

        public Products GetById(int id)
        {
            return productDAL.Get(p => p.ProductID == id);
        }
    }
}
