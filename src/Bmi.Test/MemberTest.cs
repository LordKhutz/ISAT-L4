namespace Bmi.Test
{
    using System;

    using NUnit.Framework;

    using Bmi.Abstractions;
    using Data.Models;
    using Data;

    [TestFixture]
    public class MemberTest
    {
        private readonly IMemberService memberService;

        public MemberTest(IMemberService memberService)
        {
            this.memberService = memberService;
        }

        [TestCase("Test if Correct Exception is thrown when adding a null entity")]
        public void EmptyAdd()
        {
            Member member = null;

            Assert.ThrowsAsync<EmptyEntityException>(async () => await this.memberService.AddAsync(member));
        }
    }
}
