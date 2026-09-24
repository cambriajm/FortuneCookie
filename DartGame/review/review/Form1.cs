namespace review
{
    public partial class reviewform : Form
    {
        public reviewform()
        {
            InitializeComponent();
            
        }

        void DrawLine()
        {
            MessageBox.Show("hjarfgharjj");
        }

        //event handlers below yeehaw **************************************************************
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void drawPicBox_Click(object sender, EventArgs e)
        {
            DrawLine();
        }
    }
}
