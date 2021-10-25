using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphieInterfaces
{
    interface IManageableEntity
    {
        public object Parent { get; set; }

        public IEnumerable<object> Children { get; set; }

        void AddChild(object child);

        void SetParent();
    }
}
