using NUnit.Framework;
using JobService.Services;
using JobService.Repository;
using JobService.Entities;
using Moq;
using System.Collections.Generic;

namespace TestForJobServices
{
    [TestFixture]
  
    public class JobServicesTest
    {

        JobServices jobservices;


        [SetUp]
        public void Setup()
        {
           
        }

        [Test]
        public void TestForAllJobs()
        {
            var mockRepo = new Mock<IJobServiceRepository>();
            jobservices = new JobServices(mockRepo.Object);
            mockRepo.Setup(repo => repo.AllJobs()).Returns(new List<Job>());
            var result = jobservices.AllJobs();
            Assert.That(result, Is.TypeOf<List<Job>>());
        }
        Job job = new Job()
        {
            CompanyName = "WIPRO",
            PostedBy = "DEEPANSH",
            LastDateToApply = System.DateTime.MaxValue,
            JobCategory = "SOFTWARE",
            JobDescription = "EXPERIENCE OF ATLEAST ONE YEAR",
            EmployerId = 1,
            status = "ACTIVE"
        };
        [Test]
        public void TestForAddJob()
        {
            var mockRepo = new Mock<IJobServiceRepository>();
            jobservices = new JobServices(mockRepo.Object);
            mockRepo.Setup(repo => repo.AddJob(job)).Returns("added successfully");
            var result = jobservices.AddJob(job);
            Assert.That(result, Is.EqualTo("added successfully"));
        }
        string category="Java";
        [Test]
        public void TestForGetJobsByCategory()
        {
            var mockRepo = new Mock<IJobServiceRepository>();
            jobservices = new JobServices(mockRepo.Object);
            mockRepo.Setup(repo => repo.AllJobByCategory(category)).Returns(new List<Job>());
            var result = jobservices.AllJobByCategory(category);
            Assert.That(result, Is.TypeOf<List<Job>>());
        }
        int jobId = 3;
        [Test]
        public void TestForDeleteJob()
        {
            var mockRepo = new Mock<IJobServiceRepository>();
            jobservices = new JobServices(mockRepo.Object);
            mockRepo.Setup(repo => repo.DeleteJob(jobId)).Returns("deleted successfully");
            var result = jobservices.DeleteJob(jobId);
            Assert.That(result, Is.EqualTo("deleted successfully"));
        }
        int employerId = 4;
        [Test]
        public void TestForGetJobByEmployerId()
        {
            var mockRepo = new Mock<IJobServiceRepository>();
            jobservices = new JobServices(mockRepo.Object);
            mockRepo.Setup(repo => repo.GetJobsByEmployerId(employerId)).Returns(new List<Job>());
            var result = jobservices.GetJobsByEmployerId(employerId);
            Assert.That(result, Is.TypeOf<List<Job>>());
        }
        [Test]
        public void TestForGetJobByJobId()
        {
            var mockRepo = new Mock<IJobServiceRepository>();
            jobservices = new JobServices(mockRepo.Object);
            mockRepo.Setup(repo => repo.GetJobByJobId(jobId)).Returns(new Job());
            var result = jobservices.GetJobByJobId(jobId);
            Assert.That(result, Is.InstanceOf<Job>());
        }
    }
}