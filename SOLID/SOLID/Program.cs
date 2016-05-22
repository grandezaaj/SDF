using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
   

    class Program
    {
        static void Main(string[] args)
        {

            // LSP
            //List<SOLID.LSP.Customer> customers = new List<LSP.Customer>();
            //customers.Add(new SOLID.LSP.GoldCustomer());
            //customers.Add(new SOLID.LSP.SilverCustomer());
            //customers.Add(new SOLID.LSP.Lead());

            //foreach (var customer in customers)
            //{
            //    customer.Add();
            //}


            // CORRECT FOR LSP
            //List<SOLID.LSP.IDatabase> customers = new List<LSP.Customer>();
            //customers.Add(new SOLID.LSP.GoldCustomer());
            //customers.Add(new SOLID.LSP.SilverCustomer());
            //customers.Add(new SOLID.LSP.Lead());

            //foreach (var customer in customers)
            //{
            //    customer.Add();
            //}


            // DIC
            SOLID.DIC.Customer customer = new DIC.Customer(new SOLID.DIC.FileErrorLogger());
            customer.Add();


        }
    }
}
