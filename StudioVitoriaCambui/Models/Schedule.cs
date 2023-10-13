using StudioVitoriaCambui.Enums;

namespace StudioVitoriaCambui.Models;

public class Schedule
{
    public Guid Id { get; set; }
    public Client Client { get; set; }
    public DateTime Date { get; set; }
    public StatusAppointments StatusAppointments { get; set; }
    
    public Schedule(Client client, DateTime date, StatusAppointments statusAppointments)
    {
        Client = client;
        Date = date;
        StatusAppointments = statusAppointments;
    }
}