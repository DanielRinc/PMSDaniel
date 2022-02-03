using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWebAssembly.Shared
{
    public class Reserva
    {
        [Key]
        public string Num_reserva { get; set; }

        public DateTime Fec_entrada { get; set; }

        //fecha de entrada
        public DateTime Fec_salida { get; set; }
        //fecha salida
        public bool VIP { get; set; }
        //tipo de habitacion
        public string Tip_pension { get; set; }
        //tipo de pension
        public int Num_adultos { get; set; }
        //num_adultos
        public int Num_menores { get; set; }
        //num_menores
        public string Habitacion { get; set; }
        //Habitacion
        public float Bill { get; set; }

        public Boolean TermsAccepted { get; set; }

    }
}

