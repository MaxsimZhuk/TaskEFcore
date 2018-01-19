using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7
{
    public class Appointment
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime EndOfActuality { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
        public DateTime Inserted { get; set; }
    }
}
