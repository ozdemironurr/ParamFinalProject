using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    //Kullanıcın seçmiş olduğu listedeki ürünleri getirir
    public class EfSubListDal : EfEntityRepositoryBase<SubList, ParamMarketingDB>, ISubListDal
    {
        public List<GetUserByListsDetailsDto> GetUserByListsDetails(int listId)
        {
            using (var context = new ParamMarketingDB())
            {
                var result = from sl in context.Sublist
                             join tl in context.TopList
                             on sl.ListId equals tl.ListId
                             join p in context.Products
                             on sl.ProductId equals p.ProductId
                             join c in context.Categories
                             on tl.CategoryId equals c.CategoryId
                             where sl.ListId == listId
                             select new GetUserByListsDetailsDto
                             {
                                 ProductName = p.ProductName,
                                 CategoryName = c.CategoryName,

                             };
                return result.ToList();


            }
        }
    }
}
