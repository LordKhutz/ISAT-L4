namespace Bmi.Abstractions
{
    using Data;
    using Data.Models;

    public interface ITrainingSessionService: IRepository<TrainingSession>
    {
        double HrMax(int age);
        double V02Max(double hrMax, double hrRest);
    }
}