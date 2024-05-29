namespace Patient.Server.Service.API.RequestModels
{
    public class StockOnHandUpdateRequest
    {
        public int BookingId { get; set; }
        public int AttendeeId { get; set; }
        public int BranchId { get; set; }
        public string AdministeredBrand { get; set; }
        public string AdministeredDose { get; set; }
        public SohRequesType RequesType { get; set; }
        public decimal UnitPrice { get; set; }
        public DateTime AdministeredDateTime { get; set; }

    }

    public enum SohRequesType
    {
        Deduction,
        Revert
    }
}
