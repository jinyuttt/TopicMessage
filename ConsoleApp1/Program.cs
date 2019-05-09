using System;
using System.Threading;
using TopicMessage;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Subscriber.Singleton.Subscrib("Test");
            Subscriber.Singleton.TopicDataNotify += Singleton_TopicDataNotify;
            while (true)
            {
                Publisher.Singleton.Publish("Test", DateTime.Now.ToString());
                Thread.Sleep(1000);
            }
        }

        private static void Singleton_TopicDataNotify(object sender, string topic, object info)
        {
            Console.WriteLine(info);
        }
    }
}
