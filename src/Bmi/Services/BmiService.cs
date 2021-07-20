using System;
namespace Bmi.Services
{
    public abstract class BmiService
    {
        public double GetActualBmi(double height, double weight) => Math.Pow(weight / (height / 100), 2);

        public virtual double GetOptimalBmi(double height, double weight) => 0.5 * weight / Math.Pow(height / 100, 2) + 11.5;

        public virtual double GetOptimalBmi(double height, double weight, int age) => 0.5 * weight / (Math.Pow(height / 100, 2) + 0.03) * age + 11;
    }
}
