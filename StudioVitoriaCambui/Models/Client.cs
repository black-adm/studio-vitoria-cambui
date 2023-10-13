namespace StudioVitoriaCambui.Models;

using StudioVitoriaCambui.ValueObjects;

public class Client
{
    public string? FirstName { get; set; }
    public string? LastName{ get; set; }
    public Email Email { get; }
}