namespace Bmi.Services
{
    using Data;
    using Data.Models;

    public class MemberService : Repository<Member>, IRepository<Member>
    {
        public MemberService(BmiContext context)
            : base(context)
        {
        }
    }
}
