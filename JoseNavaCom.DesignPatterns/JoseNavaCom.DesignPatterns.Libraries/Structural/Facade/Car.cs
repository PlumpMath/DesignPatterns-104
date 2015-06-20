using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoseNavaCom.DesignPatterns.Libraries.Structural.Facade
{
    public class Car
    {
        public CarFacade Create()
        {
            CarFacade carFacade = new CarFacade();
            carFacade.CreateCompleteCar();
            return carFacade;
        }
    }
}
