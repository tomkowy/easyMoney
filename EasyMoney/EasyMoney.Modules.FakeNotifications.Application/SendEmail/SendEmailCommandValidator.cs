using FluentValidation;

namespace EasyMoney.Modules.FakeNotifications.Application.SendEmail
{
    public class SendEmailCommandValidator : AbstractValidator<SendEmailCommand>
    {
        public SendEmailCommandValidator()
        {
            RuleFor(x => x.Subject).NotEmpty();
            RuleFor(x => x.Body).NotEmpty();
            RuleFor(x => x.Addresses).NotEmpty();
        }
    }
}
