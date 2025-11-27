using DomainLayer.DTOs;

namespace WebApi.DTOs
{
    public class ApiVehicle
    {
        public int Year { get; set; }
        public string Make { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public string VIN { get; set; } = string.Empty;
        public string LicensePlate { get; set; } = string.Empty;
        public int CurrentOdometer { get; set; }
        public DateTime? PurchasedDate { get; set; }
        public int? PurchasedPrice { get; set; }

        public Vehicle ConvertToDomainDto(ApiVehicle apiVehicle)
        {
            return new Vehicle(
                apiVehicle.Year,
                apiVehicle.Make,
                apiVehicle.Model,
                apiVehicle.VIN,
                apiVehicle.LicensePlate,
                apiVehicle.CurrentOdometer,
                apiVehicle.PurchasedDate,
                apiVehicle.PurchasedPrice
            );
        }
    }
}
