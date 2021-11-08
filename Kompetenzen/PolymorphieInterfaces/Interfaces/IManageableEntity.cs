using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphieInterfaces
{
    public interface IManageableEntity
    {
        public object Parent { get; set; }

        public IEnumerable<IManageableEntity> Children { get; set; }

        void AddChild(IManageableEntity child);

        void SetParent();
    }
}
