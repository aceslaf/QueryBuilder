using QueryBuilder.CoreInterfaces;
using QueryBuilder.Statements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryBuilder
{
    public class BaseComponent: CoreInterfaces.IResolvable
    {

        public BaseComponent()
        {
            _subComponents = new List<CoreInterfaces.IResolvable>();
        }

        public BaseComponent(CoreInterfaces.IResolvable statement):this()
        {
            AddFront(statement);
        }

        public  List<CoreInterfaces.IResolvable> Components{ get { return _subComponents.ToList(); } }
        private List<CoreInterfaces.IResolvable> _subComponents { get; set; }
       
        public BaseComponent AddBack(CoreInterfaces.IResolvable statement)
        {
            _subComponents.Add(statement);
            return this;
        }

        public BaseComponent AddFront(CoreInterfaces.IResolvable statement)
        {
            _subComponents.Insert(0,statement);
            return this;
        }

        public BaseComponent Wrap()
        {
            AddFront( Keywords.LBracket);
            AddBack(Keywords.RBracket);
            return this;
        }

        public virtual string Resolve(IResolver resolver)
        {
            return string.Join(" ", _subComponents.Select(x => x.Resolve(resolver)));
        }
    }

    //public class BaseBooleanComponent : IBoolean
    //{

    //    public BaseBooleanComponent()
    //    {
    //        _subComponents = new List<CoreInterfaces.IResolvable>();
    //    }

    //    public BaseBooleanComponent(CoreInterfaces.IResolvable statement) : this()
    //    {
    //        AddFront(statement);
    //    }

    //    public List<CoreInterfaces.IResolvable> Components { get { return _subComponents.ToList(); } }
    //    private List<CoreInterfaces.IResolvable> _subComponents { get; set; }

    //    public BaseComponent AddBack(CoreInterfaces.IResolvable statement)
    //    {
    //        _subComponents.Add(statement);
    //        return this;
    //    }

    //    public BaseComponent AddFront(CoreInterfaces.IResolvable statement)
    //    {
    //        _subComponents.Insert(0, statement);
    //        return this;
    //    }

    //    public BaseComponent Wrap()
    //    {
    //        AddFront(Keywords.LBracket);
    //        AddBack(Keywords.RBracket);
    //        return this;
    //    }

    //    public virtual string Resolve(IResolver resolver)
    //    {
    //        return string.Join(" ", _subComponents.Select(x => x.Resolve(resolver)));
    //    }
    //}

}
