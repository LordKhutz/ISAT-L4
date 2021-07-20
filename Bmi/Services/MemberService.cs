using System;
using Data;
using Data.Models;

namespace Bmi.Services
{
    public class MemberService : Repository<Members>
    {
        public MemberService(BmiContext context)
            : base(context)
        {
        }
    }
}
