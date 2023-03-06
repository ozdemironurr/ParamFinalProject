using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface ITopListDal : IEntityRepository<TopList>
    {
        List<GetUserByListsDto> GetUserByLists(int userId);
    }
}
