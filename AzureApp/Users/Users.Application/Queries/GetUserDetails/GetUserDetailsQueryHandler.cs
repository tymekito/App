using AzureApp.SharedApplication.Abstractions.Messaging;
using AzureApp.SharedDomain.Results.Base;
using Users.Application.Models;
using Users.Domain.Abstractions;
using Users.Domain.Exceptions;

namespace Users.Application.Queries.GetUserDetails
{
    public sealed class GetUserDetailsQueryHandler : IQueryHandler<GetUserDetailsQuery, GetUserDetailsResponse>
    {
        private readonly IUserRepository _userRepository;
        public GetUserDetailsQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<Result<GetUserDetailsResponse>> Handle(GetUserDetailsQuery request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.Get(request.UserId);

            if (user is null)
            {
                throw new UserNotFoundException(request.UserId);
            }


            var result = new GetUserDetailsResponse(new UserDto(user.FirstName, user.LastName));

            return result;
        }
    }
}
