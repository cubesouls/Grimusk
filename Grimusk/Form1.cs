using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grimusk
{
    public enum OPCODE : short
    {
        HLT = -1, // halt
        CLR = 0, // clear
        STA = 1, // storeAt
        ADD = 2, // add
        SUB = 3, // subtract
        MUL = 4, // multiply
        DIV = 5 // divide
                // TODO: add more
    };
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FillMemory();
        }

        public void FillMemory() // preenche a memoria com valores base, no futuro quero fazer preencher com valores aleatorios se pedido
        {
            for (int x = 0; x < Memory.GetSize() - 1; x++)
            {
                Data.Items.Add("0x" + x.ToString());
                Instructions.Items.Add("0x" + x.ToString());
            }
        }

        public void Execute()
        {
            Processor.hlt = false;
            short[] nothing = new short[2] { 0, 0 };
            Instruction hltins = new Instruction(-1, nothing); // cria uma instrucao de HLT como ultima instrucao, sempre
            Memory.instructions[Memory.GetSize() - 1] = hltins;
            while (Processor.hlt == false)
            {
                Processor.Process(); // vai processar enquanto n receber um -1
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_sum_Click(object sender, EventArgs e)
        {
            short opcode = (short)OPCODE.ADD;
            short[] addr = new short[2];
            addr[0] = short.Parse(addr1.Text);
            addr[1] = short.Parse(addr2.Text);
            Instruction instr = new Instruction(opcode, addr);
            Memory.instructions[Memory.FindNextAddress()] = instr; // adiciona a instrucao na memoria
            addr1.Clear();
            addr2.Clear();
        }

        private void btn_execute_Click(object sender, EventArgs e)
        {
            Execute();
        }
    }
}
