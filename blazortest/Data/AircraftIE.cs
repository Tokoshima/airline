//provides an interface for accessing the class Aircraft.cs

using System;
using System.Collections.Generic;

namespace blazortest.Data
{
    public interface AircraftIE
    {
        List<Aircraft> GetAircraft();

        Aircraft GetPlane(string registation);
    }
}