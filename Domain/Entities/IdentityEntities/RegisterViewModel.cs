using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.IdentityEntities;

public  class RegisterViewModel
{
    [Required]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; } = string.Empty;

    [Required]
    [DataType(DataType.Password)]
    [Display(Name = "Confime Password")]
    [Compare("Password", ErrorMessage = "Password and confirm do not match.")]
    public string ConfirmPassword { get; set; } = string.Empty;
}