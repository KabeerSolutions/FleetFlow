﻿using FleetFlow.Domain.Commons;

namespace FleetFlow.Domain.Entities
{
    public class Address : Auditable
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
