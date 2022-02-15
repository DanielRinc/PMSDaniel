using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWebAssembly.Shared
{
    public class Huesped
    {
        [Key]
        public int Id { get; set; }
        public string Referencia { get; set; }
        public string DNI { get; set; } 

    }
}
