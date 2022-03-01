using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JSL_Teste_0103.Models
{
    public class Motorista
    {
        [Key]
        public int id { get; set; }
        public string nome { get; set; }
        public string caminhaoMarca { get; set; }
        public string caminhaoModelo { get; set; }
        public string caminhaoPlaca { get; set; }
        public int caminhaoEixos { get; set; }

        public string enderecoMotorista { get; set; }


    }
}