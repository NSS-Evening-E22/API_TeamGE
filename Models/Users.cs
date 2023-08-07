namespace API_TeamGE.Models
{
    public class Users
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Bio { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ProfileImage { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool IsActive { get; set; }
    }
}
