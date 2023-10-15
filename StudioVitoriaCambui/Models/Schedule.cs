using StudioVitoriaCambui.Enums;

namespace StudioVitoriaCambui.Models;

public class Schedule
{
    public Guid Id { get; set; }
    public UserClient UserClient { get; set; }
    public DateTime Date { get; set; }
    public StatusAppointments StatusAppointments { get; set; }
    
    public Schedule(UserClient userClient, DateTime date, StatusAppointments statusAppointments)
    {
        UserClient = userClient;
        Date = date;
        StatusAppointments = statusAppointments;
    }
}