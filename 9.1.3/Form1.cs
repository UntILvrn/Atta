using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;
using BL1;

namespace _9._1._3
{
    public partial class Massiv : Form
    {
        public Massiv()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridViewUtils.InitGridForArr(dataGridViewInput, 40, false, true, true, true, true);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void File_Open_Click(object sender, EventArgs e)
        {
            
                List<int> file = new List<int>();
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string path = openFileDialog1.FileName;
                    DataGridViewUtils.ArrayToGrid(dataGridViewInput, FileInput_9.ReturnNewMassiv(path));
                }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] returnedArray = DataGridViewUtils.GridToArray2<Int32>(dataGridViewInput);
            Task_9 example = new Task_9(returnedArray);

            DataGridViewUtils.ArrayToGrid(dataGridViewInput,example.DelitedStrAndCol());
        }

        private void dataGridViewOutput_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}