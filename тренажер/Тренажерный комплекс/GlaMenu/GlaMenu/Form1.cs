
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;


namespace GlaMenu
{
    public partial class Menu : Form
    {
        UnityWithForms UnityWithForms = new UnityWithForms();
        
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            MaximizeBox= false;
            Trase.Image = Image.FromFile(@"\тренажер\Тренажерный комплекс\GlaMenu\GlaMenu\Resources\radar.gif");
            Trase.SizeMode = PictureBoxSizeMode.StretchImage;

        }               
          
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();            
            SoundPlayer EX_sounds = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\ZvikExit.wav");
            EX_sounds.Play();
            UnityWithForms?.Close();
        }
        

        private void Test1_MouseUp(object sender, MouseEventArgs e)
        {
            

            Trase.Visible = true;
            Trase.Enabled = true;

            if (Trase.Enabled == true)
            {

                int Q = 0; Console.WriteLine(Q);

                


            }
        }

        private void Probn1_MouseUp(object sender, MouseEventArgs e)
        {
            
            Trase.Visible = true;
            Trase.Enabled = true;

            //if (Trase.Enabled == true)
            //{
            //    int M = 0;
            //    Console.WriteLine(M);
            //}
        }
        System.Timers.Timer MainTimer;
        
        private void Boiv1_MouseUp(object sender, MouseEventArgs e)
        {
            MainTimer = new System.Timers.Timer();
            MainTimer.Interval = 100;
            MainTimer.Start();
           
            //Trase.Visible = true;
            //Trase.Enabled = true;

            //if (Trase.Enabled == true)
            //{
            //    int W = 0;
            //    Console.WriteLine(W);
            //}
        }
        int Ti = 0;
        private void TK_stop_Tick(object sender, EventArgs e)
        {
            
            Ti = Ti + 1;
            if(Ti == 3) 
            {
                TK_stop.Enabled= false;
                if(TK_stop.Enabled==false)
                {
                    Trase.Enabled = false;
                }
            }

            
        }

         

        
        




        private void Trase_Click(object sender, EventArgs e)
        {

        }

        

        

        private void Probn1_MouseClick(object sender, MouseEventArgs e)
        {
            

            Trase.Visible = true;
            Trase.Enabled = true;
            if (TK_stop.Enabled == false)
            {
                Trase.Enabled = false;
                if (Trase.Enabled == false)
                {

                    UnityWithFormRegimRabot unityWithFormRegimRabot = new UnityWithFormRegimRabot();
                    this.Hide();
                    unityWithFormRegimRabot.Show();
                    SoundPlayer Test_sounds = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\ZVGlavmenu.wav");
                    Test_sounds.Play();

                }
            }
        }
        Point left;

        private void Menu_MouseDown(object sender, MouseEventArgs e)
        {
            left = new Point(e.X, e.Y);
        }
        private void Menu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - left.X;
                this.Top += e.Y - left.Y;
            }
        }

        
        

        private void Test1_MouseClick(object sender, MouseEventArgs e)
        {
            Trase.Visible = true;
            Trase.Enabled = true;
            if (TK_stop.Enabled == false)
            {
                Trase.Enabled = false;
                if (Trase.Enabled == false)
                {

                    UnityWithForms unityWithForms = new UnityWithForms();
                    this.Hide();
                    unityWithForms.Show();
                    SoundPlayer Test_sounds = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\ZVGlavmenu.wav");
                    Test_sounds.Play();

                }
            }
        }

        
    }
}
