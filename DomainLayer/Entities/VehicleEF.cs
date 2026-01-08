using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Entities
{
    public class VehicleEF
    {
        [Key]
        public Guid Id { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string NickName { get; set; } = string.Empty;
        
        [Required]
        public int Year { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string Make { get; set; } = string.Empty;
        
        [Required]
        [MaxLength(50)]
        public string Model { get; set; } = string.Empty;
        
        [Required]
        [MaxLength(17)]
        public string VIN { get; set; } = string.Empty;
        
        [Required]
        [MaxLength(20)]
        public string LicensePlate { get; set; } = string.Empty;
        
        [Required]
        public int CurrentOdometer { get; set; }
        
        public DateTime? PurchasedDate { get; set; }
        
        public int? PurchasedPrice { get; set; }
        
        // Navigation properties can be added here
        // public ICollection<ServiceRecord> ServiceRecords { get; set; } = new List<ServiceRecord>();
    }
}
