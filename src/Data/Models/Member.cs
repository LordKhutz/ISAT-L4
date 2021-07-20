namespace Data.Models
{
    using System;

    public enum Gender
    {
        Male,
        Female,
        Other
    }

    public enum MembershipType
    {
        Basic,
        Standard,
        Premium
    }

    public class Member
    {
        public long Trainer { get; set; }

        public int Age { get; set; }

        public DateTime JoinDate { get; set; }

        public Gender Gender { get; set; }

        public MembershipType MembershipType { get; set; }
    }
}
