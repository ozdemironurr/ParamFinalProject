using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ISubListService
    {
        IDataResult<List<SubList>> GetAll();// programın büyüklüğüne göre özelleştirilir
        IDataResult<SubList> GetById(int subListId);
        IDataResult<List<GetUserByListsDetailsDto>> GetUserByListsDetails(int toplistId);
        IResult Add(SubList subList);
        IResult Delete(SubList subList);
    }
}
