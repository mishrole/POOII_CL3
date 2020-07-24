using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace POOII_CL3.Entidades
{
    public partial class Vehiculo
    {
        [Key]
        [Display(Name = "Id")]
        public int IdVehiculo { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Ingrese una placa")]
        [MaxLength(20, ErrorMessage = "La placa no debe exceder los 20 caracteres")]
        public string Placa { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Ingrese el año")]
        [RegularExpression("\\d{4}", ErrorMessage = "El año debe ")]
        public int Año { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Ingrese un modelo")]
        [MaxLength(50, ErrorMessage = "El modelo no debe exceder los 50 caracteres")]
        public string Modelo { get; set; }

        [Display(Name = "Marca")]
        public int IdMarca { get; set; }
    }
}
