using FluentValidation;

namespace EasyMoney.Application.FakeData.Commands.AddFakeData
{
    public class AddFakeDataCommandValidator : AbstractValidator<AddFakeDataCommand>
    {
        public AddFakeDataCommandValidator()
        {
            RuleFor(x => x.Value).NotEmpty();
        }
    }
}
