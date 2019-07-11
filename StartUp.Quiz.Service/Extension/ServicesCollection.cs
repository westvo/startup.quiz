using Microsoft.Extensions.DependencyInjection;
using StartUp.CRM.Service.Implements.Quiz;
using StartUp.Quiz.Model.Entities.Quiz;
using StartUp.Quiz.Service.Collections;
using StartUp.Quiz.Service.Implements.Quiz;
using StartUp.Quiz.Service.Shared;
using StartUp.Quiz.Service.Shared.Quiz;

namespace StartUp.Quiz.Service.Extension
{
    public static class ServicesCollection
    {
        public static IServiceCollection AddServicesInstance(this IServiceCollection services)
        {
            services.AddScoped<IServiceBase<Question>, QuestionService>();
            services.AddScoped<IQuestionService, QuestionService>();
            services.AddScoped<IServiceBase<Category>, CategoryService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IServiceBase<QuestionChoice>, QuestionChoiceService>();
            services.AddScoped<IQuestionChoiceService, QuestionChoiceService>();
            return services;
        }
        
        //public static IServiceCollection AddServicesInstance<TEntity, TService>(this IServiceCollection services) where TEntity : class  where TService : class, IServiceBase<TEntity>
        //{
        //    services.AddScoped<IServiceBase<TEntity>, TService>();
        //    return services;
        //}
    }
}
