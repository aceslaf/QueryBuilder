using QueryBuilder.CoreInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryBuilder.Statements
{
    public class BinaryOperator : IBoolean
    {
        private IResolvable LStatement { get; set; }
        private IResolvable RStatement { get; set; }

        protected IResolvable Operator { get; set; }
        protected BinaryOperator(IResolvable lStatement, IResolvable rStatement, IResolvable opr)
        {
            LStatement = lStatement;
            RStatement = rStatement;
            Operator = opr;
        }
        public string Resolve(IResolver resolver)
        {
            return string.Format(" {0} {1} {2} ", LStatement.Resolve(resolver), Operator.Resolve(resolver), RStatement.Resolve(resolver));
        }
    }
}
