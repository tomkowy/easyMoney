using EasyMoney.Application.Common.Exceptions;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Linq;

namespace EasyMoney.Modules.FakeManageUsers.Application.Exceptions
{
    public class CreateUserException : BusinessException
    {
        public IDictionary<string, string> Errors { get; }

        public CreateUserException(IEnumerable<IdentityError> errors) : base("One or more creation user failures have occurred.")
        {
            Errors = errors.ToDictionary(x => x.Code, y => y.Description);
        }
    }
}
