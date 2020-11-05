using Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Models
{
    class Boat : AutoMobile, IAutoMobileActions, IBoatActions
    {

        public Boat()
        {

        }

        public Boat(bool IsOn)
        {
            this.IsOn = IsOn;
        }

        public void SteerLeft()
        {
            throw new NotImplementedException();
        }

        public void Reverse()
        {
            Console.WriteLine("The boat is reversing");
        }

        public void SteerRight()
        {
            throw new NotImplementedException();
        }

        public void Steer(bool steerLeft)
        {
            throw new NotImplementedException();
        }
    }
}
