using System;
using System.Collections.Generic;

namespace fullControl.Model
{
    public partial class Reservations
    {
        public int ReservationId { get; set; }
        public int FkDoctorId { get; set; }
        public int FkAvailableTimeId { get; set; }
        public int FkPatientId { get; set; }
    }
}
