using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP
{
    class LSP
    {
    }

    //public class Customer
    //{
    //    public virtual double GetDiscount(double totalSales)
    //    {
    //        return totalSales;
    //    }

    //    public virtual void Add()
    //    {

    //    }
    //}

    //public class SilverCustomer : Customer
    //{
    //    public override double GetDiscount(double totalSales)
    //    {
    //        return base.GetDiscount(totalSales) - 50;
    //    }
    //}

    //public class GoldCustomer : SilverCustomer
    //{
    //    public override double GetDiscount(double totalSales)
    //    {
    //        return base.GetDiscount(totalSales) - 100;
    //    }
    //}

    //public class Lead : Customer
    //{
    //    public override double GetDiscount(double totalSales)
    //    {
    //        return base.GetDiscount(totalSales) - 5;
    //    }

    //    public override void Add()
    //    {
    //        throw new Exception("Not allowed");
    //    }
    //}


    public interface IDiscount
    {
        double GetDiscount(double totalSales);
    }

    public interface IDatabase
    {
        void Add();
    }


    public class Lead : IDiscount
    {
        public override double GetDiscount(double totalSales)
        {
            return totalSales - 50;
        }
    }


    public class Customer : IDatabase, IDiscount
    {
        public virtual double GetDiscount(double totalSales)
        {
            return totalSales;
        }

        public virtual void Add()
        {

        }
    }


    // REMEMBER: IN ISP, ADD NEW KIND OF CUSTOMER, WITH NEW FUNCTIONALITY

}
