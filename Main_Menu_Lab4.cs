namespace Lab4
{
    public partial class Main_Menu_Lab4 : Form
    {
        public Main_Menu_Lab4()
        {
            InitializeComponent();
        }

        

        private void bai1BT_Click(object sender, EventArgs e)
        {
            Bai1 bai1 = new Bai1();
            bai1.Show();
        }

        private void bai2BT_Click(object sender, EventArgs e)
        {

        }

        private void bai3BT_Click(object sender, EventArgs e)
        {
            Bai3 bai3 = new Bai3();
            bai3.Show();
        }

        private void bai5BT_Click(object sender, EventArgs e)
        {
            Bai5 bai5 = new Bai5();
            bai5.Show();
        }

        private void bai6BT_Click(object sender, EventArgs e)
        {
            Bai6 bai6 = new Bai6();
            bai6.Show();
        }

        private void bai4BT_Click(object sender, EventArgs e)
        {
            Bai4 bai4 = new Bai4();
            bai4.Show();
        }
    }
}