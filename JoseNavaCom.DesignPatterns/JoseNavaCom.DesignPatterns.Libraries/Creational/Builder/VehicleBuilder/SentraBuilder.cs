namespace JoseNavaCom.DesignPatterns.Libraries.Creational.Builder.VehicleBuilder
{
    public class SentraBuilder : IVehicleBuilder
    {
        private Vehicle _vehicle;

        public SentraBuilder()
        {
            _vehicle = new Vehicle();
        }

        public void SetMake()
        {
            _vehicle.Make = "Nissan";
        }

        public void SetModel()
        {
            _vehicle.Model = "Sentra";
        }

        public void SetEngine()
        {
            _vehicle.Engine = "4 Cylinder";
        }

        public void SetTransmission()
        {
            _vehicle.Transmission = "Automatic";
        }

        public void SetBody()
        {
            _vehicle.Body = "Sedan";
        }

        public Vehicle GetVehicle()
        {
            return _vehicle;
        }
    }
}
