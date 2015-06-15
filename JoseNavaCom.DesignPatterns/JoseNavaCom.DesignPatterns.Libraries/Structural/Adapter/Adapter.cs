namespace JoseNavaCom.DesignPatterns.Libraries.Structural.Adapter
{
    public class Adapter : Adaptee, ITarget
    {
        public string GetMethodA()
        {
            return GetMethodB();
        }
    }
}
