using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class SubListManager : ISubListService
    {
        private readonly ISubListDal _subListDal;
        public SubListManager(ISubListDal subListDal)
        {
            _subListDal = subListDal;

        }
        //[SecuredOperation("Admin,User")]
        public IResult Add(SubList list)
        {

            _subListDal.Add(list);
            return new SuccessResult(Messages.SubListAdd);

        }
        //[SecuredOperation("Admin,User")]
        public IResult Delete(SubList list)
        {

            _subListDal.Add(list);
            return new SuccessResult(Messages.TopListDelete);
        }
        // [SecuredOperation("Admin,User")]
        public IDataResult<List<SubList>> GetAll()
        {
            return new SuccessDataResult<List<SubList>>(_subListDal.GetAll(), Messages.ProductsListed);

        }
        // [SecuredOperation("Admin,User")]
        public IDataResult<SubList> GetById(int listId)
        {
            var result = new SuccessDataResult<SubList>(_subListDal.Get(l => l.SubListId == listId));
            if (result.Data == null)
            {
                return new ErrorDataResult<SubList>(Messages.WrongIdEntry);
            }
            return result;

        }

        public IDataResult<List<GetUserByListsDetailsDto>> GetUserByListsDetails(int userId)
        {
            var result = new SuccessDataResult<List<GetUserByListsDetailsDto>>(_subListDal.GetUserByListsDetails(userId).ToList(), Messages.CategoryListed);
            if (result.Data.Count() == 0)
            {
                return new ErrorDataResult<List<GetUserByListsDetailsDto>>(Messages.WrongIdEntry);
            }
            return result;
        }
    }
}
