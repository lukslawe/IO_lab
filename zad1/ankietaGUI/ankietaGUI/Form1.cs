using System;
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
            loadBallots();
        }
        private void loadBallots()
        {
            for(int i=0; i< 10; i++)
            {
                lbAnkiety.Items.Add("Ankieta " + i.ToString());
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

            Utilities.ResetText();
            int index = lbAnkiety.SelectedIndex;
            if(index != -1)
            {

            }
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

        }

        private void tb3_TextChanged(object sender, EventArgs e)
        {

        }
    }
    public class daneAnkiet {
        
    }
}
