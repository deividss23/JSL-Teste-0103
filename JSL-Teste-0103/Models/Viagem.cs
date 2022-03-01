using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JSL_Teste_0103.Models
{
    public class Viagem
    {
        [Key]
        public int id { get; set; }

        public DateTime dataViagem { get; set; }

        public string localSaida { get; set; }

        public string localEntrega { get; set; }

        public double KmViagem { get; set; }

     
    }
}