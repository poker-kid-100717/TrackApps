namespace TrackApps.Server.Models
{
    public class Interview
    {
        public int Id { get; set; }
        public string InterviewDate { get; set; }
        public string? Interviewer { get; set; }
        public string? Company { get; set; }
        public string? Position { get; set; }
        public string? ContactNumber { get; set; }
        public int? Round { get; set; }
        public bool? FollowUp { get; set; }
    }
}

