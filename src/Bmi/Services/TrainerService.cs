namespace Bmi.Services
{
    using Bmi.Abstractions;
    using Data;
    using Data.Models;

    public class TrainerService : Repository<Trainer>, ITrainerService
    {
        public TrainerService(BmiContext context)
            : base(context)
        {
        }
    }
}
