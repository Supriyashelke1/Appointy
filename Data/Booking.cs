using System;
using System.Collections.Generic;

namespace Appointy.Data;

public partial class Booking
{
    public int Id { get; set; }

    public int? AppointmentId { get; set; }

    public DateTime? BookingDate { get; set; }

    public byte? Status { get; set; }

    public virtual Appointment? Appointment { get; set; }
}

public enum BookingStatus
{
    Pending,
    Approved,
    Rejected,
    Completed

}
