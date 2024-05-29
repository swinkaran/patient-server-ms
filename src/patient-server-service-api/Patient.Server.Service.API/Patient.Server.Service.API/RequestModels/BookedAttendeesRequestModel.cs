﻿namespace Patient.Server.Service.API.RequestModels
{
    public class BookedAttendeesRequestModel
    {
        public int BookingId { get; set; }
        public int AttendeeId { get; set; }
        public int UserId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Gender { get; set; }
        public string Dob { get; set; }
        public string Address { get; set; }
        public string Suburb { get; set; }
        public string PostCode { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string AttendeeEmail { get; set; }
        public string PhoneType { get; set; }
        public string Phone { get; set; }
        public string MedicareNumber { get; set; }
        public string IRN { get; set; }
    }
}
