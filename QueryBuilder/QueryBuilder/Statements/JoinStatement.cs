using QueryBuilder.core;
using QueryBuilder.CoreInterfaces;
using QueryBuilder.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryBuilder.Statements
{
    public enum Side
    {
        Left,
        Right
    }

    public enum Inclusivness
    {
        Empty,
        Outer,
        Inner
    }
    public class JoinBuilder : IJoin
    {
        public IBoolean _statement;
        public bool IsDecart { get; set; }
        public Side Side { get; set; }
        public Inclusivness Inclusivness { get; set; }
        public Table MainTable
        {
            get; set;
        }

        public IBoolean Statement
        {
            get { return _statement; }

            //ensure immutability?
            //get { return new AdHockBoolean((r) => _statementBuilder.Resolve(r)); }
        }

        public ISet<Table> Dependencies
        {
            get; private set;
        }

        public JoinBuilder(Table mainTable, IBoolean onStatement)
        {
            MainTable = mainTable;
            _statement = onStatement;
        }

        public string Resolve(IResolver resolver)
        {
            return string.Format(" {0} {1} JOIN {2} AS {3} ON {4}",
                                   Side,
                                   Inclusivness == Inclusivness.Empty ? "" : Inclusivness.ToString(),
                                   MainTable.Name, MainTable.Resolve(resolver),
                                   Statement.Resolve(resolver));
        }
    }

    public interface IJoin : IResolvable, IDependant
    {
        Table MainTable { get; }
        IBoolean Statement { get; }
    }
    public interface IDependant
    {
        ISet<Table> Dependencies { get; }
    }
}
