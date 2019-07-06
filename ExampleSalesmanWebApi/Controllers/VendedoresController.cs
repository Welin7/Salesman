using ExampleSalesmanWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ExampleSalesmanWebApi.Controllers
{
    public class VendedoresController : ApiController
    {
        private static List<Vendedores> ListaVendedores = new List<Vendedores>();

        //metodo get
        public List<Vendedores> Get()
        {
            return ListaVendedores;
        }

        //metodo post
        public void Post(string nome)
        {
            if (!string.IsNullOrEmpty(nome))
                ListaVendedores.Add(new Vendedores(nome));
        }

        //metodo delete
        public void Delete(string nome)
        {
            ListaVendedores.RemoveAt(ListaVendedores.IndexOf(ListaVendedores.First(c => c.Nome.Equals(nome))));
        }
    }
}
