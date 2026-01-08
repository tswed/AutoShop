using DomainLayer.DTOs;
using DomainLayer.Data;
using DomainLayer.Entities;

namespace DomainLayer.DataManagers
{
    public class VehicleDataManager
    {
        private readonly AutoShopDbContext _context;

        public VehicleDataManager(AutoShopDbContext context)
        {
            _context = context;
        }

        public async Task<Vehicle> CreateNewVehicleAsync(VehicleForCreate vehicleToCreate)
        {
            var vehicleEntity = new VehicleEF
            {
                Id = Guid.NewGuid(),
                NickName = vehicleToCreate.NickName,
                Year = vehicleToCreate.Year,
                Make = vehicleToCreate.Make,
                Model = vehicleToCreate.Model,
                VIN = vehicleToCreate.VIN,
                LicensePlate = vehicleToCreate.LicensePlate,
                CurrentOdometer = vehicleToCreate.CurrentOdometer,
                PurchasedDate = vehicleToCreate.PurchasedDate,
                PurchasedPrice = vehicleToCreate.PurchasedPrice
            };
            
            _context.Vehicles.Add(vehicleEntity);
            await _context.SaveChangesAsync();

            return MapToDto(vehicleEntity);
        }
        
        private Vehicle MapToDto(VehicleEF entity)
        {
            return new Vehicle(
                entity.Id,
                entity.NickName,
                entity.Year,
                entity.Make,
                entity.Model,
                entity.VIN,
                entity.LicensePlate,
                entity.CurrentOdometer,
                entity.PurchasedDate,
                entity.PurchasedPrice
            );
        }
    }
}
