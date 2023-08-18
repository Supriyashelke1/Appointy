using System.Collections.Generic;
using Appointy.Data;

public interface IBookingRepository
{
    List<Booking> GetBookedAppointments();
  
}