using StudioVitoriaCambui.Contracts;
using StudioVitoriaCambui.Models;
using StudioVitoriaCambui.ValueObjects;
using StudioVitoriaCambui.Enums;

namespace StudioVitoriaCambui.Services.Clients;

public class CreateClientService
{
    public static async Task<Guid> CreateClientAsync(
        ClientRequest request,
        Supabase.Client supabaseClient
    )
    {
        var clients = new UserClient
        {
            Id = Guid.NewGuid(),
            FirstName = request.FirstName,
            LastName = request.LastName,
            Email = request.Email,
            Phone = request.Phone,
            Password = request.Password,
            Status = StatusClient.notDeleted
        };

        var response = await supabaseClient.From<UserClient>().Insert(clients);
        var newClient = response.Models.FirstOrDefault();

        if (newClient != null)
        {
            return newClient.Id;
        }
        throw new Exception("Falha ao cadastrar cliente!");
    }
}