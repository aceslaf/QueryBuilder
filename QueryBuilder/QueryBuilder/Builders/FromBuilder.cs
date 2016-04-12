using QueryBuilder.Statements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryBuilder.core
{
    public interface IFromStatementsSorter
    {
        List<IJoin> Sort(Table from,List<IJoin> joins);
    }
    class FromClauseBuilder : BaseComponent
    {
        private IFromStatementsSorter _sorter;
        private FromStatement _from;

        public FromClauseBuilder(FromStatement from,IFromStatementsSorter sorter)
        {
            _from = from;
            _sorter = sorter;
        }

        public FromClauseBuilder Append(IJoin join)
        {
            base.AddBack(join);
            return this;
        }

        public override string Resolve(IResolver resolver)
        {
            _sorter.Sort(_from.Table, new List<IJoin>());
            return base.Resolve(resolver);
        }
        
    }
    

}
