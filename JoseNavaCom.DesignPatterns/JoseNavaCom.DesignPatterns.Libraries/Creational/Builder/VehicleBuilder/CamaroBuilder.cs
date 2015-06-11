namespace JoseNavaCom.DesignPatterns.Libraries.Creational.Builder.VehicleBuilder
{
    public class CamaroBuilder : IVehicleBuilder
    {
        private Vehicle _vehicle;

        public CamaroBuilder()
        {
            _vehicle = new Vehicle();
        }

        public void SetMake()
        {
            _vehicle.Make = "Chevrolet";
        }

        public void SetModel()
        {
            _vehicle.Model = "Camaro";
        }

        public void SetEngine()
        {
            _vehicle.Engine = "8 Cylinder";
        }

        public void SetTransmission()
        {
            _vehicle.Transmission = "Manual Transmission";
        }

        public void SetBody()
        {
            _vehicle.Body = "Coupe";
        }

        public Vehicle GetVehicle()
        {
            return _vehicle;
        }
    }
}
