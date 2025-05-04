namespace CandidateTracker.API.Models
{
    public class Candidate
    {
        public int Id { get; set; }
        public string Stage { get; set; } = string.Empty;
        public string CvStatus { get; set; } = string.Empty;
        public string PotentialSeniority { get; set; } = string.Empty;
        public string Stack { get; set; } = string.Empty;
        public int ExperienceYears { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime ApplicationDate { get; set; }
        public string RecruiterName { get; set; } = string.Empty;
    }
}
