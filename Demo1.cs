using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudiProject
{
    public partial class frmDemo1 : Form
    {
        public frmDemo1()
        {
            InitializeComponent();
        }

        Random r = new Random();
        int score = 0;
        int total_shots = 0;
        int miss_shot = 0;

        void shot_voice()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\peter\OneDrive\Documents\College\Forms\AudiProject\bin\Debug\net8.0-windows\Gunshot.wav");
            player.Play();
        }
        void fn_shot()
        {
            score++;
            txtScore.Text = "Score = " + score;
            total_shots++;
            lblTotalShot.Text = "Total Shots = " + total_shots;

            shot_voice();
        }

        void fn_miss_shot()
        {
            miss_shot++;
            lblMissShot.Text = "Miss Shots = " + miss_shot;
            total_shots++;
            lblTotalShot.Text = "Total Shots = " + total_shots;

            shot_voice();
        }

        void reset()
        {
            score = 0;
            miss_shot = 0;
            total_shots = 0;
            lblMissShot.Text = "Miss Shots = " + miss_shot;
            lblTotalShot.Text = "Total Shots = " + total_shots;
            txtScore.Text = "Score =" + score;
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            int x, y;
            x = r.Next(000, 840);
            y = r.Next(150, 1100);
            pcbCar.Location = new Point(x, y);

            if (miss_shot >= 20)
            {
                timer1.Stop();
                lblGameOver.Text = $"Game Over! \n Total Score {score}";
                reset();
            }
        }

        private void pcbCar_Click(object sender, EventArgs e)
        {
            fn_shot();
        }

        private void Demo1_MouseClick(object sender, MouseEventArgs e)
        {
            fn_miss_shot();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            reset();
            lblGameOver.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
