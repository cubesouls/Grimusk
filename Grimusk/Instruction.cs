using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grimusk
{
    class Instruction
    {
        public short opcode; // opcode pode ser -1 por algum motivo entao byte (uint8) nao e aceitavel
        public short[] addr = new short[2];
        // addr[0] = endereco 1
        // addr[1] = endereço 2

        public Instruction(short _opcode, short[] _addr)
        {
            opcode = _opcode;
            addr = _addr;
        }
        public string OpcodeString(short _opcode)
        {   
            return _opcode.ToString();
        }
    }
}
