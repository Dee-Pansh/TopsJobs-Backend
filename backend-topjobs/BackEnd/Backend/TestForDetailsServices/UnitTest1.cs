using NUnit.Framework;
using Moq;
using DetailsServices.Entities;
using DetailsServices.Entities.Model;
using DetailsServices.Services;
using DetailsServices.Repository;
namespace TestForDetailsServices
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }
        Login login = new Login()
        {
            Email="deepansh@gmail.com",
            Password="deep@123"
        };
        [Test]
        public void TestForEmployerLogin()
        {
            var mockRepo = new Mock<IEmployerRepository>();
            EmployeeServices employeeServices = new EmployeeServices(mockRepo.Object);
            mockRepo.Setup(repo => repo.Login(login)).Returns(new Employer());
            var result = employeeServices.Login(login);
            Assert.That(result, Is.InstanceOf<Employer>());
        }
        Employer employer = new Employer()
        {
            Name="Siddharth",
            CompanyName="WIPRO",
            PhoneNumber="8686755544",
            EmailAddress="sidd@gmail.com",
            Designation="HR",
            Role="Employer",
            Password="siid@123"
        };
        [Test]
        public void TestForAddingEmployer()
        {
            var mockRepo = new Mock<IEmployerRepository>();
            EmployeeServices employeeServices = new EmployeeServices(mockRepo.Object);
            mockRepo.Setup(repo => repo.AddEmployer(employer)).Returns("added sucessfully");
            var result = employeeServices.AddEmployer(employer);
            Assert.That(result, Is.EqualTo("added sucessfully"));
        }
        [Test]
        public void TestForJobSeekerLogin()
        {
            var mockRepo = new Mock<IJobSeekerRepository>();
            JobSeekerServices jobSeekerServices = new JobSeekerServices(mockRepo.Object);
            mockRepo.Setup(repo=>repo.Login(login)).Returns(new JobSeeker());
            var result = jobSeekerServices.Login(login);
            Assert.That(result, Is.InstanceOf<JobSeeker>());
        }
        JobSeeker jobseeker = new JobSeeker()
        {
            Name = "Siddharth",
            PhoneNumber = "8686755544",
            EmailAddress = "sidd@gmail.com",
            Role = "Employer",
            Password = "siid@123"
        };
        [Test]
        public void TestForAddingJobSeeker()
        {
            var mockRepo = new Mock<IJobSeekerRepository>();
            JobSeekerServices jobSeekerServices = new JobSeekerServices(mockRepo.Object);
            mockRepo.Setup(repo => repo.AddJobSeeker(jobseeker)).Returns("added sucessfully");
            var result = jobSeekerServices.AddJobSeeker(jobseeker);
            Assert.That(result, Is.EqualTo("added sucessfully"));
        }
    }
}