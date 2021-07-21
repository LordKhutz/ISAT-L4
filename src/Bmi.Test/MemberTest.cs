namespace Bmi.Test
{
    using System;

    using NUnit.Framework;

    using Bmi.Abstractions;
    using Data.Models;
    using Data;
    using Moq;
    using Bmi.Services;
    using Microsoft.EntityFrameworkCore;
    using System.Threading.Tasks;

    [TestFixture]
    public class MemberTest
    {
        private IMemberService memberService;

        public MemberTest()
        {

        }

        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<BmiContext>()
                .UseInMemoryDatabase(databaseName: "MemberTest")
                .Options;

            var context = new BmiContext(options);
            memberService = new MemberService(context);
        }

        [Test]
        public void EmptyAdd()
        {
            Member member = null;

            Assert.ThrowsAsync<EmptyEntityException>(async () => await this.memberService.AddAsync(member));
        }

        [Test]
        public async Task Add()
        {
            var member = new Member
            {
                Id = 1,
                FirstName = "Khuthadzo",
                LastName = "Tshikotshi",
                ContactNumber = 747701521,
                Age = 25,
                Trainer = 0,
                Gender = Gender.Male,
                JoinDate = DateTime.Today,
                Height = 177
            };

            await this.memberService.AddAsync(member);
            var newMember = await this.memberService.FindByIdAsync(member.Id);

            Assert.AreEqual(member, newMember);
        }
    }
}
