using Microsoft.Extensions.DependencyInjection;
using StartUp.Quiz.Model.Entities.Accounts;
using StartUp.Quiz.Model.Entities.Quiz;     
using StartUp.Quiz.Repository.Repository.Accounts;
using StartUp.Quiz.Repository.Repository.Quiz;
using StartUp.Quiz.UnitOfWork.Shared;

namespace StartUp.Quiz.Repository.Extension
{
    public static class RepositoryCollection
    {
        public static IServiceCollection AddRepositoriesInstance(this IServiceCollection service)
        {
            //service.AddScoped<IUnitOfWork, UnitOfWork>();

            service.AddCustomRepository<AccountAudit, AccountAuditRepository>();
            service.AddCustomRepository<Account, AccountRepository>();
            service.AddCustomRepository<AccountType, AccountTypeRepository>();
            service.AddCustomRepository<AddressBook, AddressBookRepository>();
            service.AddCustomRepository<ContactAudit, ContactAuditRepository>();
            service.AddCustomRepository<Contact, ContactRepository>();
            service.AddCustomRepository<Industry, IndustryRepository>();

            service.AddCustomRepository<Category, CategoryRepository>();
            service.AddCustomRepository<Question, QuestionRepository>();
            service.AddCustomRepository<QuestionChoice, QuestionChoiceRepository>();
            service.AddCustomRepository<UserQuestionAnswer, UserQuestionAnswerRepository>();


            return service;
        }
    }
}
