using System;
using Titanium.Web.Proxy.Examples.Basic.Helpers;
using Titanium.Web.Proxy.Helpers;

namespace Titanium.Web.Proxy.Examples.Basic
{
    using System.Net;

    public class Program
    {
        private static readonly ProxyTestController controller = new ProxyTestController();

        public static void Main(string[] args)
        {

            if (RunTime.IsWindows)
            {
                // fix console hang due to QuickEdit mode
                ConsoleHelper.DisableQuickEditMode();
            }

            int numArgs = args.Length;
            if (numArgs == 0)
            {
                // Start proxy controller
                controller.StartProxy();
            }
            else if (numArgs == 1)
            {
                // assume 3
                // Start proxy controller
                controller.StartProxy(args[0]);
            }
            else
            {
                controller.StartProxy(args[0], args[1], args[2]);
            }

           

            Console.WriteLine("Hit any key to exit..");
            Console.WriteLine();
            Console.Read();

            controller.Stop();
        }
    }
}
