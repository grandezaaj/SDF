using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIC
{
    class DIC
    {
    }

    interface ILogger
    {
        void Log(string errorMessage);
    }

    class FileErrorLogger : ILogger
    {
        public void Log(string errorMessage)
        {
            System.IO.File.WriteAllText(@"c:\Error.txt", errorMessage);
        }
    }

    class EmailErrorLogger : ILogger
    {
        public void Log(string errorMessage)
        {
            // SEND EMAIL
        }
    }

    class EventViewerErrorLogger : ILogger
    {
        public void Log(string errorMessage)
        {
            // LOG ERROR TO EVENT VIEWER
        }
    }


    class Customer
    {
        ILogger logger;
        public Customer(ILogger logger)
        {
            this.logger = logger;
        }

        public void Add()
        {
            try
            {

            }
            catch (Exception ex)
            {
                this.logger.Log(ex.Message);
            }
        }
    }

}
