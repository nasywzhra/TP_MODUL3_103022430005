namespace TP_MODUL3_103022430005
{
    public partial class Form1 : Form
    {
        int total = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl_output_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbl_output.Text += "1" ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbl_output.Text += "2";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            lbl_output.Text += "3";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            lbl_output.Text += "4";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            lbl_output.Text += "5";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            lbl_output.Text += "6";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            lbl_output.Text += "7";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            lbl_output.Text += "8";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            lbl_output.Text += "9";

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (lbl_output.Text != "")
            {
                total += int.Parse(lbl_output.Text);
                lbl_output.Text = "";
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            lbl_output.Text += "0";

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (lbl_output.Text != "")
            {
                total += int.Parse(lbl_output.Text);
                lbl_output.Text = total.ToString();
                total = 0;
            }

        }
    }
}
