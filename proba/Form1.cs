namespace proba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            lblResult.Text = "MouseDown";
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            lblResult.Text = "Mouse Leave";
        }

        private void textBox1_MouseUp(object sender, MouseEventArgs e)
        {
            lblResult.Text = "Mouse Up";
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            lblResult.Text = "Mouse Enter";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            lblResult.Text = "Mouse Click";
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void lbl1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
