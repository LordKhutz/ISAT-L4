namespace Data.Models
{
    public class TrainerSalary
    {
        public long Id { get; set; }

        public long TrainerId { get; set; }

        public double BasicSalary { get; set; }

        public double MembershipPrice { get; set; }
    }
}
