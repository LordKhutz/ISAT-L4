using System;
using Data;
using Data.Models;

namespace Bmi.Services
{
    public class TrainerService : Repository<Trainers>
    {
        public TrainerService(BmiContext context)
            : base(context)
        {
        }
    }
}
