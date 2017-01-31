using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nanook.QueenBee.Parser.Qb.Script
{
    public interface IQbScriptItem
    {
        void Compile(BinaryEndianWriter bew);
    }
}
