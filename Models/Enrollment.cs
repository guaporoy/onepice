using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;   

namespace TripulacionGoingMerry.Models
{
    public class Enrollment
    {
        public int Id { get; set; }
        public int TripulantId { get; set; }
        
        // Navigation properties
        public virtual Tripulant Tripulant { get; set; }
       
    }
}