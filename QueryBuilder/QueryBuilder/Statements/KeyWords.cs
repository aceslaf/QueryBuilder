using QueryBuilder.CoreInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryBuilder.Statements
{
    public static class Keywords
    {
        public static CoreInterfaces.IResolvable And = new Keyword("AND");
        public static CoreInterfaces.IResolvable LBracket = new Keyword(" ( ");
        public static CoreInterfaces.IResolvable RBracket = new Keyword(" ) ");
        public static CoreInterfaces.IResolvable Equals = new Keyword("=");
        public static CoreInterfaces.IResolvable NotEquals = new Keyword("!=");
        public static CoreInterfaces.IResolvable LsEq = new Keyword("<=");
        public static CoreInterfaces.IResolvable GtEq = new Keyword(">=");
        public static CoreInterfaces.IResolvable Gt = new Keyword(">");
        public static CoreInterfaces.IResolvable Ls = new Keyword("<");
        public static CoreInterfaces.IResolvable Like = new Keyword("Like");
        public static CoreInterfaces.IResolvable Exists = new Keyword("EXISTS");
        public static CoreInterfaces.IResolvable In = new Keyword("IN");
        public static CoreInterfaces.IResolvable NotIn = new Keyword("NOT IN");
        public static CoreInterfaces.IResolvable NotLike = new Keyword("NOT LIKE");
        public static CoreInterfaces.IResolvable Or = new Keyword("OR");
        public static CoreInterfaces.IResolvable From = new Keyword("FROM");
    }

}
