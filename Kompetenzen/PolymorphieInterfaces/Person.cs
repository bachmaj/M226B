using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphieInterfaces
{
    public class Person : BaseModel, IManageableEntity, ICloneable
    {
        private object _location;

        public object Parent { get; set; }

        public IEnumerable<IManageableEntity> Children { get; set; }

        public string Name { get; set; }

        public Person()
        {

        }

        public virtual void AddChild(IManageableEntity child)
        {
            Children = Children.Append(child);
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

        public object Clone()
        {
            return this;
        }
    }
}
