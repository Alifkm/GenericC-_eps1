using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericC___eps_1_
{
    internal class Box<T>
    {
        public T Content { get; set; }

        public string Log()
        {
            return $"Ini box isinya: {Content}";
        }
    }
}
