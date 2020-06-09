using System;
using System.Collections.Generic;

namespace Capstone6_CarDealership.Models
{
    public partial class Car
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public DateTime? Year { get; set; }
        public string Color { get; set; }
    }
}
