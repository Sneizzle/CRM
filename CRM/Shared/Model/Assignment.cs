using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Shared.Model
{
    public class Assignment
    {
        public int Id { get; set; }

        [Required]
        public float Hours { get; set; } // ServiceHours spent on this task

        [Required]
        public string Description { get; set; }

        [ForeignKey("Customer")]
        public int customerId { get; set; }
        public Customer? Customer { get; set; }

        public DateTime DateCreated { get; set; }
    }
}
