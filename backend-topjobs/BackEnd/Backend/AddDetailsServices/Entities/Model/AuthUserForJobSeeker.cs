namespace DetailsServices.Entities.Model
{
    public class AuthUserForJobSeeker
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Token { get; set; }
        public string Role { get; set; }

        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
    }
}
