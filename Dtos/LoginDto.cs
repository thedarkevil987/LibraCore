using System;
using System.ComponentModel.DataAnnotations;

namespace LiberaryManagmentSystem.Dtos;

public class LoginDto
{
    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress(ErrorMessage = "Invalid email format.")]
    public required string Email { get; set; }

    [Required(ErrorMessage = "Password is required.")]
    [DataType(DataType.Password)]
    public required string Password { get; set; }
}
