using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryBrandDal : IBrandDal
    {
        List<Brand> _brands;
        public InMemoryBrandDal()
        {
            _brands = new List<Brand>
            {
                new Brand{BrandId=1, BrandName = "BMW"},
                new Brand{BrandId=2, BrandName = "Mercedes"},
                new Brand{BrandId=3, BrandName = "Audi"},
                new Brand{BrandId=4, BrandName = "Mustang"},
                new Brand{BrandId=5, BrandName = "Ferrari"},
            };
        }

        public void Add(Brand brand)
        {
            _brands.Add(brand);
        }

        public void Delete(Brand brand)
        {
            Brand brandToDelete = _brands.SingleOrDefault(c => c.BrandId == brand.BrandId);

            _brands.Remove(brandToDelete);
        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            return _brands.Where(c => c.BrandId > 0).SingleOrDefault();
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            return _brands;
        }

        public void Update(Brand brand)
        {
            Brand brandToDelete = _brands.SingleOrDefault(c => c.BrandId == brand.BrandId);
            brandToDelete.BrandId = brand.BrandId;
        }
    }
}