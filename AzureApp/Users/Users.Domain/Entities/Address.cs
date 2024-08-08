namespace Users.Domain.Entities
{
    public sealed class Address
    {
        public Guid Id { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public string Street { get; set; }
    }
}
