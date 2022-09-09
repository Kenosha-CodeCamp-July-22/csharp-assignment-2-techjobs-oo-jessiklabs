using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;
using System;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            //Create new job objects
            TechJob techJob1 = new TechJob();
            TechJob techJob2 = new TechJob();
            Assert.IsFalse(techJob1.Equals(techJob2));//test for equality
            //Test if difference between Ids is 1.
            Assert.AreEqual(techJob2.Id - techJob1.Id, 1);

        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Employer employer = new Employer("ACME");
            Location location = new Location("Desert");
            PositionType type = new PositionType("Quality control");
            CoreCompetency competency = new CoreCompetency("Persistence");
            TechJob job = new TechJob("Product tester", employer, location, type, competency);
            Assert.AreEqual(job.Name, "Product tester");
            Assert.AreEqual(job.EmployerName.Value, "ACME");
            Assert.AreEqual(job.EmployerLocation.Value, "Desert");
            Assert.AreEqual(job.JobType.Value, "Quality control");
            Assert.AreEqual(job.JobCoreCompetency.Value, "Persistence");
            {

            };
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Employer employer = new Employer("ACME");
            Location location = new Location("Desert");
            PositionType type = new PositionType("Quality control");
            CoreCompetency competency = new CoreCompetency("Persistence");
            TechJob techJob1 = new TechJob("Product tester", employer, location, type, competency);
            TechJob techJob2 = new TechJob("Product tester", employer, location, type, competency);
            Assert.IsFalse(techJob1.Equals(techJob2));
        }

        [TestMethod]
        public void TestToStringStartsAndEndsWithNewLine()
        {
            TechJob techJob1 = new TechJob();
            string expected = "\nID:  " + techJob1.Id + "\nName: Data not available\nEmployer: Data not available\nLocation: Data not available\nPosition Type: Data not available\nCore Competency: Data not available\n";
            techJob1.ToString().Equals(expected);
        }

        [TestMethod]
        public void TestToStringContainsCorrectLabelsAndData()
        {
            Employer employer = new Employer("ACME");
            Location location = new Location("Desert");
            PositionType type = new PositionType("Quality control");
            CoreCompetency competency = new CoreCompetency("Persistence");
            TechJob techJob1 = new TechJob("Product tester", employer, location, type, competency);
            string expected = "\nID: " + techJob1.Id + "\nName: " + techJob1.Name + "\nEmployer: " + employer.Value + "\nLocation: " + location.Value + "\nPosition Type: " + type.Value + "\nCore Competency: " + competency.Value;
            techJob1.ToString().Equals(expected);
        }

        [TestMethod]
        public void TestToStringHandlesEmptyField()
        {
            Employer employer = new Employer("ACME");
            Location location = new Location("Desert");
            PositionType type = new PositionType("Quality control");
            
            TechJob techJob1 = new TechJob("Product tester", employer, location, type, null);
            string expected = "\nID: " + techJob1.Id + "\nName: Product tester\nEmployer: ACME\nLocation: Desert\nPosition Type: Quality control\nCore Competency: Data not available\n";
        }

        [TestMethod]
        public void TestMethod()
        {
        }
    }
}
