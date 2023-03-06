using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, ParamMarketingDB>, ICategoryDal
    {
        public List<ListProductsByCategoryDto> GetCategoryDetails(int categoryId)
        {
            using (var context = new ParamMarketingDB())
            {
                var result = from c in context.Categories
                             join p in context.Products
                             on c.CategoryId equals p.CategoryId
                             where c.CategoryId == categoryId
                             select new ListProductsByCategoryDto
                             {
                                 ProductName = p.ProductName,
                                 CategoryName = c.CategoryName,
                                 Unit = p.Unit,
                                 Price = p.Price

                             };
                return result.ToList();


            }
        }
    }
}
