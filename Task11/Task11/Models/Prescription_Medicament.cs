using System.ComponentModel.DataAnnotations.Schema;

namespace Task11.Models
{
    public class Prescription_Medicament
    {
        [ForeignKey("Medicament")]
        public int IdMedicament { get; set; }
        [ForeignKey("Prescription")]
        public int IdPrescription { get; set; }
        public int Dose { get; set; }
        public string Details { get; set; }
        public virtual Medicament Medicament { get; set; }
        public virtual Prescription Prescription { get; set; }
    }
}
