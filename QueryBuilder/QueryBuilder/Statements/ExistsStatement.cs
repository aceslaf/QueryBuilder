using QueryBuilder.CoreInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryBuilder.Statements
{
    public class ExistsStatement : CoreInterfaces.IResolvable
    {
        private IResolvable InerStatement { get; set; }
        public ExistsStatement(CoreInterfaces.IResolvable statement)
        {
            InerStatement = statement;
        }
        public string Resolve(IResolver resolver)
        {
            return string.Format("{0} ( {1} )", Keywords.Exists, InerStatement.Resolve(resolver));
        }
    }
}
