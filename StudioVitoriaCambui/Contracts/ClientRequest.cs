using System.ComponentModel.DataAnnotations;
using StudioVitoriaCambui.ValueObjects;

namespace StudioVitoriaCambui.Contracts;

public class ClientRequest
{
    [Required]
    public string? FirstName { get; set; }

    [Required]
    public string? LastName { get; set; }

    [Required]
    [EmailAddress]
    public Email? Email { get; set; }

    [Required]
    [Phone]
    public Phone? Phone { get; set; }
    
    [Required]
    public string? Password { get; set; }
}