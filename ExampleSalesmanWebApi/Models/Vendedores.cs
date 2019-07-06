using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExampleSalesmanWebApi.Models
{
    public class Vendedores
    {
        public string Nome { get; set; }

        public Vendedores(string Nome)
        {
            this.Nome = Nome;
        }
    }
}