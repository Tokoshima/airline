//Provides the lowest level atmomic data
using System;
using System.Collections.Generic;

namespace blazortest.Data
{
    public class Aircraft 
    {
        /*
         *  Property 1: Registration (type: string)
            Property 2: Manufacturer (type: string)
            Property 3: Passenger capacity (type: int - Nullable)
            Property 4: AircraftType (type: AircraftType)
            Property 5: AircraftTypeID (type: Guid or int - Nullable)
         */
        
        public string Registration { get; set; }

        public string Manufacturer { get; set; }

        public int Passenger { get; set; }

        public AircraftType AircraftType { get; set; }
        
        public Guid AircraftTypeID { get; set; }
        
    }
}