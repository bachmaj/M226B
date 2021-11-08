using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphieInterfaces
{
    public abstract class Vehicle : BaseModel, IManageableEntity, ICloneable
    {
        public string Brand { get; set; }

        public IEnumerable<IManageableEntity> Children { get; set; }

        public Location Location { get; set; }

        public string Name { get; set; }

        public object Parent { get; set; }

        public new string Text { get; set; }

        public Vehicle()
        {

        }

        public Vehicle(string name)
        {
            Name = name;
        }

        public void Drive()
        {

        }

        public void IsAvailable()
        {

        }

        public void Reserve()
        {

        }

        public void AddChild(IManageableEntity child)
        {
            Children = Children.Append(child);
        }

        public void SetParent()
        {

        }

        public object Clone()
        {
            return this;
        }
    }
}
