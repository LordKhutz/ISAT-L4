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
    using System.Linq;

    [TestFixture]
    public class MemberTest
    {
        private IMemberService memberService;

        public MemberTest()
        {

        }

        [SetUp]
        public async Task Setup()
        {
            var options = new DbContextOptionsBuilder<BmiContext>()
                .UseInMemoryDatabase(databaseName: "MemberTest")
                .Options;

            var context = new BmiContext(options);

            context.Set<Member>().AddRange(new Member[]
            { new Member
                {
                    FirstName = "Test1",
                    LastName = "Test1",
                    ContactNumber = 747701521,
                    Age = 25,
                    Trainer = 0,
                    Gender = Gender.Male,
                    JoinDate = DateTime.Today,
                    Height = 177
                }, new Member
                {
                    FirstName = "Test2",
                    LastName = "Test2",
                    ContactNumber = 747701521,
                    Age = 25,
                    Trainer = 0,
                    Gender = Gender.Male,
                    JoinDate = DateTime.Today,
                    Height = 172
            } });

            await context.SaveChangesAsync();
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

        [Test]
        public async Task Get()
        {
            var members = await this.memberService.GetAll().ToListAsync();

            Assert.IsNotEmpty(members);
            Assert.IsInstanceOf<Member>(members.FirstOrDefault());
        }

        [Test]
        public async Task Update()
        {
            var member = await this.memberService.GetAll()
                .SingleOrDefaultAsync(_ => _.Id == 1);

            member.Age = 21;


            Assert.DoesNotThrowAsync(async () => await this.memberService.UpdateAsync(member));

            var updatedMember = await this.memberService
                .GetAll()
                .SingleOrDefaultAsync(_ => _.Id == 1);

            Assert.AreEqual(member, updatedMember);
        }

        [Test]
        public void UntrackedUpdate()
        {
            var member = new Member
            {
                FirstName = "Khuthadzo",
                LastName = "Tshikotshi",
                ContactNumber = 747701521,
                Age = 25,
                Trainer = 0,
                Gender = Gender.Male,
                JoinDate = DateTime.Today,
                Height = 177
            };

            member.Age = 22;


            Assert.ThrowsAsync<EntityNotTrackedException>(async () => await this.memberService.UpdateAsync(member));
        }
    }
}
