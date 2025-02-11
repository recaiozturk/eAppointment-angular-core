using MediatR;
using TS.Result;

namespace eAppointmentServer.Application.Features.Users.CreateUsers
{
    public sealed record CreateUserCommand(
        string FirstName,
        string LastName,
        string Email,
        string UserName,
        string Password,
        List<Guid> RoleIds) : IRequest<Result<string>>;
}
