using Microsoft.EntityFrameworkCore;
using StartUp.Helper;
using StartUp.Quiz.Model.Entities.Quiz;
using StartUp.Quiz.Service.Collections;
using StartUp.Quiz.Service.Shared.Quiz;
using StartUp.Quiz.UnitOfWork.Collections;
using StartUp.Quiz.UnitOfWork.Shared;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StartUp.Quiz.Service.Implements.Quiz
{
    public class CategoryService : ServiceBase<Category>, IServiceBase<Category>, ICategoryService
    {
        IUnitOfWork _unitOfWork;
        public CategoryService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<object> GetQuestions(Guid id)
        {
            var category = await _unitOfWork.GetRepository<Category>().GetFirstOrDefaultAsync(predicate: p=>p.Id==id, include: c => c.Include(s => s.Questions));
            return Ultilities.ConvertModelToString(category);
        }
    }
}
