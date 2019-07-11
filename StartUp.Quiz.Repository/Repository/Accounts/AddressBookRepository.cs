using StartUp.Quiz.Model;
using StartUp.Quiz.Model.Entities.Accounts;
using StartUp.Quiz.UnitOfWork.Repositories;
using StartUp.Quiz.UnitOfWork.Shared;

namespace StartUp.Quiz.Repository.Repository.Accounts
{
  public class AddressBookRepository : Repository<AddressBook>, IRepository<AddressBook>
  {
    public AddressBookRepository(CRMDBContext dbContext) : base(dbContext)
    {

    }
  }
}
