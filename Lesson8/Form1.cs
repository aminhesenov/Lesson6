namespace Lesson8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //DateTime date = dateTimePicker1.Value;
            //listBox1.Items.Add(date.ToString());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(dateTimePicker1.Value);
        }
        int num1, num2, result;
        private void button2_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(numericUpDown1.Value);
            num2 = Convert.ToInt32(numericUpDown2.Value);
            result = num1 + num2;
            MessageBox.Show(result.ToString(), "Result", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

        }

        //private void textBox1_Click(object sender, EventArgs e)
        //{
        //    if (textBox1.Text == "Username")
        //    {
        //        textBox1.Clear();
        //        textBox1.ForeColor = Color.Black;
        //    }
        //}
        Random r= new Random();
        Random g= new Random();
        Random b= new Random();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            panel1.BackColor=Color.FromArgb(r.Next(0,255), g.Next(0,255), b.Next(0,255));
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(r.Next(0, 255), g.Next(0, 255), b.Next(0, 255));
        }
    }
}
