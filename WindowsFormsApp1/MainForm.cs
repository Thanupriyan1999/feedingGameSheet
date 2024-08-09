using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {

        }





        private void labelExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Machanic_button2_Click(object sender, EventArgs e)
        {
            feedingGameSheet1.Visible = false;
            mechanic1.Visible = true;
            workStudy1.Visible = false;
            leader1.Visible = false;
            technical1.Visible = false;
            zonelHead1.Visible = false;
            productionAssistent1.Visible = false;
            audit1.Visible = false; 
        }

        private void WorkStudy_button3_Click(object sender, EventArgs e)
        {
            feedingGameSheet1.Visible = false;
            mechanic1.Visible = false;
            workStudy1.Visible = true;
            leader1.Visible = false;
            technical1.Visible = false;
            zonelHead1.Visible = false;
            productionAssistent1.Visible = false;
            audit1.Visible = false;
        }

        private void Audit_button9_Click(object sender, EventArgs e)
        {
            feedingGameSheet1.Visible = false;
            mechanic1.Visible = false;
            workStudy1.Visible = false;
            leader1.Visible = false;
            technical1.Visible = false;
            zonelHead1.Visible = false;
            productionAssistent1.Visible = false;
            audit1.Visible = true;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FeedingSheet_button1_Click(object sender, EventArgs e)
        {
          feedingGameSheet1.Visible = true;
            mechanic1.Visible = false;
            workStudy1.Visible = false;
            leader1.Visible = false;
            technical1.Visible = false;
            zonelHead1.Visible = false;
            productionAssistent1.Visible = false;
            audit1.Visible = false;


        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void Leader_button4_Click(object sender, EventArgs e)
        {
            feedingGameSheet1.Visible = false;
            mechanic1.Visible = false;
            workStudy1.Visible = false;
            leader1.Visible = true;
            technical1.Visible = false;
            zonelHead1.Visible = false;
            productionAssistent1.Visible = false;
            audit1.Visible = false;
        }

        private void Technical_button5_Click(object sender, EventArgs e)
        {
            feedingGameSheet1.Visible = false;
            mechanic1.Visible = false;
            workStudy1.Visible = false;
            leader1.Visible = false;
            technical1.Visible = true;
            zonelHead1.Visible = false;
            productionAssistent1.Visible = false;
            audit1.Visible = false;
        }

        private void ZonelHead_button6_Click(object sender, EventArgs e)
        {
            feedingGameSheet1.Visible = false;
            mechanic1.Visible = false;
            workStudy1.Visible = false;
            leader1.Visible = false;
            technical1.Visible = false;
            zonelHead1.Visible = true;
            productionAssistent1.Visible = false;
            audit1.Visible = false;
        }

        private void Production_button8_Click(object sender, EventArgs e)
        {
            feedingGameSheet1.Visible = false;
            mechanic1.Visible = false;
            workStudy1.Visible = false;
            leader1.Visible = false;
            technical1.Visible = false;
            zonelHead1.Visible = false;
            productionAssistent1.Visible = true;
            audit1.Visible = false;
        }
    }
}