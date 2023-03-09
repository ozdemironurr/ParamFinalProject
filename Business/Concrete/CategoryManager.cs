using Business.Abstract;
using Business.Constants;
using Core.Aspects.Autofac.Performance;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;


namespace Business.Concrete
{

    [PerformanceAspect(5)]
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        //Add

        // [ValidationAspect(typeof(ProductValidator))]
        //[CacheRemoveAspect("IProductService.Get")]
        // [SecuredOperation("Admin,User")]
        public IResult Add(Category category)
        {

            _categoryDal.Add(category);
            return new SuccessResult(Messages.CategoryAdded);
        }


        // Delete
        //[SecuredOperation("Admin")]
        //[ValidationAspect(typeof(ProductValidator)]
        // [CacheRemoveAspect("IProductService.Get")]
        public IResult Delete(Category category)
        {
            _categoryDal.Delete(category);
            return new SuccessResult(Messages.CategoryDeleted);
        }


        //Update
        //[SecuredOperation("Admin")]
        // [ValidationAspect(typeof(ProductValidator)]
        // [CacheRemoveAspect("IProductService.Get")]
        public IResult Update(Category category)
        {
            _categoryDal.Update(category);
            return new SuccessResult(Messages.CategoryUpdated);
        }


        //GetAll
        // [SecuredOperation("Admin,User")]
        // [CacheAspect(duration: 10)]
        public IDataResult<List<Category>> GetAll()
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll(), Messages.CategoryListed);
        }



        //[SecuredOperation("Admin,User")]
        // [CacheAspect(duration: 10)]
        public IDataResult<Category> GetById(int categoryId)
        {
            var result = new SuccessDataResult<Category>(_categoryDal.Get(c => c.CategoryId == categoryId), Messages.CategoryListed);
            if (result.Data.CategoryId == null)
            {
                return new ErrorDataResult<Category>(Messages.WrongIdEntry);
            }
            return result;
        }
        // [SecuredOperation("Admin,User")]
        // [CacheAspect(duration: 10)]
        public IDataResult<List<ListProductsByCategoryDto>> GetCategoryDetails(int categoryId)
        {
            return new SuccessDataResult<List<ListProductsByCategoryDto>>(_categoryDal.GetCategoryDetails(categoryId).OrderBy(c => c.CategoryName).ToList());
        }
    }
}
