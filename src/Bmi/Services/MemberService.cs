namespace Bmi.Services
{
    using System;
    using Data;
    using Data.Models;

    public class MemberService : Repository<Member>
    {
        public MemberService(BmiContext context)
            : base(context)
        {
        }
    }
}
