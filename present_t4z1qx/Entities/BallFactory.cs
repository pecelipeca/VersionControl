﻿using present_t4z1qx.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace present_t4z1qx.Entities
{
    public class BallFactory : IToyFactory
    {
        public Toy CreateNew()
        {
            return new Ball();
        }

        Toy IToyFactory.CreateNew()
        {
            throw new NotImplementedException();
        }
    }
}
