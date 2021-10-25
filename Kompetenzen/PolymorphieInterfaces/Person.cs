using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphieInterfaces
{
    public class Person : BaseModel, IManageableEntity
    {
        private object _location;

        public object Parent { get; set; }

        public object Child { get; set; }

        public string Name { get; set; }

        public Person()
        {

        }

        public virtual void AddChild()
        {

        }

        public virtual void SetParent()
        {

        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Type of Person: {Parent.GetType().Name}");
            Console.WriteLine($"Name of Person: {Name}");
            Console.WriteLine($"Location of Person: {_location}");
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
