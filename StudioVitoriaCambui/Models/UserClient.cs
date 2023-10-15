using Postgrest.Attributes;
using Postgrest.Models;
using StudioVitoriaCambui.Enums;
using StudioVitoriaCambui.ValueObjects;

namespace StudioVitoriaCambui.Models
{
    [System.ComponentModel.DataAnnotations.Schema.Table("clients")]
    public class UserClient : BaseModel
    {
        [PrimaryKey("id", false)]
        public Guid Id { get; set; }
        
        [Column("first_name")]
        public string FirstName { get; set; }
        
        [Column("last_name")]
        public string LastName { get; set; }
        
        [Column("email")]
        public Email Email { get; set; }
        
        [Column("phone")]
        public Phone Phone { get; set; }
        
        [Column("password")]
        public string Password { get; set; }
        
        [Column("status_client")]
        public StatusClient? Status { get; set; }

        public UserClient()
        {
            Id = Guid.NewGuid();
            Status = StatusClient.notDeleted;
        }

        public UserClient(string firstName, string lastName, Email email, Phone phone, string password, StatusClient statusClient)
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