namespace StudioVitoriaCambui.Services.Clients;

public class GetAllClientsService
{
    private readonly Supabase.Client _supabaseClient;

    public GetAllClientsService(Supabase.Client supabaseClient)
    {
        _supabaseClient = supabaseClient;
    }
}