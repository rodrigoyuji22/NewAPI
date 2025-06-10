using FluentValidation;
using Microsoft.AspNetCore.Identity;
using NewAPI.Dtos;
using NewAPI.Entities;

namespace NewAPI.Validators;

public class UserValidator : AbstractValidator<CreateUserDto>
{
    
    private readonly UserManager<User> _userManager;
    
    public UserValidator(UserManager<User> userManager)
    {
        _userManager = userManager;
        RuleFor(x => x.Email)
            .NotEmpty().WithMessage("Email is required")
            .EmailAddress().WithMessage("Email is invalid")
            .MustAsync(BeUniqueEmail).WithMessage("Email already exists");
    }

    private async Task<bool> BeUniqueEmail(string email, CancellationToken ct)
    {
        var result = await _userManager.FindByEmailAsync(email);
        if (result is not null)
            return false;
        return true;
    }
}