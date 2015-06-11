namespace JoseNavaCom.DesignPatterns.Libraries.Creational.Builder.VehicleBuilder
{
    public interface IVehicleBuilder
    {
        void SetMake();
        void SetModel();
        void SetEngine();
        void SetTransmission();
        void SetBody();

        Vehicle GetVehicle();
    }
}
