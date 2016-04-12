using QueryBuilder.CoreInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryBuilder.Statements
{
    public class InStatement : UnaryOperator
    {
        public InStatement(IResolvable statement) : base(statement, Keywords.In) { }
    }

    public class NotInStatement : UnaryOperator
    {
        public NotInStatement(IResolvable statement) : base(statement, Keywords.NotIn) { }
    }

    public class AndStatement : BinaryOperator
    {
        public AndStatement(IBoolean lStatement, IBoolean rStatement)
        : base(lStatement, rStatement, Keywords.And)
        {
        }
    }

    public class OrStatement : BinaryOperator
    {
        public OrStatement(IBoolean lStatement, IBoolean rStatement)
        : base(lStatement, rStatement, Keywords.Or)
        {
        }
    }

    public class LikeStatement : BinaryOperator
    {
        public LikeStatement(IResolvable lStatement, IResolvable rStatement)
        : base(lStatement, rStatement, Keywords.Like)
        {
        }
    }

    public class Equals : BinaryOperator
    {
        public Equals(IResolvable lStatement, IResolvable rStatement)
        : base(lStatement, rStatement, Keywords.Equals)
        {
        }
    }

    public class LessThen : BinaryOperator
    {
        public LessThen(IResolvable lStatement, IResolvable rStatement)
        : base(lStatement, rStatement, Keywords.Ls)
        {
        }
    }

    public class LessOrEqual : BinaryOperator
    {
        public LessOrEqual(IResolvable lStatement, IResolvable rStatement)
        : base(lStatement, rStatement, Keywords.LsEq)
        {
        }
    }

    public class Greater : BinaryOperator
    {
        public Greater(IResolvable lStatement, IResolvable rStatement)
        : base(lStatement, rStatement, Keywords.Gt)
        {
        }
    }

    public class GreaterOrEqual : BinaryOperator
    {
        public GreaterOrEqual(IResolvable lStatement, IResolvable rStatement)
        : base(lStatement, rStatement, Keywords.GtEq)
        {
        }
    }

    public class NotLikeStatement : BinaryOperator
    {
        public NotLikeStatement(IResolvable lStatement, IResolvable rStatement)
        : base(lStatement, rStatement, Keywords.NotLike)
        {
        }
    }

}
