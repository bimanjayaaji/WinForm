namespace WinFormsStartup
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void sayHelloButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show($"Hello {firstNameText.Text} {lastNameText.Text}");
            Form1 frm = new(firstNameText.Text);
            frm.Show();
        }
    }
}