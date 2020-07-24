using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOII_CL3.Entidades
{
    public partial class Vehiculo
    {
        [Display(Name = "Marca")]
        public string Marca { get; set; }

    }
}
