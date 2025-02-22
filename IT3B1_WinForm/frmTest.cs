namespace IT3B1_WinForm
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Form1 is opening");
            txtUser.Text = "Cambodia";
            txtUser.ForeColor = Color.Green;
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello " + txtUser.Text,
                "Welcome",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
