using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoseNavaCom.DesignPatterns.Libraries.Structural.Facade
{
    public class CarFacade
    {
        private readonly CarModel carModel;
        private readonly CarEngine carEngine;
        private readonly CarBody carBody;
        private readonly CarAccessories carAccessories;

        private string _model;
        private string _engine;
        private string _body;
        private string _accessories;

        public string Model { 
            get {
                return _model;
            } 
        }

        public string Engine
        {
            get
            {
                return _engine;
            }
        }

        public string Body
        {
            get
            {
                return _body;
            }
        }

        public string Accessories
        {
            get
            {
                return _accessories;
            }
        }

        public CarFacade()
        {
            carModel = new CarModel();
            carEngine = new CarEngine();
            carBody = new CarBody();
            carAccessories = new CarAccessories();

            _model = String.Empty;
            _engine = String.Empty;
            _body = String.Empty;
            _accessories = String.Empty;
        }

        public void CreateCompleteCar()
        {
            _model = carModel.SetModel();
            _engine = carEngine.SetEngine();
            _body = carBody.SetBody();
            _accessories = carAccessories.SetAccessories();
        }
    }
}
