namespace DAL.Domain.Users
{
    public class AppUser : DbEntity
    {
        public AppUser(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public int Balance { get; set; }
    }
}
