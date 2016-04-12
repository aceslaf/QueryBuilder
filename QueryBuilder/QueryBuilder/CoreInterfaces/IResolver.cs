using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryBuilder
{
    public interface IResolver
    {
         string ResolveTableName(Table t);
        string ResolveTableName(string t);
    }
}
