using StudioVitoriaCambui.Enums;
using StudioVitoriaCambui.Models;

namespace StudioVitoriaCambui.Services.Clients
{
    public class DeleteClientService
    {
        private readonly GetClientById _getClientId;
        
        public DeleteClientService(GetClientById getClientId)
        {
            _getClientId = getClientId;
        }

        public void Delete(Guid clientId)
        {
            Client client = _getClientId.GetClient(clientId);

            if (client != null)
            {
                client.Status = StatusClient.isDeleted;
            }
            //_clientRepository.Delete(client);
        }
    }
}