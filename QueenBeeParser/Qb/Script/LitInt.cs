using System;
using System.Collections.Generic;
using System.Linq;

namespace Nanook.QueenBee.Parser.Qb.Script
{
    class LitInt : IQbScriptItem
    {
        public Int32 Value { get; set; }

        public void Compile(BinaryEndianWriter bew)
        {
            bew.Write((byte)0x17);
            bew.Write(Value);
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
