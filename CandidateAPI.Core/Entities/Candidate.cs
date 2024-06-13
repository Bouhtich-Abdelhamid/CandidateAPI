using System.ComponentModel.DataAnnotations;

namespace CandidateAPI.Core.Entities
{
    public class Candidate
    {
        public int Id { get; set; }
        [Required]
        public string FirstName{ get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string CallInterval { get; set; }
        public string LinkedInProfileUrl { get; set; }
        public string GitHubProfileUrl { get; set; }
        public string Comment { get; set; }
    }
}
