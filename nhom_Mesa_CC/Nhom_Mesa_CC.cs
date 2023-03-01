namespace nhom_Mesa_CC
{
    public partial class Nhom_Mesa_CC : Form
    {
        public Nhom_Mesa_CC()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.ToString().Equals("admin") && txtpassword.Text.ToString().Equals("admin"))
            {
                //MessageBox.Show("Đăng nhập thành công");
                //this.Close();
                Success f = new Success();
                f.Show();
            }else
            {
                MessageBox.Show("Đăng nhập k thành công");
            }    
        }
    }
}