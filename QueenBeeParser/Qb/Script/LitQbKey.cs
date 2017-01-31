using System;
using System.Collections.Generic;
using System.Linq;

namespace Nanook.QueenBee.Parser.Qb.Script
{
    class LitQbKey : IQbScriptItem
    {
        public QbKey Value { get; set; }

        public void Compile(BinaryEndianWriter bew)
        {
            bew.Write((byte)0x16);
            bew.Write(Value.Crc);
        }

        public override string ToString()
        {
            return this.Value.HasText ? this.Value.Text : string.Format("${0:x8}", this.Value.Crc);
        }
    }
}
