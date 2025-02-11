using eAppointmentServer.Domain.Entities;

namespace eAppointmentServer.Application
{
    public static class Constant
    {
        public static List<AppRole> GetRoles()
        {
            List<string> roles = new()
        {
            "Admin",
            "Doctor",
            "Personel",
            "Patient"
        };

            return roles.Select(s => new AppRole() { Name = s }).ToList();
        }
    } 
}
