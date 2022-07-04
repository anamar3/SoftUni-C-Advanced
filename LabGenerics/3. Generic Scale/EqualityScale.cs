using System;
using System.Collections.Generic;
using System.Text;

namespace GenericScale
{
    class EqualityScale<T>
    {
         T left;
        T right;
        public EqualityScale(T left, T right)
        {

        }
       public bool AreEqual()
        {
            if (this.right.Equals(this.left))
            {
                return true;
            }
            return false;
        }
    }
}
