using Microsoft.AspNetCore.Mvc;
using StudioVitoriaCambui.Contracts;

namespace StudioVitoriaCambui.Interfaces;

public interface IClientService
{
    Task<ActionResult<ClientResponse>> GetClientId(Guid id);
}