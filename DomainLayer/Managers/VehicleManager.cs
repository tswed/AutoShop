using DomainLayer.DataManagers;
using DomainLayer.DTOs;

namespace DomainLayer.Managers
{
    public class VehicleManager
    {
        private VehicleDataManager _vehicleDataManager;
        public VehicleManager(VehicleDataManager vehicleDataManager)
        {
            _vehicleDataManager = vehicleDataManager;
        }

        public async Task<Vehicle> CreateNewVehicleAsync(VehicleForCreate vehicleToCreate)
        {
            return await _vehicleDataManager.CreateNewVehicleAsync(vehicleToCreate);
        }
    }
}
