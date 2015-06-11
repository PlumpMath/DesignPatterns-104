namespace JoseNavaCom.DesignPatterns.Libraries.Creational.FactoryMethod.Vehicle
{
    public class CamaroVehicle : IVehicle
    {
        public string Make
        {
            get
            {
                return "Chevrolet";
            }
        }

        public string Model
        {
            get
            {
                return "Camaro";
            }
        }

        public string Engine
        {
            get
            {
                return "8 Cylinder";
            }
        }

        public string Transmission
        {
            get
            {
                return "Manual";
            }
        }

        public string Body
        {
            get
            {
                return "Coupe";
            }
        }
    }
}
