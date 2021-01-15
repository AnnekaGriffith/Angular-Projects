namespace API.Entities
{
    public class AppUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }

        //first stage of Encyption
        public byte[] PasswordHash { get; set; }
        //second stage of Encyption
        public byte[] PasswordSalt { get; set; }
    }
} 