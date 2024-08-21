namespace Users.Domain.Entities
{
    public sealed class User
    {
        public User()
        {
            // For EF
        }
        public User(Guid id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
