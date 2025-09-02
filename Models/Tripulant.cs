
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TripulacionGoingMerry.Models
{
    public class Tripulant
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public DateTime EnrollmentDate { get; set; }
        //Virtual
        public virtual ICollection<Enrollment> Enrollments { get; set; }    
    }
}