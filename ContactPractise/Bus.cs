using System;
using System.Collections.Generic;
using System.Text;

namespace ContactPractise
{
    public class Bus:Car
    {
        public Bus():base("Lorem","Ipsum")
        {

        }
        public string Info()
        {
            return $"{Brand} {HorsePower}";
        }
    }
}
