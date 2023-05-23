namespace V2VB.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }

}