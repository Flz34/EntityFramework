using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //interface metotları default public tir
    public interface IProductDal:IEntityRepository<Product>
    {
        
    }
}
