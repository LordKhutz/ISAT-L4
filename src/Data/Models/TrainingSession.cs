namespace Data.Models
{
    using System;

    public enum BmiStatus
    {
        Underweight,
        Normal,
        Overweight,
        Obese
    }

    public class TrainingSession
    {
        public long Id { get; set; }

        public long MemberId { get; set; }

        public DateTime DateOccured { get; set; }

        public double Weight { get; set; }

        public double ActualBmi { get; set; }

        public double IdealBmi { get; set; }

        public double HrRest { get; set; }

        public double HrMax { get; set; }

        public double V02Max { get; set; }

        public BmiStatus BmiStatus { get; set; }
    }
}
