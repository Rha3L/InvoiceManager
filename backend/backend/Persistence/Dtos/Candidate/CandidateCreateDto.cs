namespace backend.Core.Dtos.Candidate
{
    public class CandidateCreateDto
    {
        public string FirstName { get; set; } = String.Empty;

        public string LastName { get; set; } = String.Empty;

        public string Email { get; set; } = String.Empty;

        public string Phone { get; set; } = String.Empty;

        public string CoverLetter { get; set; } = String.Empty;

        public long JobId { get; set; }
    }
}
