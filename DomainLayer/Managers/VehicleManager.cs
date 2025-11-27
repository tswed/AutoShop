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

        public Vehicle CreateNewVehicle(VehicleForCreate vehicleToCreate)
        {
            return _vehicleDataManager.CreateNewVehicle(vehicleToCreate);
        }
    }
}
