using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp.Quiz.Model.Entities.Accounts
{
    public class Industry : BaseEntity
    {
        public string Name { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
    }
}
