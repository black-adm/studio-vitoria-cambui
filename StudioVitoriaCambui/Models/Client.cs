using StudioVitoriaCambui.Enums;
using StudioVitoriaCambui.ValueObjects;

namespace StudioVitoriaCambui.Models
{
    public class Client
    {
        public Guid Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public Email Email { get; set; }
        public Phone Phone { get; set; }
        public Password Password { get; set; }
        public StatusClient Status { get; set; }

        public Client()
        {
            Id = Guid.NewGuid();
            Status = StatusClient.notDeleted & StatusClient.notBlocked;
        }

        public Client(string firstName, string lastName, Email email, Phone phone, Password password, StatusClient statusClient)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            Password = password;
            Status = statusClient;
        }
    }
}