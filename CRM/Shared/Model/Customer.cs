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
        public string Name { get; set; }
        public string? StreetName { get; set; }
        public string? ZipCode { get; set; }
        public string? CityName { get; set; }
        public string? PhoneNumber { get; set; }
        public int? ServiceHours { get; set; }
        public string CVR { get; set; }
        public string EAN { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public bool IsHidden { get; set; }
    }
}
