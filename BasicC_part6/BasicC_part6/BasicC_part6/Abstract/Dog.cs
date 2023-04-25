using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_part6.Abstract
{
    internal class Dog : IAnimal
    {
        public void MakeSound(int Sound)
        {
            throw new NotImplementedException();
        }

        public void MakeSound(string Sound)
        {
            throw new NotImplementedException();
        }

        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}
