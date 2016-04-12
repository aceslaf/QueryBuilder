using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryBuilder
{
    class Resolver : IResolver
    {
        private string _tablePrefix = "A";
        private string _paramPrefix = "P";
        private int tableCount;
        private int paramCount;
        private Dictionary<string, List<string>> TableNames { get; set; }
        
        public Resolver()
        {
            tableCount = -1;
            paramCount = -1;
            TableNames = new Dictionary<string, List<string>>();
        }

        private string Next()
        {

            tableCount++;
            return string.Format("{0}{1}",_tablePrefix,tableCount);
        }

        public string ResolveParameterName()
        {
            return string.Format("{0}{1}", _paramPrefix, paramCount);
        }

        public string ResolveTableName(Table t)
        {
            List<string> Aliases = null;
            string alias = null;
            if (!TableNames.Keys.Contains(t.Name))
            {
                Aliases = new List<string>();
                alias = Next();
                TableNames.Add(t.Name, Aliases);
                Aliases.Add(alias);
            }
            else
            {
                Aliases = TableNames[t.Name];
            }

            if (t.BanDuplicates)
            {
                alias = Next();
                Aliases.Add(alias);
            }
            else
            {
                alias = Aliases[0];
            }
            
            return alias;
        }

        public string ResolveTableName(string tableName)
        {
            var table = new Table(tableName);
            return ResolveTableName(table);
        }
    }
}
