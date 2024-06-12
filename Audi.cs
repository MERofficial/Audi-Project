namespace AudiProject
{
    public partial class Audi : Form
    {
        public Audi()
        {
            InitializeComponent();
            this.Text = "Audi Project - Date: " + DateTime.Today.ToShortDateString();

        }

        public void BindFormIntoMainForm(Form Main)
        {
            Main.TopLevel = false;
            Main.WindowState = FormWindowState.Maximized;
            Main.AutoScroll = true;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(Main);
            pnlMain.Refresh();
            Main.Show();
        }

        private void btnModels_Click(object sender, EventArgs e)
        {
            frmModels ModelForm = new frmModels();
            BindFormIntoMainForm(ModelForm);
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            frmStock StockForm = new frmStock();
            BindFormIntoMainForm(StockForm);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           frmSearch SearchForm = new frmSearch();
           BindFormIntoMainForm(SearchForm);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            timer1.Stop();
            ptbGif1.Dispose();
            ptbGif2.Dispose();
            txtReveal.Dispose();

        }

        private void btnDemo_Click(object sender, EventArgs e)
        {
            frmDemo DemoForm = new frmDemo();
            BindFormIntoMainForm(DemoForm);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmDemo1 Demo1Form = new frmDemo1();
            BindFormIntoMainForm(Demo1Form);
        }
    }
}
