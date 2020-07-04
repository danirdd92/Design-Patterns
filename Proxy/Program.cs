using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            var bmw = new Car("BMW", "i8");

            var bmwControls = new CarControllerProxy(bmw);

            // This is a protective proxy 
            // Please read more about other proxy patterns
            // at http://www.blackwasp.co.uk/Proxy.aspx

            bmwControls.ShowFuelStatus();
            bmwControls.ShowLocation();



        }
    }
}
// Proxy - Ex. 3