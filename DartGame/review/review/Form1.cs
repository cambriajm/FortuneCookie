namespace review
{
    public partial class reviewform : Form
    {
        public reviewform()
        {
            InitializeComponent();

        }

        void Spiral()
        {

            double x = 100 * Math.Cos(45 * (Math.PI / 180));
            double y = 100 * Math.Sin(45 * (Math.PI / 180));

            for(int i = 0; i < 360; i++)
            {
                x = 100 * Math.Cos(45 * (Math.PI / 180));
                y = 100 * Math.Sin(45 * (Math.PI / 180));
            }
        }

        int GetNumberFrom(int max, int min = 0)
        {
            Random randy = new Random();
            return randy.Next(min, max + 1);
        }

        void DrawLine(int x, int y)
        {
            Graphics g = drawPicBox.CreateGraphics();
            //MessageBox.Show("hjarfgharjj");
            Pen thePen = new Pen(Color.Green);
            g.DrawLine(thePen, 0, 0, x, y);
            thePen.Dispose();
            g.Dispose();
        }

        void DrawDart(int x, int y)
        {
            Graphics g = drawPicBox.CreateGraphics();
            //MessageBox.Show("hjarfgharjj");
            Pen thePen = new Pen(Color.FromArgb(255, GetNumberFrom(255), GetNumberFrom(255), GetNumberFrom(255)),GetNumberFrom(255));
            int size = GetNumberFrom(255);

            g.DrawEllipse(thePen, x - size / 2, y - size / 2, size, size);
            g.DrawLine(thePen, x - size/4, y, x + size/4, y);
            g.DrawLine(thePen, x, y - size/4, x, y + size/4);

            thePen.Dispose();
            g.Dispose();
        }

        //event handlers below yeehaw **************************************************************
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void drawPicBox_Click(object sender, EventArgs e)
        {
            int x = GetNumberFrom(drawPicBox.Width);
            int y = GetNumberFrom(drawPicBox.Height);
          //  DrawLine(x, y);
            DrawDart(x, y);
            Spiral();
        }
    }
}
