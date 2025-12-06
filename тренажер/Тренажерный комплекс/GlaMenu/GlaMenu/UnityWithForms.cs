using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace GlaMenu
{
    public partial class UnityWithForms : Form
    {
        public Process Process;
        public UnityWithForms()
        {
            InitializeComponent();
        }

        private void WindowFormUnityRender_Click(object sender, EventArgs e)
        {

            var path = Path.Combine(Directory.GetCurrentDirectory(), @"\тренажер\Exe\Unity\VTKcompleks.exe");
            Process.Start(path);
        }
        public static void WinformsandUnityDevelop()
        {
            
        }

        

        
        public void Close()
        {
            Process?.Kill();
        }

        private void Exit_VTK_COM_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
            SoundPlayer simpleSound = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\Clipck.wav");
            simpleSound.Play();
        }

        private void авторстоToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TestFromFinForm_MouseClick(object sender, MouseEventArgs e)
        {
            
            if (Time_stop.Enabled == false)
            {
                Time_stop.Enabled = false;
                if (Time_stop.Enabled == false)
                {
                    
                    
                    TestGameForm testGameForm = new TestGameForm();
                    this.Hide();
                    testGameForm.Show();
                    SoundPlayer Test_sounds = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\ZVGlavmenu.wav");
                    Test_sounds.Play();

                }
            }
        }
        Point post;
        private void UnityWithForms_MouseDown(object sender, MouseEventArgs e)
        {
            post = new Point(e.X, e.Y);
        }

        private void UnityWithForms_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - post.X;
                this.Top += e.Y - post.Y;
            }
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

        private void UnityWithForms_Load(object sender, EventArgs e)
        {

        }

       
    }
}
