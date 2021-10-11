using System;

namespace worker_and_people
{
    class Program
    {
        public abstract class People
        {
            public string name;

            private string _status;

            public void status()
            {
                Console.WriteLine(name + " status:" + _status);
            }

            public People(string name, string status)
            {
                this.name = name;
                this._status = status;
            }
        }

        public class Worker : People
        {
            public string position;
            public string function;
            public Worker(string name, string position, string function) : base(name, "worker")
            {
                this.position = position;
                this.function = function;

            }

            public void getPosition()
            {
                Console.WriteLine($"{name} position: {position}");
            }

            public void getFunction()
            {
                Console.WriteLine($"{name} function: {function} ");
            }
        }

        public class Guest : People
        {
            public Guest(string name) : base(name, "guest")
            {
            }
        }

        static void Main(string[] args)
        {
            Worker vova = new Worker("Vova", "ceo", "strategy developer");
            Guest roma = new Guest("Roman");
            vova.status();
            vova.getPosition();
            vova.getFunction();
            roma.status();
            Console.ReadKey();
        }
    }
}
