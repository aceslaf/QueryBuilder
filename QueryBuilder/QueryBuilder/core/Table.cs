using QueryBuilder.core;
using QueryBuilder.CoreInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryBuilder
{
   
    public class Table: IResolvable
    {
        public string Name { get; private set; }
        public Column Column(string columnName)
        {
            return new Column(this, columnName);
        }
        private string Alias { get;  set; }
        public bool BanDuplicates { get; private set; }
        public bool ForceAlias { get; private set; }
        public override string ToString()
        {
            throw new Exception();
        }

        public string Resolve(IResolver resolver)
        {
            if (ForceAlias)
            {
                return Alias;
            }

            return resolver.ResolveTableName(this);
        }

        public Table(string name)
        {
            Name = name;
            BanDuplicates = true;
        }

        public Table(string name, string forcedAliac)
        {
            Name = name;
            BanDuplicates = true;
            Alias = forcedAliac;
            ForceAlias = true;
        }
    }
}
