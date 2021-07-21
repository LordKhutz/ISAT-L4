namespace Bmi.Services
{
    using System.Linq;
    using Bmi.Abstractions;

    using Data;
    using Data.Models;

    public class MemberService : Repository<Member>, IMemberService
    {
        public MemberService(BmiContext context)
            : base(context)
        {
        }
    }
}
