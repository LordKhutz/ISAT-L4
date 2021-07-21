namespace Bmi.Abstractions
{
    public interface IBmiService
    {
        double GetActualBmi(double height, double weight);
        double GetOptimalBmi(double height, double weight);
        double GetOptimalBmi(double height, double weight, int age);
    }
}