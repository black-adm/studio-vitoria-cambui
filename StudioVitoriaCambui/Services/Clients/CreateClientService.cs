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
        var clients = new Client
        {
            FirstName = request.FirstName,
            LastName = request.LastName,
            Email = new Email(request.Email),
            Phone = new Phone(request.Phone),
            Password = new Password(request.Password),
            Status = StatusClient.notDeleted & StatusClient.notBlocked
        };

        var response = await supabaseClient.From<Client>().Insert(clients);
        var newClient = response.Models.FirstOrDefault();

        if (newClient != null)
        {
            return newClient.Id;
        }

        throw new Exception("Falha ao cadastrar cliente!");
    }
}