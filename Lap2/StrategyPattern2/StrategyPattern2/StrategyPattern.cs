using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern2
{
    class StrategyPattern
    {
        // Behavior abstract
        public abstract class VehicaleBehavior
        {
            public abstract string AboutMe(string vehicle);
        }

        // can fly
        class FlyBehavior : VehicaleBehavior
        {
            public override string AboutMe(string vehicle)
            {
                return vehicle;
            }
        }

        // Cant float
        class FloatBehavior : VehicaleBehavior
        {
            public override string AboutMe(string vehicle)
            {
                return vehicle;
            }
        }

        // Just create,haven't done anything yet

        class InitialBehavior : VehicaleBehavior
        {
            public override string AboutMe(string vehicle)
            {
                return vehicle;
            }
        }

        public class Vehicle
        {
            VehicaleBehavior behavior;
            string vehicleType;
            public Vehicle(string vehicleType)
            {
                this.vehicleType = vehicleType;
                this.behavior = new InitialBehavior();
            }
            public void setVehicleBehavior(VehicaleBehavior behavior)
            {
                this.behavior = behavior;
            }
            public string DisplayAboutMe()
            {
                return this.behavior.AboutMe(this.vehicleType);
            }
        }
    }
}
