using StudioVitoriaCambui.ValueObjects;

namespace StudioVitoriaCambui.Contracts;

public class ClientResponse
{
    public Guid Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public Email? Email { get; set; }
    public Phone? Phone { get; set; }
    public Password? Password { get; set; }
}