using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocAppointment.Models.ViewModels
{
    public class AppointmentVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public int Duration { get; set; }
        public string DoctorId { get; set; }
        public string PatientId { get; set; }
        public bool IsDoctorApproved { get; set; }
        public string AdminId { get; set; }
        public string DoctorName { get; set; }
        public string PatinetName { get; set; }
        public string AdminName { get; set; }
        public bool IsForClient { get; set; }
        public string StartDate { get; internal set; }
        public string EndDate { get; internal set; }
        public string PatientName { get; internal set; }
    }
}
