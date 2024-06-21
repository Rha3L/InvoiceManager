namespace backend.Persistence.Dtos.User
{
    public class UserDto
    {
        public long ID { get; set; }

        public string FirstName { get; set; } = String.Empty;

        public string LastName { get; set; } = String.Empty;

        public string Email { get; set; } = String.Empty;

        public string Phone { get; set; } = String.Empty;

        public string Address {  get; set; } = String.Empty;

        public string CoverLetter { get; set; } = String.Empty;

        public string ResumeUrl { get; set; } = String.Empty;

        public long JobId { get; set; }

        public string? JobTitle { get; set; }
    }
}
