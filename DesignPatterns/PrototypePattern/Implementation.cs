using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public abstract class Person
    {
        public abstract string Name { get; set; }
        public abstract Person Clone(bool deepClone);
    }

    public class Manager : Person
    {
        public override string Name { get; set; }

        public Manager(string name)
        {
            Name = name;
        }

        public override Person Clone(bool deepClone = false)
        {
            if (deepClone)
            {
                var objectAsJson = JsonSerializer.Serialize(this);
                return JsonSerializer.Deserialize<Manager>(objectAsJson);

            }
            return (Person)MemberwiseClone(); // Shallow Copy method
        }
    }

    public class Employee : Person
    {
        public Manager Manager { get; set; }
        public override string Name { get; set; }

        public Employee(string name, Manager manager)
        {
            Name = name;
            Manager = manager;
        }

        public override Person Clone(bool deepClone = false)
        {
            if (deepClone) {
                var objectAsJson = JsonSerializer.Serialize(this);
                return JsonSerializer.Deserialize<Employee>(objectAsJson);

            }
            return (Person)MemberwiseClone();
        }
    }
}
