using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nanook.QueenBee.Parser.Qb.Script
{
    abstract class Instruction : IQbScriptItem
    {
        public abstract void Compile(BinaryEndianWriter bew);
    }
}
