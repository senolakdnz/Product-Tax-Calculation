namespace urun_fiyatlandırma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double price ,price1, price2;
            price = Convert.ToDouble(textBox1.Text);
            price1 = (price * 108) / 100;
            price2 = (price * 118) / 100;
            listBox1.Items.Add("Normal Price : " + price + " " + "$");
            listBox1.Items.Add("%8 Taxed Price : " + price1 + " " + "$");
            listBox1.Items.Add("%18 Taxed Price : " + price2 + " " + "$");
        }
    }
}