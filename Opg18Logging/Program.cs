using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg18Logging
{
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            logger.Debug("\n\r\nPROGRAM START");
            test1(5, 5);
            test2();
        }
        static void test1(int i, int x)
        {
            logger.Debug("Enter");
            Console.WriteLine("test1");
            try
            {
                int a = i / (x - 5);
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
            System.Threading.Thread.Sleep(3000);
            logger.Trace("Exit");

        }
        static void test2()
        {
            logger.Debug("Enter");
            try
            {
                Console.WriteLine("test2");
                  int a = 0;
                int j = 3 / a;
                throw new ApplicationException("fejl");
              
            }
            catch (Exception ex)
            {// mangler log
                logger.Error(ex);
                logger.Debug("nu med message");
                logger.Error(ex, ex.Message);
            }
            logger.Trace("Exit");

        }
    }
}
