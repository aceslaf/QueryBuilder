using QueryBuilder.CoreInterfaces;
using System;

namespace QueryBuilder.Statements
{
    internal class FromStatement : CoreInterfaces.IResolvable
    {
        public Table Table { get; private set; }

        public FromStatement(Table t)
        {
            Table = t;
        }

        public string Resolve(IResolver resolver)
        {
            return string.Format(" FROM {0} AS {1} ", Table.Name, Table.Resolve(resolver));
        }
    }
}