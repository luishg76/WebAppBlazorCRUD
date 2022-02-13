using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace WebAppBlazorCRUD.Data
{
    public class Cerveza
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="El Nombre es Obligatorio")]
        public string Nombre { get; set; }
        [Required]
        public string Marca { get; set; }
    }
}
