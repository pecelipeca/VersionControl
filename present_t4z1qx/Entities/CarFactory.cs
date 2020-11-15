using present_t4z1qx.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace present_t4z1qx.Entities
{
    public class CarFactory : IToyFactory
    {
        public Toy CreateNew()
        {
            return new Car();
        }

        Toy IToyFactory.CreateNew()
        {
            throw new NotImplementedException();
        }
    }
}
