namespace EMSAPI.Models
{
    public class User
    {
        public Guid UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; } 
        public UserRole Role { get; set; }
        public string Email { get; set; }
        public string Group { get; set; } 

        public enum UserRole
        {
            Admin,
            Teacher,
            Student
        }
    }

}
