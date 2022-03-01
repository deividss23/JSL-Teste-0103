using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace JSL_Teste_0103.Models
{
    public class Context : DbContext
    {
        public DbSet<Motorista> Motoristas { get; set; }


    }

    public class Context2 : DbContext
    {
        public DbSet<Viagem> Viagems { get; set; }
    }
}

 