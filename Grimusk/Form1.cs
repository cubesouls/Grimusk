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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FillMemory();
        }

        public void FillMemory() // preenche a memoria com valores base, no futuro quero fazer preencher com valores aleatorios se pedido
        {
            for (int x = 0; x < Memory.GetSize(); x++)
            {
                Data.Items.Add("0x" + x.ToString());
                Instructions.Items.Add("0x" + x.ToString());
            }
        }

        public void TurnOnComputer()
        {
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
