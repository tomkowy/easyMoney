using FluentValidation;

namespace EasyMoney.Application.FakeData.Commands.AddFakeData
{
    public class AddFakeDataCommandValidator : AbstractValidator<AddFakeDataCommand>
    {
        public AddFakeDataCommandValidator()
        {
            RuleFor(x => x.Value1).NotEmpty();
            RuleFor(x => x.Value2).NotEmpty();
            RuleFor(x => x.Value3).NotEmpty();
            RuleFor(x => x.Value4).NotEmpty();
        }
    }
}
