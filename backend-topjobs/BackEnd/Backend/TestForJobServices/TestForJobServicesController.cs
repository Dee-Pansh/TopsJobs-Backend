using NUnit.Framework;
using JobService.Services;
using JobService.Entities;
using JobService.Controllers;
using Moq;
using System.Collections.Generic;

namespace TestForJobServices
{
    internal class TestForJobServicesController
    {
        JobServicesController jobServicesController;
        [SetUp]
        public void Setup()
        {

        }
        [Test]
        public void TestForGetAllJob()
        {
            var mockRepo = new Mock<IJobServices>();
            jobServicesController = new JobServicesController(mockRepo.Object);
            mockRepo.Setup(repo => repo.AllJobs()).Returns(new List<Job>());
            var result=jobServicesController.GetAllJob();
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
            var mockRepo = new Mock<IJobServices>();
            jobServicesController = new JobServicesController(mockRepo.Object);
            mockRepo.Setup(repo => repo.AddJob(job)).Returns("added successfully");
            var result = jobServicesController.AddJob(job);
            Assert.That(result, Is.EqualTo("added successfully"));
        }
        string category = "Java";
        [Test]
        public void TestForGetJobsByCategory()
        {
            var mockRepo = new Mock<IJobServices>();
            jobServicesController = new JobServicesController(mockRepo.Object);
            mockRepo.Setup(repo => repo.AllJobByCategory(category)).Returns(new List<Job>());
            var result = jobServicesController.GetJobsByCategory(category);
            Assert.That(result, Is.TypeOf<List<Job>>());
        }
        int jobId = 3;
        [Test]
        public void TestForDeleteJob()
        {
            var mockRepo = new Mock<IJobServices>();
            jobServicesController = new JobServicesController(mockRepo.Object);
            mockRepo.Setup(repo => repo.DeleteJob(jobId)).Returns("deleted successfully");
            var result = jobServicesController.Deleltee(jobId);
            Assert.That(result, Is.EqualTo("deleted successfully"));
        }
        int employerId = 4;
        [Test]
        public void TestForGetJobByEmployerId()
        {
            var mockRepo = new Mock<IJobServices>();
            jobServicesController = new JobServicesController(mockRepo.Object);
            mockRepo.Setup(repo => repo.GetJobsByEmployerId(employerId)).Returns(new List<Job>());
            var result = jobServicesController.GetJobsByEmployerId(employerId);
            Assert.That(result, Is.TypeOf<List<Job>>());
        }
        [Test]
        public void TestForGetJobByJobId()
        {
            var mockRepo = new Mock<IJobServices>();
            jobServicesController = new JobServicesController(mockRepo.Object);
            mockRepo.Setup(repo => repo.GetJobByJobId(jobId)).Returns(new Job());
            var result = jobServicesController.GetJobByJobId(jobId);
            Assert.That(result, Is.InstanceOf<Job>());
        }
    }
}