using System.Collections.Generic;
using Appointy.Data;

public interface IAppointmentRepository
{
    List<Appointment> GetAvailableAppointments();
    
}