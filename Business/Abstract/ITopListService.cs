using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ITopListService
    {
        IDataResult<List<TopList>> GetAll();// programın büyüklüğüne göre özelleştirilir
        IDataResult<TopList> GetById(int listId);
        IDataResult<List<GetUserByListsDto>> GetUserByLists(int userId);
        IResult Add(TopList list);
        IResult Delete(TopList list);
    }
}
