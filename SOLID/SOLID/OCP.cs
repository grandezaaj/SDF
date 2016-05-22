using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP
{
    class OCP
    {
    }

    //class Customer
    //{
    //    private int customerType;

    //    public int CustomerType
    //    {
    //        get { return customerType; }
    //        set { customerType = value; }
    //    }

    //    public double GetDiscount(double TotalSales)
    //    {
    //        if (customerType == 1)
    //        {
    //            return TotalSales - 100;
    //        }
    //        else
    //        {
    //            return TotalSales - 50;
    //        }
    //    }
    //}

    class Customer
    {
        public virtual double GetDiscount(double totalSales)
        {
            return totalSales;
        }
    }

    class SilverCustomer : Customer
    {
        public override double GetDiscount(double totalSales)
        {
            return base.GetDiscount(totalSales) - 50;
        }
    }

    class GoldCustomer : SilverCustomer
    {
        public override double GetDiscount(double totalSales)
        {
            return base.GetDiscount(totalSales) - 100;
        }
    }


}
