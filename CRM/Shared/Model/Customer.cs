using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Shared.Model
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string? StreetName { get; set; }

        public string? ZipCode { get; set; }

        public string? CityName { get; set; }

        public string? PhoneNumber { get; set; }

        public float? ServiceHours { get; set; }

        public int? EmployeeCount { get; set; }

        [Required, MinLength(8, ErrorMessage = "EAN Skal være på 13 tal"), MaxLength(8, ErrorMessage ="CVR Nummer skal være på 8 tal")]
        public string CVR { get; set; }

        [MinLength(13, ErrorMessage = "EAN Skal være på 13 tal"), MaxLength(13, ErrorMessage ="EAN Skal være på 13 tal")]
        public string? EAN { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public bool IsHidden { get; set; }

    }
}
