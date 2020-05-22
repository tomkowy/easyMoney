using FluentValidation;

namespace EasyMoney.Modules.FakeManageUsers.Application.ActivateUser
{
    public class ActivateUserCommandValidator : AbstractValidator<ActivateUserCommand>
    {
        public ActivateUserCommandValidator()
        {
            RuleFor(x => x.UserId).NotEmpty();
        }
    }
}
