using System;
using Data;
using Data.Models;

namespace Bmi.Services
{
    public class TrainingSessionService : Repository<Session>
    {
        public TrainingSessionService(BmiContext context)
            : base(context)
        {
        }

        public double V02Max(double hrMax, double hrRest) => 15 * (hrMax / hrRest);

        public double HrMax(int age) => 205.8 - (0.685 * age);
    }
}
