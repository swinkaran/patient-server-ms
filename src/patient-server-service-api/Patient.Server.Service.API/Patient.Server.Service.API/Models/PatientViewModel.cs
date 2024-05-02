namespace Patient.Server.Service.API.Models
{
    public class PatientViewModel
    {
        public string Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Gender { get; set; }
        public string Dob { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string AttendeeEmail { get; set; }
        public string Phone { get; set; }
    }
}
