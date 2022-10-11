using NUnit.Framework;
using Microsoft.EntityFrameworkCore.InMemory;
using ResumeServices.Repository;
using ResumeServices.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace TestForResumeService
{
    public class Tests
    {
        private DbContextOptions<ResumeDb> dbContextOptions = new DbContextOptionsBuilder<ResumeDb>()
        .UseInMemoryDatabase(databaseName: "TestDb")
        .Options;
        private ResumeRepository resumeRepository;
        [OneTimeSetUp]
        public void Setup()
        {
            SeedDb();
            resumeRepository = new ResumeRepository(new ResumeDb(dbContextOptions));
        }
        private void SeedDb()
        {
            using var context = new ResumeDb(dbContextOptions);
                List<Resume> resumes = new List<Resume>
            {
                new Resume { applicantId=1,Skills="c sharp",MajorProject="bottle operator",
                Experience=4,
                Achievements="scholarship",
                jobId=3,
                Name="Amit"},
                new Resume { applicantId=2,Skills="cpp",MajorProject="AI camera",
                Experience=2,
                Achievements="award",
                jobId=4,
                Name="Muskan"},
                new Resume { applicantId=3,Skills="angular",MajorProject="machine learning",
                Experience=0,
                Achievements="trophy",
                jobId=4,
                Name="Rajesh"},
            };
            context.AddRange(resumes);
        }
        Resume r = new Resume()
        {
            applicantId = 4,
            Skills = "c sharp",
            MajorProject = "banking project",
            Experience = 5,
            Achievements = "scholarship",
            jobId = 4
        };
        [Test]
        public void TestForAddResume()
        {
            using var context = new ResumeDb(dbContextOptions);
            var result = resumeRepository.AddResume(r);
            Assert.That(result,Is.TypeOf<string>());
        }
        int jobId = 3;
        [Test]
        public void TestForAllResumesForParticularJobId()
        {
            using var context = new ResumeDb(dbContextOptions);
            var result = resumeRepository.AllResumesForParticularJobId(jobId);
            Assert.That(result, Is.TypeOf<List<Resume>>());
        }
        [Test]
        public void TestForDeleteResume()
        {
            using var context = new ResumeDb(dbContextOptions);
            var result = resumeRepository.DeleteResume(r);
            Assert.That(result, Is.TypeOf<string>());
        }
        int resumeId = 1;
        [Test]
        public void TestForGetResumeByResumeId()
        {
            using var context = new ResumeDb(dbContextOptions);
            var result = resumeRepository.GetResumeByResumeId(resumeId);
            Assert.That(result, Is.EqualTo(null));
        }
        int applicantId = 3;
        [Test]
        public void TestForJobSeekerRegisteration()
        {
            using var context = new ResumeDb(dbContextOptions);
            var result = resumeRepository.JobSeekerRegisteredConfirmation(applicantId);
            Assert.That(result, Is.TypeOf<string>());
        }
    }
}