using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfTopListDal : EfEntityRepositoryBase<TopList, ParamMarketingDB>, ITopListDal
    {
        // Kullanıcının eklediği listeleri getirir. (okul alışverişi, market alışverişi ...)
        public List<GetUserByListsDto> GetUserByLists(int userId)
        {
            using (var context = new ParamMarketingDB())
            {
                var result = from l in context.TopList
                             join u in context.Users
                             on l.UserId equals u.UserId
                             join c in context.Categories
                             on l.CategoryId equals c.CategoryId
                             where l.UserId == userId
                             select new GetUserByListsDto
                             {
                                 CategoryName = c.CategoryName
                             };
                return result.ToList();


            }



        }
    }
}
