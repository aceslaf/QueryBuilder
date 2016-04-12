using QueryBuilder.CoreInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryBuilder.core
{
    public class Column : IResolvable
    {
        private Table Parent { get; set; }
        public string Name { get; set; }
        public Column(Table t, string name)
        {
            Parent = t;
            Name = name;
        }

        public Column(string tableName, string columName)
        {
            Parent = new Table(tableName);
            Name = columName;
        }

        public string Resolve(IResolver resolver)
        {
            return string.Format(" {0}.{1} ", Parent.Resolve(resolver), Name);
        }
    }
}
