using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlaMenu
{
    public partial class UnityWithFormRegimRabot : Form
    {
        public UnityWithFormRegimRabot()
        {
            InitializeComponent();
        }

        private void Probn1PanelRLS_MouseClick(object sender, MouseEventArgs e)
        {
          
            if (Time_stop_Reg.Enabled == false)
            {
                Time_stop_Reg.Enabled = false;
                if (Time_stop_Reg.Enabled == false)
                {

                    ProbGameFrom probGameFrom = new ProbGameFrom();
                    this.Hide();
                    probGameFrom.Show();
                    SoundPlayer Test_sounds = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\ZVGlavmenu.wav");
                    Test_sounds.Play();

                }
            }
        }

        private void Exit_VTK_COM_Reg_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
            SoundPlayer simpleSound = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\Clipck.wav");
            simpleSound.Play();
        }

        

        private void WindowFormUnityRenderRegim_Click(object sender, EventArgs e)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), @"\тренажер\Exe\Unity\VTKcompleks.exe");
            Process.Start(path);
        }
        Point post;

        private void UnityWithFormRegimRabot_MouseDown(object sender, MouseEventArgs e)
        {
            post = new Point(e.X, e.Y);
        }

        private void UnityWithFormRegimRabot_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - post.X;
                this.Top += e.Y - post.Y;
            }
        }

        private void режимАдминистрированияToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cmdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            try
            {
                // Start a new process for cmd.exe
                Process.Start("cmd.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening Command Prompt: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                // Start a new process for cmd.exe
                Process.Start("cmd.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening Command Prompt: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UnityWithFormRegimRabot_Load(object sender, EventArgs e)
        {

        }

        private void скачатьИнструкциюToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void инструкцияПоПользованиюПрограммойToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
    
}
