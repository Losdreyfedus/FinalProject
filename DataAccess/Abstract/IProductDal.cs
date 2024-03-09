using Core.DataAccess;
using DataAccess.Concrete.Entity_Framework;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
       List<ProductDetailDto> GetProductDetails();
    }
}

//Code Refactoring