namespace JoseNavaCom.DesignPatterns.Libraries.Structural.Decorator
{
    public class CakeDecorator
    {
        public double GetPrice()
        {
            CakeBase cakeBase = new CakeBase();
            CreamDecorator creamCake = new CreamDecorator(cakeBase);
            CherryDecorator cherryCake = new CherryDecorator(creamCake);
            ArtificialScentDecorator artificialScentCake = new ArtificialScentDecorator(cherryCake);
            NameCardDecorator nameCardCake = new NameCardDecorator(artificialScentCake);
            return nameCardCake.GetPrice();
        }
    }
}
