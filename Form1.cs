namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1 = Int32.Parse(no1.Text);
            int n2 = Int32.Parse(no2.Text);
            int r = 0;

            if(add.Checked) 
                r = n1 + n2;  
            if(sub.Checked) 
                r = n1 - n2;
            if(mult.Checked)
                r = n1 * n2;

            result.Visible = true;
            result.Text = r.ToString();

            MessageBox.Show(r.ToString());
        }
    }
}
