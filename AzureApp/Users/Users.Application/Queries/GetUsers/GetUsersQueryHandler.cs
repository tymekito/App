using AzureApp.SharedApplication.Abstractions.Messaging;
using AzureApp.SharedDomain.Results.Base;
using Users.Application.Models;
using Users.Domain.Abstractions;

namespace Users.Application.Queries.GetUsers
{
    internal sealed class GetUsersQueryHandler : IQueryHandler<GetUsersQuery, GetUsersResponse>
    {
        private readonly IUserRepository _userRepository;
        public GetUsersQueryHandler(
            IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<Result<GetUsersResponse>> Handle(GetUsersQuery request, CancellationToken cancellationToken)
        {
            var users = await _userRepository.GetAll();

            var usersDtos = users.Select(x => new UserDto(x.FirstName, x.LastName)).ToList();

            var result = new GetUsersResponse(usersDtos);

            return result;
        }
    }
}
