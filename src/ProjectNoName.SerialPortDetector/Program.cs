using System;
using System.IO.Ports;
using System.Threading;

namespace ProjectNoName.SerialPortDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("Starting port detection");
                var ports = SerialPort.GetPortNames();
                foreach (var port in ports)
                {
                    Console.WriteLine($"Found: {port}");
                }

                Thread.Sleep(5_000);
            }
        }
    }
}
