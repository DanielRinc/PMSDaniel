﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWebAssembly.Shared
{
    public class Documento
    {
        

        [Key]
        public int Id { get; set; }
        public string DNI { get; set; }
        public string Name { get; set; }
        public string File64 { get; set; }
    }
}
