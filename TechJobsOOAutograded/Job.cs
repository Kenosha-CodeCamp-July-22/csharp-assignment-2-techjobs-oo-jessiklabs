using System;
using System.Reflection;

namespace TechJobsOO
{
    public class TechJob
    {
        
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.
        public TechJob()
        {
            Id = nextId;
            nextId++;
        }
        public TechJob(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            this.Name = name;
            this.EmployerName = employerName;
            this.EmployerLocation = employerLocation;
            this.JobType = jobType;
            this.JobCoreCompetency = jobCoreCompetency;
        }
        // TODO: Generate Equals() and GetHashCode() methods.
        public override bool Equals(object obj)
        {
            return obj is TechJob job && Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            string fullString = "\nID: " + this.Id;
            if(this.EmployerName != null)
            {
                fullString += "\nName: " + this.EmployerName;
            } else
            {
                fullString += "\nName: Data not available";
            }
            if (this.EmployerLocation != null)
            {
                fullString += "\nLocation: " + this.EmployerLocation;
            }
            else
            {
                fullString += "\nLocation: Data not available";
            }
            if (this.JobType != null)
            {
                fullString += "\nPosition Type: " + this.JobType;
            }
            else
            {
                fullString += "\nPosition Type: Data not available";
            }
            if (this.JobCoreCompetency != null)
            {
                fullString += "\nCore Competency: " + this.JobCoreCompetency;
            }
            else
            {
                fullString += "\nCore Competency: Data not available";
            }
            if(this.Name == null && this.EmployerName == null && this.EmployerLocation == null && this.JobType == null && this.JobCoreCompetency == null)
            {
                return "OOPS!  This job does not seem to exist.";
            } else
            {
                return fullString;
            }



        }

    }
}