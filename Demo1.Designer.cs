namespace AudiProject
{
    partial class frmDemo1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDemo1));
            txtScore = new Label();
            lblMissShot = new Label();
            lblTotalShot = new Label();
            pcbCar = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            lblGameOver = new Label();
            btnExit = new Button();
            btnRestart = new Button();
            ((System.ComponentModel.ISupportInitialize)pcbCar).BeginInit();
            SuspendLayout();
            // 
            // txtScore
            // 
            txtScore.AutoSize = true;
            txtScore.BackColor = Color.White;
            txtScore.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtScore.Location = new Point(31, 34);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(161, 39);
            txtScore.TabIndex = 0;
            txtScore.Text = "Score = 0";
            // 
            // lblMissShot
            // 
            lblMissShot.AutoSize = true;
            lblMissShot.BackColor = Color.White;
            lblMissShot.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMissShot.Location = new Point(31, 91);
            lblMissShot.Name = "lblMissShot";
            lblMissShot.Size = new Size(263, 39);
            lblMissShot.TabIndex = 1;
            lblMissShot.Text = "Missed Shots = 0";
            // 
            // lblTotalShot
            // 
            lblTotalShot.AutoSize = true;
            lblTotalShot.BackColor = Color.White;
            lblTotalShot.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalShot.Location = new Point(31, 147);
            lblTotalShot.Name = "lblTotalShot";
            lblTotalShot.Size = new Size(232, 39);
            lblTotalShot.TabIndex = 2;
            lblTotalShot.Text = "Total Shots = 0";
            // 
            // pcbCar
            // 
            pcbCar.BackColor = Color.Transparent;
            pcbCar.Image = (Image)resources.GetObject("pcbCar.Image");
            pcbCar.Location = new Point(227, 818);
            pcbCar.Name = "pcbCar";
            pcbCar.Size = new Size(127, 92);
            pcbCar.SizeMode = PictureBoxSizeMode.Zoom;
            pcbCar.TabIndex = 3;
            pcbCar.TabStop = false;
            pcbCar.Click += pcbCar_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 800;
            timer1.Tick += timer1_Tick;
            // 
            // lblGameOver
            // 
            lblGameOver.AutoSize = true;
            lblGameOver.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGameOver.Location = new Point(375, 477);
            lblGameOver.Name = "lblGameOver";
            lblGameOver.Size = new Size(0, 38);
            lblGameOver.TabIndex = 4;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Century Gothic", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(738, 34);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(153, 68);
            btnExit.TabIndex = 5;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnRestart
            // 
            btnRestart.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRestart.Location = new Point(738, 129);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(153, 68);
            btnRestart.TabIndex = 6;
            btnRestart.Text = "RESTART";
            btnRestart.UseVisualStyleBackColor = true;
            btnRestart.Click += btnRestart_Click;
            // 
            // frmDemo1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(921, 1226);
            Controls.Add(btnRestart);
            Controls.Add(btnExit);
            Controls.Add(lblGameOver);
            Controls.Add(pcbCar);
            Controls.Add(lblTotalShot);
            Controls.Add(lblMissShot);
            Controls.Add(txtScore);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmDemo1";
            Text = "Demo1";
            MouseClick += Demo1_MouseClick;
            ((System.ComponentModel.ISupportInitialize)pcbCar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtScore;
        private Label lblMissShot;
        private Label lblTotalShot;
        private PictureBox pcbCar;
        private System.Windows.Forms.Timer timer1;
        private Label lblGameOver;
        private Button btnExit;
        private Button btnRestart;
    }
}