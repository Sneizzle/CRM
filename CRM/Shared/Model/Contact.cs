using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Shared.Model
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public bool IsHidden { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } // Reference navigation
    }
}
