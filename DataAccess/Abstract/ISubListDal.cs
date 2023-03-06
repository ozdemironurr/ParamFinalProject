using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface ISubListDal : IEntityRepository<SubList>
    {
        List<GetUserByListsDetailsDto> GetUserByListsDetails(int listId);
    }
}
