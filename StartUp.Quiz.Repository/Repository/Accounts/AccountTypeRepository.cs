using StartUp.Quiz.Model;
using StartUp.Quiz.Model.Entities.Accounts;
using StartUp.Quiz.UnitOfWork.Repositories;
using StartUp.Quiz.UnitOfWork.Shared;

namespace StartUp.Quiz.Repository.Repository.Accounts
{
  public class AccountTypeRepository : Repository<AccountType>, IRepository<AccountType>
  {
    public AccountTypeRepository(CRMDBContext dbContext) : base(dbContext)
    {

    }
  }
}
