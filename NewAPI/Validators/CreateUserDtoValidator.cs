using FluentValidation;
using NewAPI.Dtos;
using JetBrains.Annotations;

namespace NewAPI.Validators;

// removing the "never instantiated" warning due to FluentValidations DI
[UsedImplicitly]
public class CreateUserDtoValidator : AbstractValidator<CreateUserDto>
{
    public CreateUserDtoValidator()
    {
        
        RuleFor(x => x.UserName).NotEmpty().WithMessage("Please enter a username.").Length(5, 30).WithMessage("Username must be between 5 and 30 characters");

        RuleFor(x => x.Email)
            .NotEmpty().WithMessage("Email is required")
            .EmailAddress().WithMessage("Email is invalid");

        RuleFor(x => x.Password)
            .NotEmpty().WithMessage("Password is required");
        RuleFor(x => x.ConfirmPassword).Equal(x => x.Password).WithMessage("Passwords does not match");
    }
}