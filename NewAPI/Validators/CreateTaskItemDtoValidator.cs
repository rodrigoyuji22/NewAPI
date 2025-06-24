using FluentValidation;
using JetBrains.Annotations;
using NewAPI.Dtos;

namespace NewAPI.Validators;

[UsedImplicitly]
public class CreateTaskItemDtoValidator : AbstractValidator<CreateTaskItemDto>
{
    public CreateTaskItemDtoValidator()
    {
        RuleFor(x => x.Title).NotEmpty().WithMessage("Title is required");
        RuleFor(x => x.Description).NotEmpty().WithMessage("Description is required");
    }
}