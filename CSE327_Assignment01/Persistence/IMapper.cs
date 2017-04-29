using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE327_Assignment01
{
    public interface IMapper
    {
        Object get(string id);
        void put(Object obj);

    }
}
