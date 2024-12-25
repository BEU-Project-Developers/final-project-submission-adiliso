using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Airline.model.dto.request;

public class PassengerCreateRequest
{
    [Required(ErrorMessage = "Username is required")]
    [MaxLength(100)]
    [NotBlank(ErrorMessage = "Username cannot be blank")]
    public string Username { get; set; }

    public string Name { get; set; }

    [Required]
    [MinLength(6, ErrorMessage = "Password must be at least 6 characters long.")]
    [PasswordStrength(ErrorMessage =
        "Password must include at least one uppercase letter, one lowercase letter, and one digit.")]
    public string Password { get; set; }
    
    [Required]
    [MinLength(6, ErrorMessage = "Password must be at least 6 characters long.")]
    [PasswordStrength(ErrorMessage =
        "Password must include at least one uppercase letter, one lowercase letter, and one digit.")]
    public string ConfirmPassword { get; set; }
}

public class PasswordStrengthAttribute : ValidationAttribute
{
    public override bool IsValid(object value)
    {
        if (value == null)
        {
            return false;
        }

        var password = value.ToString();
        if (password.Length < 6)
        {
            return false;
        }

        // Regex pattern to check password strength
        var hasUpperCase = new Regex(@"[A-Z]+");
        var hasLowerCase = new Regex(@"[a-z]+");
        var hasDigit = new Regex(@"\d+");

        return hasUpperCase.IsMatch(password) && hasLowerCase.IsMatch(password) && hasDigit.IsMatch(password);
    }
}

public class NotBlankAttribute : ValidationAttribute
{
    public override bool IsValid(object value)
    {
        if (value == null)
        {
            return false;
        }

        var username = value.ToString();
        return !string.IsNullOrWhiteSpace(username);
    }
}