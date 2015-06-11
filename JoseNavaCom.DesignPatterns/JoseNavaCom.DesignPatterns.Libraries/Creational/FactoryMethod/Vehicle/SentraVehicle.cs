namespace JoseNavaCom.DesignPatterns.Libraries.Creational.FactoryMethod.Vehicle
{
    public class SentraVehicle : IVehicle
    {
        public string Make
        {
            get { 
                return "Nissan"; 
            }
        }

        public string Model
        {
            get { 
                return "Sentra"; 
            }
        }

        public string Engine
        {
            get {
                return "4 Cylinder";
            }
        }

        public string Transmission
        {
            get {
                return "Automatic";            
            }
        }

        public string Body
        {
            get {
                return "Sedan";
            }
        }
    }
}
