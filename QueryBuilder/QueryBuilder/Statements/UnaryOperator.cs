using QueryBuilder.CoreInterfaces;
namespace QueryBuilder.Statements
{
    public class UnaryOperator : IBoolean
    {
        private IResolvable Statement { get; set; }
        protected IResolvable Operator { get; set; }
        public UnaryOperator(IResolvable lStatement, IResolvable opr)
        {
            Statement = lStatement;
            Operator = opr;
        }
        public string Resolve(IResolver resolver)
        {
            return string.Format(" {0} {1} ", Operator.Resolve(resolver), Statement.Resolve(resolver));
        }
    }
}
