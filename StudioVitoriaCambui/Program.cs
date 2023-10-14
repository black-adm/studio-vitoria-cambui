using StudioVitoriaCambui.Config;
using StudioVitoriaCambui.Contracts;
using StudioVitoriaCambui.Interfaces;
using StudioVitoriaCambui.Services.Clients;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors();
builder.Services.ConfigureSupabase(builder.Configuration);
builder.Services.AddScoped<IClientService, GetClientById>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapPost("clients", async (
        ClientRequest request,
        Supabase.Client supabaseClient) =>
    { 
        Guid clientId = await CreateClientService
            .CreateClientAsync(request, supabaseClient);
        return Results.Ok(clientId);
    }
);

app.MapGet("/users/{id}", async (
    Guid id, IClientService clientService) =>
{
    var result = await clientService.GetClientId(id);
    return result;
});

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.UseCors(corsBuilder => corsBuilder
    .SetIsOriginAllowed(_ => true)
    .AllowAnyMethod()
    .AllowAnyHeader()
    .AllowCredentials());
app.Run();