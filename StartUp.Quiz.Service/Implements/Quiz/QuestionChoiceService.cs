using StartUp.Quiz.Model.Entities.Quiz;
using StartUp.Quiz.Service.Collections;
using StartUp.Quiz.Service.Shared.Quiz;
using StartUp.Quiz.UnitOfWork.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp.Quiz.Service.Implements.Quiz
{
    public class QuestionChoiceService : ServiceBase<QuestionChoice>, IServiceBase<QuestionChoice>, IQuestionChoiceService
    {
        IUnitOfWork _unitOfWork;
        public QuestionChoiceService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
