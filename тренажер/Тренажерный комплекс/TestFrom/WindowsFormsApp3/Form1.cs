using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Комплекс : Form
    {
        public Комплекс()
        {
            InitializeComponent();
            MaximizeBox = false;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Тренажерный комплекс";
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }         
             

        private void button1_Click_4(object sender, EventArgs e)
        {
            buttM.Visible= true;
        }
               

        private void buttM_Click(object sender, EventArgs e)
        {
            buttM.Visible= false;
        }

        private void tumb1_Click(object sender, EventArgs e)
        {
            tumb2.Visible= true;
        }

        private void tumb2_Click(object sender, EventArgs e)
        {
            tumb2.Visible = false;

        }

        private void Pacet1_Click(object sender, EventArgs e)
        {
            Pacet1.Visible= false;
        }

        private void Pacet2_Click(object sender, EventArgs e)
        {
            Pacet1.Visible= true;
        }

        private void cnopkS_Click(object sender, EventArgs e)
        {
            knopS.Visible= false; 
            if(knopS.Visible==false)
            {
                lamp3_1.Visible= false;
            }
        }

        private void knopSN_Click(object sender, EventArgs e)
        {
            knopS.Visible = true;
            if (knopS.Visible == true)
            {
                lampa2.Visible= false;
                lamp3_1.Visible = true;

                lamp3_1.Show();
            }
        }

        private void knopP_Click(object sender, EventArgs e)
        {
            knopP.Visible = false; 
            if (knopP.Visible==false)
            {
                lampa2.Visible= false;
                lampa.Visible= true;
            }
            timeST.Start();
            
        }

        private void knopPN_Click(object sender, EventArgs e)
        {
            knopP.Visible= true;
            if (knopP.Visible == true)
            {
                lampa.Visible = false;                                      
                lampa2.Visible = true;
                
            }
        }

        private void timeST_Tick(object sender, EventArgs e)
        {

        }

        private void lampa2_Click(object sender, EventArgs e)
        {

        }

        private void lampa2_Click_1(object sender, EventArgs e)
        {

        }

        private void lampa_Click(object sender, EventArgs e)
        {

        }
    }
}
