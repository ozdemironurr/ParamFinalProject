using Core.Entities.Concrete;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        List<OperationClaim> GetClaims(User user);
        Task<User> GetByRefreshToken(string refreshToken);
        User GetByMail(string email);
        IResult Update(User user);
        IResult Add(User user);
        IResult Delete(User user);
        IDataResult<User> GetById(int id);
    }
}
