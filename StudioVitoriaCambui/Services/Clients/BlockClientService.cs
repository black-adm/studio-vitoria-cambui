using StudioVitoriaCambui.Models;
using StudioVitoriaCambui.Enums;

namespace StudioVitoriaCambui.Services.Clients;

public class BlockClientService
{
    private readonly GetClientById _getClientId;
        
    public BlockClientService(GetClientById getClientId)
    {
        _getClientId = getClientId;
    }

    public void Block(Guid clientId)
    {
        Client client = _getClientId.GetClient(clientId);

        if (client != null)
        {
            client.Status = StatusClient.isBlocked;
        }
        //_clientRepository.Update(client);
    }
}