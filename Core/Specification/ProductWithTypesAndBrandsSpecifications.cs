using System;
using System.Linq.Expressions;
using Core.Entities;

namespace Core.Specification
{
    public class ProductWithTypesAndBrandsSpecifications : BaseSpecification<Product>
    {
        public ProductWithTypesAndBrandsSpecifications()
        {
            AddInclude(p => p.ProductType);
            AddInclude(p => p.ProductBrand);
        }

        public ProductWithTypesAndBrandsSpecifications(int id) 
           : base(p => p.Id == id)
        {
            AddInclude(p => p.ProductType);
            AddInclude(p => p.ProductBrand);
        }
    }
}