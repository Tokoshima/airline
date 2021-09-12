using System;
using System.Collections.Generic;

namespace blazortest.Data
{
    public class AircraftType
    {
       /*
        *   Property 1: AircraftTypeID (type: Guid or int)
            Property 2: TypeDesignator (type: string)
            Property 3: Aircraft (Collection/List of Aircraft)
        */
        public int AircraftTypeID { get; set; }
     
        public string TypeDesignator { get; set; }
        
        public List<string> Aircraft { get; set; }
        
    }
}