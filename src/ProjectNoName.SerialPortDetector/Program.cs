using System;
using System.IO.Ports;

namespace ProjectNoName.SerialPortDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting port detection");
            var ports = SerialPort.GetPortNames();
            foreach (var port in ports)
            {
                Console.WriteLine($"Found: {port}");
            }
        }
    }
}
