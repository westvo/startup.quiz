using StartUp.Quiz.Model;
using StartUp.Quiz.Model.Entities.Accounts;
using StartUp.Quiz.UnitOfWork.Repositories;
using StartUp.Quiz.UnitOfWork.Shared;

namespace StartUp.Quiz.Repository.Repository.Accounts
{
  public class ContactAuditRepository : Repository<ContactAudit>, IRepository<ContactAudit>
  {
    public ContactAuditRepository(CRMDBContext dbContext) : base(dbContext)
    {

    }
  }
}
