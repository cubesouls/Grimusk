using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grimusk
{
    class Memory
    {
        private static short size = 24; // vou usar getter aqui porque nao quero modificacoes na memoria por fora
        public static Instruction[] instructions = new Instruction[size]; // 3bytes ram, pode aumentar depois ou sei la
        public static int[] data = new int[size];
        public static short FindNextAddress() // encontra o prox endereco nao utilizado de memoria
        {
            short addr = -1;
            short x = 0;
            while (addr == -1)
            {
                if (instructions[x] == null)
                {
                    addr = x;
                }
                else if (instructions[x].opcode == 0)
                {
                    addr = x;
                }
                else
                {
                    x++;
                }
            }
            return addr;
        }

        public static short GetSize()
        {
            return size;
        }
    }
}
