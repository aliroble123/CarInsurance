using System;
using System.ComponentModel.DataAnnotations;

namespace CarInsurance.Models
{
    public class Insuree
    {
        public int Id { get; set; }
        [Required, StringLength(100)] public string FirstName { get; set; }
        [Required, StringLength(100)] public string LastName { get; set; }
        [Required, EmailAddress, StringLength(255)] public string EmailAddress { get; set; }
        [DataType(DataType.Date)] public DateTime DateOfBirth { get; set; }
        [Range(1886, 2100)] public int CarYear { get; set; }
        [Required, StringLength(100)] public string CarMake { get; set; }
        [Required, StringLength(100)] public string CarModel { get; set; }
        public bool DUI { get; set; }
        [Range(0, 100)] public int SpeedingTickets { get; set; }
        public bool CoverageType { get; set; }
        [DataType(DataType.Currency)] public decimal Quote { get; set; }
    }
}
