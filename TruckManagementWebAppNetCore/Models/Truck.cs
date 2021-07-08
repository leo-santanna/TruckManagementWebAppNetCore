using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TruckManagementWebAppNetCore.Models.CustomValidation;
using TruckManagementWebAppNetCore.Models.Enum;

namespace TruckManagementWebAppNetCore.Models
{
    [Table("Trucks")]
    public class Truck
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Ano de Fabricação")]
        [Required(ErrorMessage = "O ano de fabricação é obrigatório.")]
        [MaxLength(4)]
        [CurrentYearOnly(ErrorMessage = "O ano de fabricação deve corresponder ao ano atual.")]
        public string ManufactureYear { get; set; }

        [Display(Name = "Ano do Modelo")]
        [Required(ErrorMessage = "O ano do modelo é obrigatório.")]
        [MaxLength(4)]
        [CurrentOrFollowingYearOnly(ErrorMessage = "O ano do modelo deve corresponder ao ano atual ou ao ano subsequente.")]
        public string ModelYear { get; set; }

        [ForeignKey("ModelId")]
        public int ModelId { get; set; }

        [Display(Name = "Modelo")]
        [IsModelAllowed(ErrorMessage = "Os modelos permitidos são FH ou FM")]
        public TruckModel Model { get; set; }
    }
}
