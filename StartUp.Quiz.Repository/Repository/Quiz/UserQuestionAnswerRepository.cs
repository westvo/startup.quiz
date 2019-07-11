using StartUp.Quiz.Model;
using StartUp.Quiz.Model.Entities.Quiz;
using StartUp.Quiz.UnitOfWork.Repositories;
using StartUp.Quiz.UnitOfWork.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp.Quiz.Repository.Repository.Quiz
{
    public class UserQuestionAnswerRepository : Repository<UserQuestionAnswer>, IRepository<UserQuestionAnswer>
    {
        public UserQuestionAnswerRepository(CRMDBContext dbContext) : base(dbContext)
        {

        }
    }
}
