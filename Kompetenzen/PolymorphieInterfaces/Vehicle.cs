using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphieInterfaces
{
    public class Vehicle : BaseModel, IManageableEntity
    {
        public string Brand { get; set; }

        public object Children { get; set; }

        public Location Location { get; set; }

        public string Name { get; set; }

        public object Parent { get; set; }

        public string Text { get; set; }

        public Vehicle()
        {

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

        public void AddChild()
        {
            
        }

        public void SetParent()
        {

        }


    }
}
