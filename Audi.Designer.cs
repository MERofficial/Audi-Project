namespace AudiProject
{
    partial class Audi
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Audi));
            pnlHeader = new Panel();
            btnDemo = new Button();
            btnStock = new Button();
            btnSearch = new Button();
            btnModels = new Button();
            pictureBox1 = new PictureBox();
            pnlFooter = new Panel();
            ptbFoot = new PictureBox();
            pnlMain = new Panel();
            txtReveal = new TextBox();
            ptbGif2 = new PictureBox();
            ptbGif1 = new PictureBox();
            lblWelcome = new Label();
            lblHello = new Label();
            ptbGif3 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbFoot).BeginInit();
            pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbGif2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbGif1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbGif3).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(btnDemo);
            pnlHeader.Controls.Add(btnStock);
            pnlHeader.Controls.Add(btnSearch);
            pnlHeader.Controls.Add(btnModels);
            pnlHeader.Controls.Add(pictureBox1);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(948, 89);
            pnlHeader.TabIndex = 0;
            // 
            // btnDemo
            // 
            btnDemo.FlatAppearance.BorderColor = Color.White;
            btnDemo.FlatStyle = FlatStyle.Flat;
            btnDemo.Font = new Font("Century Gothic", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDemo.Location = new Point(776, 0);
            btnDemo.Name = "btnDemo";
            btnDemo.Size = new Size(185, 89);
            btnDemo.TabIndex = 5;
            btnDemo.Text = "Demo";
            btnDemo.UseVisualStyleBackColor = true;
            btnDemo.Click += btnDemo_Click;
            // 
            // btnStock
            // 
            btnStock.FlatAppearance.BorderColor = Color.White;
            btnStock.FlatStyle = FlatStyle.Flat;
            btnStock.Font = new Font("Century Gothic", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStock.Location = new Point(420, 0);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(185, 89);
            btnStock.TabIndex = 4;
            btnStock.Text = "Stock";
            btnStock.UseVisualStyleBackColor = true;
            btnStock.Click += btnStock_Click;
            // 
            // btnSearch
            // 
            btnSearch.FlatAppearance.BorderColor = Color.White;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Century Gothic", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(591, 0);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(185, 89);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnModels
            // 
            btnModels.FlatAppearance.BorderColor = Color.White;
            btnModels.FlatStyle = FlatStyle.Flat;
            btnModels.Font = new Font("Century Gothic", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnModels.Location = new Point(239, 0);
            btnModels.Name = "btnModels";
            btnModels.Size = new Size(185, 89);
            btnModels.TabIndex = 2;
            btnModels.Text = "Models";
            btnModels.UseVisualStyleBackColor = true;
            btnModels.Click += btnModels_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 4);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(238, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pnlFooter
            // 
            pnlFooter.Controls.Add(ptbFoot);
            pnlFooter.Location = new Point(1, 1382);
            pnlFooter.Margin = new Padding(4);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(947, 89);
            pnlFooter.TabIndex = 1;
            // 
            // ptbFoot
            // 
            ptbFoot.Image = (Image)resources.GetObject("ptbFoot.Image");
            ptbFoot.Location = new Point(711, 3);
            ptbFoot.Margin = new Padding(4);
            ptbFoot.Name = "ptbFoot";
            ptbFoot.Size = new Size(226, 86);
            ptbFoot.SizeMode = PictureBoxSizeMode.Zoom;
            ptbFoot.TabIndex = 0;
            ptbFoot.TabStop = false;
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.Black;
            pnlMain.Controls.Add(txtReveal);
            pnlMain.Controls.Add(ptbGif2);
            pnlMain.Controls.Add(ptbGif1);
            pnlMain.Controls.Add(lblWelcome);
            pnlMain.Controls.Add(lblHello);
            pnlMain.Controls.Add(ptbGif3);
            pnlMain.Location = new Point(1, 90);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(947, 1297);
            pnlMain.TabIndex = 2;
            // 
            // txtReveal
            // 
            txtReveal.BackColor = Color.Black;
            txtReveal.BorderStyle = BorderStyle.None;
            txtReveal.Location = new Point(57, 575);
            txtReveal.Multiline = true;
            txtReveal.Name = "txtReveal";
            txtReveal.Size = new Size(840, 157);
            txtReveal.TabIndex = 5;
            // 
            // ptbGif2
            // 
            ptbGif2.Image = (Image)resources.GetObject("ptbGif2.Image");
            ptbGif2.Location = new Point(0, 776);
            ptbGif2.Name = "ptbGif2";
            ptbGif2.Size = new Size(948, 516);
            ptbGif2.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbGif2.TabIndex = 1;
            ptbGif2.TabStop = false;
            // 
            // ptbGif1
            // 
            ptbGif1.Image = (Image)resources.GetObject("ptbGif1.Image");
            ptbGif1.Location = new Point(-1, -10);
            ptbGif1.Name = "ptbGif1";
            ptbGif1.Size = new Size(949, 526);
            ptbGif1.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbGif1.TabIndex = 0;
            ptbGif1.TabStop = false;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Century Gothic", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(169, 96);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(625, 126);
            lblWelcome.TabIndex = 2;
            lblWelcome.Text = "Welcome to the Audi \r\nCar selector database!";
            lblWelcome.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblHello
            // 
            lblHello.AutoSize = true;
            lblHello.ForeColor = Color.White;
            lblHello.Location = new Point(159, 276);
            lblHello.Name = "lblHello";
            lblHello.Size = new Size(649, 117);
            lblHello.TabIndex = 3;
            lblHello.Text = "Please use the above buttons to search, \r\nbrowse, amend and review the\r\n Audi dealership stock lists.";
            lblHello.TextAlign = ContentAlignment.TopCenter;
            // 
            // ptbGif3
            // 
            ptbGif3.ErrorImage = (Image)resources.GetObject("ptbGif3.ErrorImage");
            ptbGif3.Image = (Image)resources.GetObject("ptbGif3.Image");
            ptbGif3.Location = new Point(140, 396);
            ptbGif3.Name = "ptbGif3";
            ptbGif3.Size = new Size(635, 481);
            ptbGif3.TabIndex = 4;
            ptbGif3.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 5000;
            timer1.Tick += timer1_Tick;
            // 
            // Audi
            // 
            AutoScaleDimensions = new SizeF(19F, 39F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(951, 1467);
            Controls.Add(pnlMain);
            Controls.Add(pnlFooter);
            Controls.Add(pnlHeader);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Audi";
            Text = "Audi Project";
            pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptbFoot).EndInit();
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbGif2).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbGif1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbGif3).EndInit();
            ResumeLayout(false);
            
        }


        #endregion

        private Panel pnlHeader;
        private PictureBox pictureBox1;
        private Panel pnlFooter;
        private PictureBox ptbFoot;
        private Button btnModels;
        private Panel pnlMain;
        private Button btnStock;
        private Button btnSearch;
        private Button btnDemo;
        private PictureBox ptbGif1;
        private Label lblWelcome;
        private PictureBox ptbGif2;
        private System.Windows.Forms.Timer timer1;
        private Label lblHello;
        private PictureBox ptbGif3;
        private TextBox txtReveal;
    }
}
