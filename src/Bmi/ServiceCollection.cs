namespace Bmi
{
    using Microsoft.Extensions.DependencyInjection;

    using Bmi.Abstractions;
    using Bmi.Services;

    public static class ServiceCollection
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddScoped<IMemberService, MemberService>();
            services.AddScoped<ITrainerService, TrainerService>();
            services.AddScoped<ITrainingSessionService, TrainingSessionService>();
            services.AddScoped<ISalaryService, SalaryService>();
            services.AddScoped<IBmiService, BmiService>();
        }
    }
}
