namespace IntroductionCsharp.WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.BackColor == System.Drawing.Color.Aqua)
            {
                this.BackColor = System.Drawing.Color.Chartreuse;
            }
            else
            {
                this.BackColor = System.Drawing.Color.Aqua;
            }
        }

        private void buttonOpenWindowList_Click(object sender, EventArgs e)
        {
            FormListChips form = new FormListChips();
            this.Visible = false;
            form.ShowDialog();
            this.Visible = true;

        }
    }
}
