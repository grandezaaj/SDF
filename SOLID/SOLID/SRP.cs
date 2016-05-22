using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP
{
    class SRP
    {
    }

    // SRP
    class Customer
    {
        public void Add()
        {
            try
            {

            }
            catch (Exception ex)
            {

                System.IO.File.WriteAllText(@"c:\Error.txt", ex.ToString());
            }
        }
    }

    //class ErrorLogger
    //{
    //    public void Log(string errorMessage)
    //    {
    //        System.IO.File.WriteAllText(@"c:\Error.txt", errorMessage);
    //    }
    //}

    //class Customer2
    //{
    //    public void Add()
    //    {
    //        ErrorLogger errLogger = new ErrorLogger();
    //        try
    //        {

    //        }
    //        catch (Exception ex)
    //        {
    //            errLogger.Log(ex.Message);
    //        }
    //    }
    //}
}
