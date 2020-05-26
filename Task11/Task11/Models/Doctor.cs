using System.Collections.Generic;

namespace Task11.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Prescription> Prescriptions { get; set; }
    }
}
