using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp.Quiz.Model.Entities.Accounts
{
    public class AccountType : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
    }
}
