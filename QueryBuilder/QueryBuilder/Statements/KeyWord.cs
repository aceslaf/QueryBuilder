using QueryBuilder.CoreInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryBuilder.Statements
{

    public class Keyword : CoreInterfaces.IResolvable
    {
        public string Name { get; private set; }
        public string Resolve(IResolver resolver)
        {
            return Name;
        }
        public Keyword(string keyword)
        {
            Name = keyword;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
