using System;

namespace worker_and_people
{
    class Program
    {
        public abstract class People
        {
            public string name;

            public void status()
            {
                Console.WriteLine(name + "status:" + this.status);
            }

            public People(string name)
            {
                this.name = name;
            }
        }

        public class Worker : People
        {
            public Worker(string name):base(name)
            {
                
            }
            protected void position() {

            }
            protected void function()
            {

            }
        }

        public class Guest : People { }

        static void Main(string[] args)
        {
            Worker vova = new Worker();
            vova.name = "Vova";

            Guest roma = new Guest();
            roma.name = "Roman";
            Console.ReadKey();
        }
    }
}
