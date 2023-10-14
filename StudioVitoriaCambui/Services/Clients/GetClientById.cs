using Microsoft.AspNetCore.Mvc;
using StudioVitoriaCambui.Contracts;
using StudioVitoriaCambui.Interfaces;
using StudioVitoriaCambui.Models;

namespace StudioVitoriaCambui.Services.Clients
{
    public class GetClientById : IClientService
    {
        private readonly Supabase.Client _supabaseClient;

        public GetClientById(Supabase.Client supabaseClient)
        {
            _supabaseClient = supabaseClient;
        }

        public async Task<ActionResult<ClientResponse>> GetClientId(Guid id)
        {
            var response = await _supabaseClient
                .From<Client>()
                .Where(c => c.Id == id)
                .Get();

            var clients = response.Models.FirstOrDefault();

            if (clients is null)
            {
                return new NotFoundResult();
            }

            var clientResponse = new ClientResponse
            {
                Id = clients.Id,
                FirstName = clients.FirstName,
                LastName = clients.LastName,
                Email = clients.Email,
                Phone = clients.Phone,
                Password = clients.Password,
            };
            return new OkObjectResult(clientResponse);
        }
    }
}