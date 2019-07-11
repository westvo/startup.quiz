using StartUp.Quiz.Model;
using StartUp.Quiz.Model.Entities.Accounts;
using StartUp.Quiz.UnitOfWork.Repositories;
using StartUp.Quiz.UnitOfWork.Shared;

namespace StartUp.Quiz.Repository.Repository.Accounts
{
  public class AccountRepository : Repository<Account>, IRepository<Account>
  {
    public AccountRepository(CRMDBContext dbContext) : base(dbContext)
    {

    }
  }
}
