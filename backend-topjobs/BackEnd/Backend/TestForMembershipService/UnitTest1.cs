using NUnit.Framework;
using Moq;
using MembershipService.Services;
using MembershipService.Controllers;
using MembershipService.Entities;
namespace TestForMembershipService
{
    public class TestForMembershipController
    {
        MembershipController membershipcontroller;
        [SetUp]
        public void Setup()
        {
        }



        int employerId = 3;
        [Test]
        public void TestDeleteSubscription()
        {
            var mockRepo = new Mock<IMembershipService>();
            membershipcontroller = new MembershipController(mockRepo.Object);
            mockRepo.Setup(repo => repo.DeleteSubscription(employerId)).Returns("deleted successfully");
            var result = membershipcontroller.DeleteSubscription(employerId);
            Assert.That(result, Is.EqualTo("deleted successfully"));
        }
        Membership membership = new Membership()
        {
         EmployerId=2,
         Plan="pro plan",
         StartDate=System.DateTime.MinValue,
         EndDate=System.DateTime.MaxValue,
         Status="paid"
        };
        [Test]
        public void TestUpdateSubscription()
        {
            var mockRepo = new Mock<IMembershipService>();
            membershipcontroller = new MembershipController(mockRepo.Object);
            mockRepo.Setup(repo => repo.UpdateSubscription(membership)).Returns("updated successfully");
            var result = membershipcontroller.UpdateSubscription(membership);
            Assert.That(result, Is.EqualTo("updated successfully"));
        }
        [Test]
        public void TestGetDetailsOfSubscription()
        {
            var mockRepo = new Mock<IMembershipService>();
            membershipcontroller = new MembershipController(mockRepo.Object);
            mockRepo.Setup(repo => repo.GetDetailsOfSubscriptionByEmployerId(employerId)).Returns(new Membership());
            var result = membershipcontroller.GetDetailsOfSubscriptionByEmployerId(employerId);
            Assert.That(result, Is.InstanceOf<Membership>());
        }
        [Test]
        public void TestFor()
        {
            var mockRepo = new Mock<IMembershipService>();
            membershipcontroller = new MembershipController(mockRepo.Object);
            mockRepo.Setup(repo => repo.AddSubscription(membership)).Returns("added successfully");
            var result = membershipcontroller.AddSubscription(membership);
            Assert.That(result, Is.EqualTo("added successfully"));
        }
    }
}