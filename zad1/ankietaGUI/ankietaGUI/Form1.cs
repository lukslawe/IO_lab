using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;

namespace ankietaGUI
{
   
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            
        }
        private void loadBallots()
        {
            //string[] files = System.IO.Directory.GetFiles("./","*.txt");
            List<string> list = this.lbAnkiety.Items.OfType<string>().ToList();

            string[] files = Directory.GetFiles(@"./", "*.txt")
            .Select(Path.GetFileNameWithoutExtension)
            .Select(p => p.Substring(0)).ToArray(); //per comment


            IEnumerable<string> result = files.Except(list);

            foreach (string file in result)
            {
                lbAnkiety.Items.Add(Path.GetFileNameWithoutExtension(file));
            }
            
        }
        private void Form1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("I am THE BUTTON");
            bool isSc1Visible = splitContainer1.Panel1Collapsed;
            if (isSc1Visible){
                tSB1.Image = Properties.Resources.unwrappedArrow;
                splitContainer1.Panel1Collapsed = false;
            }
            else{
                tSB1.Image = Properties.Resources.wrappedArrow;
                splitContainer1.Panel1Collapsed = true;
            }
        }

        private void zkonczToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
     
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void lbAnkiety_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void importData()
        {

        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            loadBallots();
        }

        private void tb3_TextChanged(object sender, EventArgs e) { 
            
        }

        private void wyświetlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Okno pomocy programu");
        }

        private void informacjeOProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Okno z informacjami o programie");
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Przycisk do eksport");
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            bool isEmpty = false;
            if (this.tb1.Text == "" || this.tb2.Text == "" || this.tb3.Text == "" || this.tb4.Text == "" || this.tb5.Text == "" || this.tb6.Text == "" || this.tb7.Text == "")
            {
                isEmpty = true;
            }
            if (this.cb1.Text == "" || this.cb2.Text == "" || this.cb3.Text == "" || this.cb4.Text == "")
            {
                isEmpty = true;
            }
            if (isEmpty)
            {
                MessageBox.Show("Wypelnij wszsytkie pola w formularzu");
            }
            else
            {
                MessageBox.Show("Ankieta zostala wyslana");
            }
        }
    }
    public class daneAnkiet {
        
    }
}
