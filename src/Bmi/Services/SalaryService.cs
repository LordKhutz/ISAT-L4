using System;
using Data;
using Data.Models;

namespace Bmi.Services
{
    public class SalaryService : Repository<TrainerSalary>
    {
        public SalaryService(BmiContext context)
            : base(context)
        {
        }
    }
}
