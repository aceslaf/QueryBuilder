using QueryBuilder.CoreInterfaces;
using QueryBuilder.Statements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryBuilder.Helpers
{
    public static class AdHockResolvableExstensions
    {
        public static IBoolean Wrap<T>(this T statement) where T : IBoolean
        {
            return new AdHockBoolean((IResolver r) =>
            {
                return string.Format(" ({0}) ", statement.Resolve(r));
            });
        }
    }

    public static class BooleanBuilderExstensions
    {
        public static T And<T>(this T builder, Func<IResolver, string> resolveFunction) where T : BooleanStatementBuilder
        {
            return builder.And(new AdHockBoolean(resolveFunction)) as T;
        }

        public static T Or<T>(this T builder, Func<IResolver, string> resolveFunction) where T : BooleanStatementBuilder
        {
            return builder.Or(new AdHockBoolean(resolveFunction)) as T;
        }
    }
}
