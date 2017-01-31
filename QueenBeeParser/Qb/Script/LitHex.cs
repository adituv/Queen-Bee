using System;
using System.Collections.Generic;
using System.Linq;

namespace Nanook.QueenBee.Parser.Qb.Script
{
    class LitHex : IQbScriptItem
    {
        public UInt32 Value { get; set; }

        public void Compile(BinaryEndianWriter bew)
        {
            bew.Write((byte)0x18);
            bew.Write(Value);
        }

        public override string ToString()
        {
            return string.Format("0x{0:x}", Value);
        }
    }
}
