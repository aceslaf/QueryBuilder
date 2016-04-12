using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryBuilder.CoreInterfaces
{
    public interface IResolvable
    {
         string Resolve(IResolver resolver);
        
    }
}
