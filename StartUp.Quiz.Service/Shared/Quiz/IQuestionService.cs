using StartUp.Quiz.Model.Entities.Quiz;
using StartUp.Quiz.Service.Collections;
using StartUp.Quiz.UnitOfWork.Collections;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StartUp.Quiz.Service.Shared.Quiz
{
    public interface IQuestionService : IServiceBase<Question>
    {
        object CreateWithQuestionChoices(Question question);
    }
}
