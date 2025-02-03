namespace eAppointmentServer.Domain.Entities
{
    public sealed class AppUser
    {
        public string Firstname { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string FullName => string.Join("", Firstname, LastName);
    }
}
