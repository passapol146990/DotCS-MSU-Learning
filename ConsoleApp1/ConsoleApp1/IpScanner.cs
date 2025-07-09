using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class IpScanner
    {
        public static async Task Scan()
        {
            string baseIp = "10.34.5.";
            Console.WriteLine($"🔍 Starting scan on network: {baseIp}0-255");

            List<Task> tasks = new List<Task>();

            for (int i = 0; i <= 255; i++)
            {
                string ip = baseIp + i.ToString();
                tasks.Add(PingHostAsync(ip));
            }

            await Task.WhenAll(tasks);

            Console.WriteLine("✅ Scan complete.");
        }

        private static async Task PingHostAsync(string ipAddress)
        {
            using (Ping pinger = new Ping())
            {
                try
                {
                    PingReply reply = await pinger.SendPingAsync(ipAddress, 1000);

                    if (reply.Status == IPStatus.Success)
                    {
                        Console.WriteLine($"✔️ Host {ipAddress} is up! Latency: {reply.RoundtripTime}ms");
                    }
                }
                catch (PingException)
                {
                }
            }
        }
    }

    class Program
    {
        static async Task Main(string[] args)
        {
            await IpScanner.Scan();
        }
    }
}