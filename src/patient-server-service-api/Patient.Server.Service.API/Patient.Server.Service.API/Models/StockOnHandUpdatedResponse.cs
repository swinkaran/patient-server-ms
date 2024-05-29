namespace Patient.Server.Service.API.Models
{
    public class StockOnHandUpdatedResponse
    {
        public string Result { get; set; }
        public bool IsErrored { get; set; }
        public string ErrorMessage { get; set; }
    }
}
