namespace eAppointmentServer.Domain.Entities
{
    public sealed class Patient
    {
        public Patient()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string IdentityNumber { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Towtn { get; set; } = string.Empty;
        public string FullAdress { get; set; } = string.Empty;
    }
}
