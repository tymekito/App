﻿
using AzureApp.SharedDomain.Exceptions;

namespace Users.Domain.Exceptions
{
    public sealed class UserNotFoundException : NotFoundException
    {
        public UserNotFoundException(Guid userId)
            : base("User with Id", userId.ToString())
        {
        }
    }
}
