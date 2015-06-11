namespace JoseNavaCom.DesignPatterns.Libraries.Creational.FactoryMethod.Vehicle
{
    public interface IVehicle
    {
        string Make { get; }
        string Model { get; }
        string Engine { get; }
        string Transmission { get; }
        string Body { get; }
    }
}
