using DataAccessLayer.Abstract;
using FoodyTekmerEntityLayer.Concreate;
using FoodyTemkerBussinesLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodyTemkerBussinesLayer.Config
{
    public class ProductManagment : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManagment(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void TAdd(Product entity)
        {
            if(entity.Name != "" && entity.Name.Length >= 3 && entity.NewPrice > 0)
            {
                _productDal.Add(entity);
            }else
            {
                // Hata Mesajı
            }
        }

        public void TDelete(int id)
        {
            _productDal.Delete(id);
        }

        public void TUpdate(Product entity)
        {
            _productDal.Update(entity);
        }

        public List<Product> TGetAllList()
        {
            return _productDal.GetAllList();
        }

        public Product GetById(int id)
        {
            return _productDal.GetById(id);
        }


    }
}
