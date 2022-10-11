using NUnit.Framework;
using Moq;
using ApplicationService.Entities;
using ApplicationService.Services;
using ApplicationService.Repository;
using ApplicationService.Entities.ViewApplicationModel;
using System.Collections.Generic;

namespace TestForApplicationService
{
    public class Tests
    {
        ApplicationServices applicationService;

        [SetUp]
        public void Setup()
        {
        }
        ApplicationService.Application app = new ApplicationService.Application()
        {
            ApplicantId=1,
            JobId=2,
            ApplicationStatus="applied",
            Resume="my resume",
            Status="in progress"
        };
        [Test]
        public void TestForPostApplication()
        {
            var mockRepo = new Mock<IApplicationRepository>();
            applicationService = new ApplicationServices(mockRepo.Object);
            mockRepo.Setup(repo => repo.PostApplication(app)).Returns("added successfully");
            var result = applicationService.PostApplication(app);
            Assert.That(result, Is.EqualTo("added successfully"));
        }
        UpdateApplicationStatus application = new UpdateApplicationStatus()
        {
           applicantId=3,
           jobId=2,
           status="applied"
        };

        [Test]
        public void TestForUpdateApplicationStatus()
        {
            var mockRepo = new Mock<IApplicationRepository>();
            applicationService = new ApplicationServices(mockRepo.Object);
            mockRepo.Setup(repo => repo.UpdateApplicationStatus(application)).Returns("updated successfully");
            var result = applicationService.UpdateApplicationStatus(application);
            Assert.That(result, Is.EqualTo("updated successfully"));
        }
        int jobId = 4;
        [Test]
        public void TestForIsGivenJobIdExist()
        {
            var mockRepo = new Mock<IApplicationRepository>();
            applicationService = new ApplicationServices(mockRepo.Object);
            mockRepo.Setup(repo => repo.IsGivenJobIdExist(jobId)).Returns("true");
            var result = applicationService.IsGivenJobIdExist(jobId);
            Assert.That(result, Is.EqualTo("true"));
        }
        int applicantId = 2;
        [Test]
        public void TestForGetApplicationsInfo()
        {
            var mockRepo = new Mock<IApplicationRepository>();
            applicationService = new ApplicationServices(mockRepo.Object);
            mockRepo.Setup(repo => repo.GetApplicationsInfoForParticularJobSeeker(applicantId)).Returns(new List<ApplicationService.Application>());
            var result = applicationService.GetApplicationsInfoForParticularJobSeeker(applicantId);
            Assert.That(result, Is.TypeOf<List<ApplicationService.Application>>());
        }
        [Test]
        public void TestForDeleteApplicationsByJobId()
        {
            var mockRepo = new Mock<IApplicationRepository>();
            applicationService = new ApplicationServices(mockRepo.Object);
            mockRepo.Setup(repo => repo.DeleteApplicationsByJobId(jobId)).Returns("deleted successfully");
            var result = applicationService.DeleteApplicationsByJobId(jobId);
            Assert.That(result, Is.EqualTo("deleted successfully"));
        }
        [Test]
        public void TestForViewAllApplicationsByJobSeeker()
        {
            var mockRepo = new Mock<IApplicationRepository>();
            applicationService = new ApplicationServices(mockRepo.Object);
            mockRepo.Setup(repo=>repo.ViewAllApplicationsByJobSeeker(applicantId)).Returns(new List<ApplicationService.Application>());
            var result = applicationService.ViewAllApplicationsByJobSeeker(applicantId);
            Assert.That(result, Is.TypeOf<List<ApplicationService.Application>>());
        }
        [Test]
        public void TestFor()
        {
            var mockRepo = new Mock<IApplicationRepository>();
            applicationService = new ApplicationServices(mockRepo.Object);
            mockRepo.Setup(repo => repo.GetApplicationsInfoForParticularJobSeeker(applicantId)).Returns(new List<ApplicationService.Application>());
            var result = applicationService.GetApplicationsInfoForParticularJobSeeker(applicantId);
            Assert.That(result, Is.TypeOf<List<ApplicationService.Application>>());
        }

    }
}