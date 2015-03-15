using System;
using System.Diagnostics;
using System.ServiceModel;
using Zza.Services;

namespace Zza.SelfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Constructor reads configuration.
                var host = new ServiceHost(typeof (ZzaService));

                // Begin listening for requests.
                host.Open();

                // Wait until finished.
                Console.WriteLine("Press any key when finished.");
                Console.ReadKey();

                // When finished, ask host to stop processing **additional**
                // requests (it will complete the processing of in-process
                // requests.
                host.Close();
            }
            catch (Exception exception)
            {
                // Log exceptions so we can see it in Visual Studio.
                Debug.WriteLine(exception);
            }
        }
    }
}
