using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nanook.QueenBee.Parser.Qb.Script
{
    class FunctionCall : Instruction
    {
        public LitQbKey Name { get; set; }
        public List<Argument> Arguments { get; set; } 

        public override void Compile(BinaryEndianWriter bew) {
            bew.Write((byte)0x01);
            Name.Compile(bew);
            foreach (var arg in Arguments)
            {
                arg.Compile(bew);
            }
        }

        public override string ToString()
        {
            string argsString = Arguments.Aggregate("", (current, arg) => current + ("," + arg.ToString()));
            return string.Format("{0}({1});", Name, argsString.TrimStart(','));
        }
    }
}
