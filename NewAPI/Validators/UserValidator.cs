using FluentValidation;
using Microsoft.AspNetCore.Identity;
using NewAPI.Dtos;
using NewAPI.Entities;
using JetBrains.Annotations;

namespace NewAPI.Validators;

// removing the "never instantiated" warning due to FluentValidations DI
[UsedImplicitly]
public class UserValidator : AbstractValidator<CreateUserDto>
{
    
    private readonly UserManager<User> _userManager;
    
    public UserValidator(UserManager<User> userManager)
    {
        _userManager = userManager;
        
        RuleFor(x => x.Nome).NotEmpty().WithMessage("Please enter a name.").Length(5, 30).WithMessage("Name must be between 5 and 30 characters");
        
        RuleFor(x => x.Email)
            .NotEmpty().WithMessage("Email is required")
            .EmailAddress().WithMessage("Email is invalid")
            .MustAsync(BeUniqueEmail).WithMessage("Email already exists");

        RuleFor(x => x.Password)
            .NotEmpty().WithMessage("Password is required");
        RuleFor(x => x.ConfirmPassword).Equal(x => x.Password).WithMessage("Passwords do not match");
    }

    private async Task<bool> BeUniqueEmail(string email, CancellationToken ct)
    {
        var result = await _userManager.FindByEmailAsync(email);
        if (result is not null)
            return false;
        return true;
    }
}