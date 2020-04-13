using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grimusk
{
    class Processor
    {
        // 1 - contador do programa mantem prox instrucao 
        public static int pc = 0;
        public static short IR;
        public static short MQ;
        public static Instruction IAS;
        public static bool hlt = false;
        public static List<string> log = new List<string>(); // serve para mostrar tudo o que fizemos

        public static void Process() // sempre vai processar a instruçao no opcode
        {
            // 2 processador busca instrucao no local de memoria apresentado
            // + 4 instrucao carregada no registrador de instrucao
            Instruction now = Memory.instructions[pc];
            if (now == null)
            {
                MessageBox.Show(pc.ToString());
                hlt = true;
                return;
            }
            IR = now.opcode;
            IAS = now;

            // 3 incrementar pc
            pc++;

            // 4

            // 5 interpretar instrucao
            Resolve(IAS, IR);
        }
        public static void Resolve(Instruction instruction, short opcode)
        {
            short AC;
            // sei la como fazer uma ALUzinha aqui porque meio que tamo programando em alto nivel...????
            // n da pra chamar ASM { } pra bloco de codigo em assembly
            log.Add(opcode.ToString() + ": ");
            switch (opcode)
            {
                case -1: // opcode -1 para parar o programa
                    Program.window.Log.Items.Add("O programa foi parado");
                    hlt = true;
                    break;
                case 0: // opcode 0 limpa o MQ
                    MQ = 0;
                    Program.window.Log.Items.Add("MQ voltou para -> 0");
                    break;
                case 1: // opcode 1 coloca MQ no addr 1 (addr[0])
                    Memory.data[instruction.addr[0]] = MQ;
                    Program.window.Log.Items.Add("O valor de MQ foi guardado em ADDR1 -> [" + instruction.addr[0].ToString() + "]");
                    break;
                case 2: // opcode 2 busca o que ta no addr1, coloca no AC, soma com o que ta no addr2 e coloca no MQ (eu sei que tinha que dividir mais,
                    // faco isso depois se for necessario
                    AC = instruction.addr[0];
                    Program.window.Log.Items.Add("AC se tornou ADDR1 -> " + AC.ToString() + ", somando com ADDR2 -> " + instruction.addr[1].ToString());
                    MQ = (short)(AC + instruction.addr[1]);
                    Program.window.Log.Items.Add("MQ se tornou -> " + MQ.ToString());
                    break;
                case 3: // opcode 3 coloca addr1 no AC, subtrai com addr2 e coloca no MQ
                    AC = instruction.addr[0];
                    Program.window.Log.Items.Add("AC se tornou ADDR1 -> " + AC.ToString() + ", subtraindo com ADDR2 -> " + instruction.addr[1].ToString());
                    MQ = (short)(AC - instruction.addr[1]);
                    Program.window.Log.Items.Add("MQ se tornou -> " + MQ.ToString());
                    break;
                case 4: // opcode 4 multiplica addr1 (addr2)vezes e coloca no MQ
                    AC = instruction.addr[1];
                    Program.window.Log.Items.Add("AC se tornou -> " + AC.ToString());
                    while (AC > 0)
                    {
                        Program.window.Log.Items.Add("AC ainda é maior que 0 (" + AC.ToString() + "), somando MQ novamente e diminuindo AC...");
                        MQ = (short)(MQ + instruction.addr[0]);
                        Program.window.Log.Items.Add("MQ se tornou -> " + MQ.ToString());
                        AC--;
                    }
                    break;
                case 5: // opcode 5 divide addr1 por addr2 e coloca no MQ
                    AC = instruction.addr[1];
                    Program.window.Log.Items.Add("AC se tornou -> " + AC.ToString());
                    while (AC > 0)
                    {
                        Program.window.Log.Items.Add("AC ainda é maior que 0 (" + AC.ToString() + "), somando MQ novamente e diminuindo AC...");
                        MQ = (short)(MQ - instruction.addr[0]);
                        Program.window.Log.Items.Add("MQ se tornou -> " + MQ.ToString());
                        AC--;
                    }
                    break;
                default: // retorna se for opcode invalido
                    return;
            }
            log.Clear();
        }
    }
}
