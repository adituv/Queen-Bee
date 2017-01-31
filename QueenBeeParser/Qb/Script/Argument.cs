using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nanook.QueenBee.Parser.Qb.Script
{
    class Argument : IQbScriptItem
    {
        public LitQbKey Name { get; set; }
        public IQbScriptItem Value { get; set; }

        public void Compile(BinaryEndianWriter bew)
        {
            if (Name != null)
            {
                Name.Compile(bew);
                bew.Write((byte)0x07);
            }
            Value.Compile(bew);
        }

        public override string ToString()
        {
            var ret = "";
            if (Name != null)
            {
                ret = Name + " = ";
            }
            ret += Value.ToString();
            return ret;
        }
    }
}
