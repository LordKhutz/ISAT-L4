namespace Bmi.Services
{
    using Bmi.Abstractions;
    using Data;
    using Data.Models;

    public class SalaryService : Repository<TrainerSalary>, ISalaryService
    {
        public SalaryService(BmiContext context)
            : base(context)
        {
        }
    }
}
