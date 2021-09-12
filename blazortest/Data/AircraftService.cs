//utilizes the Aircraft interface in order to provide a service to whichever component needs it
using System;
using System.Collections.Generic;
using System.Linq;

namespace blazortest.Data
{
    public class AircraftService : AircraftIE
    {
        private List<Aircraft> aircraft = new List<Aircraft>
        {
            new Aircraft
            {
                Registration = "ZS-CEM",
                Manufacturer = "Beechcraft",
                Passenger = 19,
                AircraftType = null,
                AircraftTypeID = Guid.NewGuid()
            }
        };
        public List<Aircraft> GetAircraft()
        {
            return aircraft;
        }

        public Aircraft GetPlane(string registration)
        {
            return aircraft.SingleOrDefault(x => x.Registration == registration);
        }
    }
}