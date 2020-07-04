using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    internal sealed class CarController : ICarController
    {
        private Car _car;

        public CarController(Car car)
        {
            _car = car;
        }

        public void Start() =>
            Console.WriteLine($"{_car.Brand} {_car.Model} started the ride.");

        public void Brake() =>
            Console.WriteLine($"{_car.Brand} {_car.Model} has stopped.");

        public void Accelerate() =>
            Console.WriteLine($"{_car.Brand} {_car.Model} is accelerating.");

        public void Decelerate() =>
            Console.WriteLine($"{_car.Brand} {_car.Model} is slowing down.");

        public void TurnRight() =>
            Console.WriteLine($"{_car.Brand} {_car.Model} is turning right.");

        public void ShowFuelStatus() =>
            Console.WriteLine($"{_car.Brand} {_car.Model} is running out of fuel.");

        public void ShowLocation() =>
            Console.WriteLine($"{_car.Brand} {_car.Model} is right there.");
    }
}
