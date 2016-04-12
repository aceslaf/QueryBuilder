using QueryBuilder.CoreInterfaces;
using QueryBuilder.Statements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryBuilder.Helpers
{
    class Resolvable:IResolvable
    {
        public Func<IResolver, string> Func { get; set; }
        public Resolvable(Func<IResolver, string> f)
        {
            Func = f;
        }

        public string Resolve(IResolver resolver)
        {
            return Func(resolver);
        }
    }

    class AdHockBoolean : IBoolean
    {
        public Func<IResolver, string> Func { get; set; }
        public AdHockBoolean(Func<IResolver, string> f)
        {
            Func = f;
        }

        public string Resolve(IResolver resolver)
        {
            return Func(resolver);
        }
    }
}
