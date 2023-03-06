using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class TopListManager : ITopListService
    {
        private readonly ITopListDal _topListDal;
        public TopListManager(ITopListDal topListDal)
        {
            _topListDal = topListDal;

        }
        // [SecuredOperation("Admin,User")]

        public IResult Add(TopList list)
        {

            _topListDal.Add(list);
            return new SuccessResult(Messages.TopListAdd);

        }
        // [SecuredOperation("Admin,User")]
        public IResult Delete(TopList list)
        {

            _topListDal.Add(list);
            return new SuccessResult(Messages.TopListDelete);
        }
        // [SecuredOperation("Admin,User")]
        public IDataResult<List<TopList>> GetAll()
        {
            return new SuccessDataResult<List<TopList>>(_topListDal.GetAll().OrderBy(p => p.UserId).ToList(), Messages.AllListForTopList);

        }
        // [SecuredOperation("Admin,User")]
        public IDataResult<TopList> GetById(int listId)
        {
            var result = new SuccessDataResult<TopList>(_topListDal.Get(l => l.ListId == listId));
            if (result.Data == null)
            {
                return new ErrorDataResult<TopList>(Messages.WrongIdEntry);
            }
            return result;

        }

        public IDataResult<List<GetUserByListsDto>> GetUserByLists(int topListId)
        {

            var result = new SuccessDataResult<List<GetUserByListsDto>>(_topListDal.GetUserByLists(topListId).ToList(), Messages.CategoryListed);
            if (result.Data.Count() == 0)
            {
                return new ErrorDataResult<List<GetUserByListsDto>>(Messages.WrongIdEntry);
            }
            return result;

        }

        //public IDataResult<List<SearchingByCreationCompletionDateOfListDto>> SearchingByCreationCompletionDateOfListDateils(DateTime CreationDate, DateTime CompletionDate)
        //{

        //    var result = new SuccessDataResult<List<SearchingByCreationCompletionDateOfListDto>>(_topListDal.GetAll(c => c.CreationDate >= CreationDate && c.CompletionDate <= CompletionDate));
        //    if (result.Data == null)
        //    {
        //        return new ErrorDataResult<TopList>(Messages.WrongIdEntry);
        //    }
        //    return result;
        //}
    }
}
