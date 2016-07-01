using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomapperPractices
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Person {Id=1,Name="God" };
            Mapper.Initialize(cfg => cfg.CreateMap<Person, Employee>());
            var e = Mapper.Map<Employee>(p);
        }
    }

    class Employee
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public string Title { get; set; }
    }

    class Person
    {
        public int Id { get; set; }
        public String Name { get; set; }

    }
}
