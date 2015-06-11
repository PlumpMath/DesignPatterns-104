using JoseNavaCom.DesignPatterns.Libraries.Creational.Builder.VehicleBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoseNavaCom.DesignPatterns.Libraries.Creational.Builder
{
    public class VehicleCreator
    {
        private readonly IVehicleBuilder _vehicleBuilder;

        public VehicleCreator(IVehicleBuilder vehicleBuilder)
        {
            if (vehicleBuilder == null)
            {
                throw new ArgumentNullException("vehicleBuilder", "You did not pass a vehicleBuilder");
            }

            _vehicleBuilder = vehicleBuilder;
        }

        public void CreateVehicle()
        {
            _vehicleBuilder.SetMake();
            _vehicleBuilder.SetModel();
            _vehicleBuilder.SetEngine();
            _vehicleBuilder.SetTransmission();
            _vehicleBuilder.SetBody();
        }

        public Vehicle GetVehicle()
        {
            return _vehicleBuilder.GetVehicle();
        }
    }
}
