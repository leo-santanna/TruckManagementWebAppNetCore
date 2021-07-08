using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TruckManagementWebAppNetCore.Models
{
    [Table("Models")]
    public class TruckModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(2)]
        public string Name { get; set; }

        public List<Truck> Trucks { get; set; }
    }
}
