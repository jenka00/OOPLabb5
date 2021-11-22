using System;
using System.Collections.Generic;
using System.Text;

namespace OOPLabb5
{
    class Check<Unknown>
    {
        public virtual bool toCheck(Unknown number1, Unknown number2)
        {
            return number1.Equals(number2);
        }
    }

    class Child1<Unknown> : Check<Unknown>
    {
        public override bool toCheck(Unknown number1, Unknown number2)
        {
            return number1.Equals(number2);
        }
    }

    class Child2<Unknown> : Check<Unknown>
    {
        public override bool toCheck(Unknown string1, Unknown string2)
        {
            return string1.Equals(string2);
        }
    }


}
