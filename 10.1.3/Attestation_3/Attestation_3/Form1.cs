using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Utils;
using Library;

namespace Attestation_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                DataGridViewUtils.ArrayToGrid(dataGridViewInput, InputSaveFile.ReturnNewMassiv(path));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridViewUtils.InitGridForArr(dataGridViewInput, 40, false, true, true, true, true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> List = new List<int>();
            List<Line> lineList = new List<Line>();
            int[,] Mass = DataGridViewUtils.GridToArray2<Int32>(dataGridViewInput);
            lineList = InputABC.ReturnList(Mass);
            Calculator calc = new Calculator(lineList);

            List<Line> List1 = calc.CalcMaxLine(0);
            List<Line> List2 = calc.CalcMaxLine(1);
            Line el = calc.ReturnMaxLine(List1,List2);


            if (el != null)
            {
                label1.Text = "Самая верхняя линия: "+  el.A
                     + "x + " + el.B + "y + "+ el.C;
            }
            else
                label1.Text = "Не удалось найти параллельную линию";
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<int> file = new List<int>();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog1.FileName;
                List<Line> linelList = new List<Line>();
                int[,] Mass = DataGridViewUtils.GridToArray2<Int32>(dataGridViewInput);
                linelList = InputABC.ReturnList(Mass);
                InputSaveFile.SaveFile(path, linelList);
            }
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewInput_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}