using System;
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
        public TechJob(string name, Employer employerName, Location location, PositionType type, CoreCompetency competency) : this()
        {
            this.Name = name;
            this.EmployerName = employerName;
            this.EmployerLocation = location;
            this.JobType = type;
            this.JobCoreCompetency = competency;
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
       
    }
}