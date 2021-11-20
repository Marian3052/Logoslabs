using System;

namespace virtualTaskBronze
{

    class Program
    {
        class People
        {
            private string _name {get; set;}
            public string name => _name;

            private int _age {get; set;}
            public int age => _age;
            public People(string name, int age)
            {
                this._age=age;
                this._name=name;
            }
            public virtual void GetInfo()
            {
                System.Console.WriteLine($"Name: {name} - age: {age}");
            }
        }

        class Employee : People
        {
            private string _company {get; set;}
            public string company => _company;

            public Employee(string name, int age, string company) : base(name, age)
            {
                this._company = company;
            }
            public override void GetInfo()
            {
                System.Console.WriteLine($"Name: {name} - age: {age} working in the company: {company}");
            }
        }

       
        static void Main(string[] args)
        {
            People people = new People("oleg",18);
            people.GetInfo();
            Employee employee = new Employee("Tomas",27,"SoftServe");
            employee.GetInfo();
            
            

            Console.ReadKey();
        }
    }
}
