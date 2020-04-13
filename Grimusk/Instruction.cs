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
            int slot = NextFreeInstructionSlot();
            Program.window.Instructions.Items.RemoveAt(slot);
            string repr = (opcode.ToString() + ": " + addr[0].ToString() + " | " + addr[1].ToString());
            Program.window.Instructions.Items.Insert(slot, repr);
        }

        public int NextFreeInstructionSlot()
        {
            int slot = 0;
            bool found = false;
            while (!found && slot < Memory.GetSize() - 1)
            {
                string query = Program.window.Instructions.Items[slot].ToString();
                if (query.Contains("0x")) found = true;
                else slot++;
            }
            return slot;
        }

        public string OpcodeString(short _opcode)
        {   
            return _opcode.ToString();
        }
    }
}
