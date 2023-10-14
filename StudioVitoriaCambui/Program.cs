using StudioVitoriaCambui.Config;
using StudioVitoriaCambui.Contracts;
using StudioVitoriaCambui.Services.Clients;
using Supabase;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors();
builder.Services.ConfigureSupabase(builder.Configuration);

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

app.UseCors(corsBuilder => corsBuilder
    .SetIsOriginAllowed(_ => true)
    .AllowAnyMethod()
    .AllowAnyHeader()
    .AllowCredentials());
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();