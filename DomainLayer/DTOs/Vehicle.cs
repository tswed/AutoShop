namespace DomainLayer.DTOs
{
    public record Vehicle(Guid Id, string NickName, int Year, string Make, string Model,
        string VIN, string LicensePlate, int CurrentOdometer, DateTime? PurchasedDate, int? PurchasedPrice);
}
