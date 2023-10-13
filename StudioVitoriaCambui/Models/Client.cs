namespace StudioVitoriaCambui.Models;

using StudioVitoriaCambui.ValueObjects;

public class Client
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName{ get; set; }
    public Email Email { get; }
    public Phone Phone { get; }
    public Password Password { get; }

    public Client(int id, string firstName, string lastName, Email email, Phone phone, Password password)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Phone = phone;
        Password = password;
    }
}