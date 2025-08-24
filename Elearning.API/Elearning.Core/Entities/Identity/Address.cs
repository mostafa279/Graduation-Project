namespace Elearning.Core.Entities.Identity
{
    public class Address
    {
        public Guid Id { get; set; }
        public string Governorate { get; set; } = string.Empty;
        public string Street { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string ApplicationUserId { get; set; } = string.Empty;
        public ApplicationUser ApplicationUser { get; set; } = default!;
    }
}
