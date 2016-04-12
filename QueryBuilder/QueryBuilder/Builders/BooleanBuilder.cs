using QueryBuilder.core;
using QueryBuilder.CoreInterfaces;
using QueryBuilder.Helpers;
using QueryBuilder.Statements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryBuilder
{
    public class BooleanStatementBuilder :IBoolean
    {
        public IBoolean Component { get; private set; }
        public BooleanStatementBuilder(IBoolean initialStatement)
        {
            Component = initialStatement;
        }

        public BooleanStatementBuilder And(IBoolean statement)
        {
            if (Component == null)
            {
                Component = statement;
            }
            else
            {
                Component = new AndStatement(Component, statement.Wrap());
            }
            
            return this;
        }

        public BooleanStatementBuilder Or(IBoolean statement)
        {
            if (Component == null)
            {
                Component = statement;
            }
            else
            {
                Component = new OrStatement(Component, statement.Wrap());
            }

            return this;
        }

        public string Resolve(IResolver resolver)
        {
            return Component.Resolve(resolver);
        }
    }

    public class Query: IBoolean
    {
        public bool Distinct { get; set; }
        public IBoolean Select { get; set; }
        public IBoolean From { get; set; }
        public IBoolean Where { get; set; }

        public string Resolve(IResolver resolver)
        {
            var select = Select.Resolve(resolver);
            var from = From.Resolve(resolver);
            var where = Where.Resolve(resolver);
            if (string.IsNullOrWhiteSpace(where))
            {
                where = " 1 = 1 ";
            }

            return string.Format("SELECT {0} {1} {2} WHERE {3} ", Distinct ? "DISTINCT" : "", select,from,where);
        }
    }
}
