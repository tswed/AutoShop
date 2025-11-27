using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoShop.Controllers
{
    [Route("{version}/vehicles")]
    [ApiController]
    public class VehiclesController : ApiBase
    {
        public VehiclesController()
        {
        }


        [HttpGet]
        public ActionResult<IEnumerable<Vehicle>> GetAll()
        {
            return Ok();
        }

        // GET: {version}/vehicles/{id}
        [HttpGet("{id}")]
        public ActionResult<Vehicle> GetById(int id)
        {
            var vehicle = Vehicles.Find(v => v.Id == id);
            if (vehicle == null)
                return NotFound();
            return Ok(vehicle);
        }

        [HttpPost]
        public ActionResult<Vehicle> CreateNewVehicle([FromBody] Vehicle vehicle)
        {
            vehicle.Id = Vehicles.Count > 0 ? Vehicles[^1].Id + 1 : 1;
            Vehicles.Add(vehicle);
            return CreatedAtAction(nameof(GetById), new { id = vehicle.Id, version = RouteData.Values["version"] }, vehicle);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Vehicle updatedVehicle)
        {
            var index = Vehicles.FindIndex(v => v.Id == id);
            if (index == -1)
                return NotFound();

            updatedVehicle.Id = id;
            Vehicles[index] = updatedVehicle;
            return NoContent();
        }

        // DELETE: {version}/vehicles/{id}
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var vehicle = Vehicles.Find(v => v.Id == id);
            if (vehicle == null)
                return NotFound();

            Vehicles.Remove(vehicle);
            return NoContent();
        }
    }
}
