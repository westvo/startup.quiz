using StartUp.Quiz.Model;
using StartUp.Quiz.Model.Entities.Accounts;
using StartUp.Quiz.UnitOfWork.Repositories;
using StartUp.Quiz.UnitOfWork.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp.Quiz.Repository.Repository.Accounts
{
  public class AccountAuditRepository : Repository<AccountAudit>, IRepository<AccountAudit>
  {
    public AccountAuditRepository(CRMDBContext dbContext) : base(dbContext)
    {

    }
  }
}
