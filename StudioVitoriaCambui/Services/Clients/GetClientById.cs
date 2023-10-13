using StudioVitoriaCambui.Models;

namespace StudioVitoriaCambui.Services.Clients
{
    public class GetClientById
    {
        private readonly List<Client> _clients; 

        public GetClientById(List<Client> clients) 
        {
            _clients = clients;
        }

        public Client GetClient(Guid clientId)
        {
            Client client = _clients.FirstOrDefault(c => c.Id == clientId);

            if (client == null)
            {
                throw new Exception("Usuário não encontrado!");
            }
            return client;
        }
    }
}