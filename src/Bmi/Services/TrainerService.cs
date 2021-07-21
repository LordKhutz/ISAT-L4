using Data;
using Data.Models;

namespace Bmi.Services
{
    public class TrainerService : Repository<Trainer>, IRepository<Trainer>
    {
        public TrainerService(BmiContext context)
            : base(context)
        {
        }
    }
}
