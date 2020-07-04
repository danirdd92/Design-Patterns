using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    public class CarControllerProxy : ICarController
    {
        private CarController _controller;

        public CarControllerProxy(Car car)
        {
            _controller = new CarController(car);
        }

        
        public void ShowFuelStatus()
        {
            _controller.ShowFuelStatus();
        }

        public void ShowLocation()
        {
            _controller.ShowLocation();
        }
    }
}
