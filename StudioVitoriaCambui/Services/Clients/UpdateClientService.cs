using StudioVitoriaCambui.Models;
using StudioVitoriaCambui.ValueObjects;

namespace StudioVitoriaCambui.Services.Clients;

public class UpdateClientService
{
    private readonly GetClientById _getClientId;
        
    public UpdateClientService(GetClientById getClientId)
    {
        _getClientId = getClientId;
    }
    
    public void Update(Guid clientId, string firstName, string lastName, Email email, Phone phone, Password password)
    {
        Client client = _getClientId.GetClient(clientId);

        if (client != null)
        {
            client.FirstName = firstName;
            client.LastName = lastName;
            client.Email = email;
            client.Phone = phone;
            client.Password = password;
        }
        //_clientRepository.Update(client);
    }
}