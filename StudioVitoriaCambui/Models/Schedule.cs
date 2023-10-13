using StudioVitoriaCambui.Enums;

namespace StudioVitoriaCambui.Models;

public class Schedule
{
    public int Id { get; set; }
    public Client Client { get; set; }
    public DateTime Date { get; set; }
    public StatusAppointments StatusAppointments { get; set; }
    
    public Schedule(int id, Client client, DateTime date, StatusAppointments statusAppointments)
    {
        Id = id;
        Client = client;
        Date = date;
        StatusAppointments = statusAppointments;
    }
}