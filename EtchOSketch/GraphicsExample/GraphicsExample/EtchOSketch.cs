namespace GraphicsExample
//Cambria Morgan
//RCET 2265 
//Spring 2026
//https://github.com/cambriajm/Etch--O-Sketch.git
{
    public partial class GraphicsForm : Form
    {
        public GraphicsForm()
        {
            SplashForm();
            InitializeComponent();
            DisplayPictureBox.MouseMove += DisplayPictureBox_MouseStuff;
            DisplayPictureBox.MouseDown += DisplayPictureBox_MouseStuff;
            ClearMenu.Click += ClearButton_Click;
            PenSizeComboBox.SelectedIndexChanged += PenSizeComboBox_SelectedIndexChanged;
            colorToolStripMenuItem.Click += ColorButton_Click;
            ExitMenuItem.Click += ExitButton_Click;
            DrawItem.Click += DrawButton_Click;
            this.PenColor = PenColorDialogue.Color;
            //populate pen size combobox
            PenSizeComboBox.Items.Add(1);
            PenSizeComboBox.Items.Add(2);
            PenSizeComboBox.Items.Add(5);
            PenSizeComboBox.Items.Add(10);
            PenSizeComboBox.Items.Add(15);
            PenSizeComboBox.Items.Add(20);
            PenSizeComboBox.SelectedIndex = 0;
        }

        private Color PenColor = Color.Black;
        private Color backGround = Color.White;
        private int penSize = 3;
        private int oldX, oldY;
         
        void UpdatePenColor()
        {
            PenColorDialogue.ShowDialog();
            this.PenColor = PenColorDialogue.Color;
            {
                PenColor = PenColorDialogue.Color;
                    }
        }
        void UpdateDisplayBoxColor()
        {
            PenColorDialogue.ShowDialog();
            this.BackColor = PenColorDialogue.Color;
            {
                DisplayPictureBox.BackColor = this.BackColor;
                this.BackColor = Color.White;
            }
        }
        void UpdatePenSize()
        {
            this.penSize = int.Parse(PenSizeComboBox.SelectedItem.ToString());
        }


        //drawing button stuff--------------------------------------------------------------
        private void DrawButton_Click(object sender, EventArgs e)
        {
            DrawSinWave();
            DrawCosWave();
            DrawTanWave();
            DrawGrid();
        }
        void DrawLineSegment(int newX, int newY)
        {
            //create a Graphics object named g that draws on the picture box
            Graphics g = DisplayPictureBox.CreateGraphics();
            // create a pen to draw with
            Pen thePen = new Pen(this.PenColor);
            thePen.Width = this.penSize;
             
            //draw the line here
            g.DrawLine(thePen, oldX, oldY, newX, newY);
             
            //free up resources
            g.Dispose();
            thePen.Dispose();
        }
        void DrawGrid()
        {

            int xDiv = DisplayPictureBox.Width / 10;
            int yDiv = DisplayPictureBox.Height / 10;

            this.oldX = 0;
            this.oldY = 0;
            for (int x = 0; x < DisplayPictureBox.Width; x += xDiv)
            {
                oldX = x;
                DrawLineSegment(x, DisplayPictureBox.Height);
            }
            this.oldX = 0;
            this.oldY = 0;
            for (int y = 0; y < DisplayPictureBox.Height; y += yDiv)
            {
                oldY = y;
                DrawLineSegment(DisplayPictureBox.Width, y);
            }

        }
        private void DrawSinWave()
        {

            //create a Graphics object named g that draws on the picture box
            Graphics g = DisplayPictureBox.CreateGraphics();
            // create a pen to draw with
            Pen thePen = new Pen(this.PenColor);
            thePen.Color = Color.LightGreen;
            int lastX = 0, lastY = 0, currentY = 0;
            float scaleX = DisplayPictureBox.Width / 360f;
            float scaleY = (DisplayPictureBox.Height / 200f) * -1;
            g.TranslateTransform(0, DisplayPictureBox.Height / 2);
            g.ScaleTransform(scaleX, scaleY);
            for (int currentX = 0; currentX < 360; currentX++)
            {
                currentY = (int)(Math.Round(100 * Math.Sin((Math.PI / 180) * currentX)));
                g.DrawLine(thePen, lastX, lastY, currentX, currentY);
                lastX = currentX;
                lastY = currentY;
            }
            //free up resources
            g.Dispose();
            thePen.Dispose();
        }//this is the sine wave
        private void DrawCosWave()//this is the cosine wave 
        {

            //create a Graphics object named g that draws on the picture box
            Graphics g = DisplayPictureBox.CreateGraphics();
            // create a pen to draw with
            Pen thePen = new Pen(this.PenColor);
            thePen.Color = Color.Indigo;
            int lastX = 0, lastY = 0, currentY = 0;
            float scaleX = DisplayPictureBox.Width / 360f;
            float scaleY = (DisplayPictureBox.Height / 200f) * -1;
            g.TranslateTransform(0, DisplayPictureBox.Height / 2);
            g.ScaleTransform(scaleX, scaleY);
            for (int currentX = 0; currentX < 360; currentX++)
            {
                currentY = (int)(Math.Round(100 * Math.Cos((Math.PI / 180) * currentX)));
                g.DrawLine(thePen, lastX, lastY, currentX, currentY);
                lastX = currentX;
                lastY = currentY;
            }
            //free up resources
            g.Dispose();
            thePen.Dispose();
        }
        private void DrawTanWave()//this is the tangent wave
        {
            //create a Graphics object named g that draws on the picture box
            Graphics g = DisplayPictureBox.CreateGraphics();
            // create a pen to draw with
            Pen thePen = new Pen(this.PenColor);
            thePen.Color = Color.DarkViolet;
            int lastX = 0, lastY = 0, currentY = 0;
            float scaleX = DisplayPictureBox.Width / 360f;
            float scaleY = (DisplayPictureBox.Height / 200f) * -1;
            g.TranslateTransform(0, DisplayPictureBox.Height / 2);
            g.ScaleTransform(scaleX, scaleY);
            for (int currentX = 0; currentX < 360; currentX++)
            {
                currentY = (int)(Math.Round(100 * Math.Tan((Math.PI / 180) * currentX)));
                if (Math.Abs(currentY) < DisplayPictureBox.Height / 2)
                {
                    g.DrawLine(thePen, lastX, lastY, currentX, currentY);
                }
                lastX = currentX;
                lastY = currentY;
            }
            //free up resources
            g.Dispose();
            thePen.Dispose();
        }


        //events-----------------------------------------------------------------------------------------------------------------------------------
        private void DisplayPictureBox_MouseStuff(object? sender, MouseEventArgs e)//tracks the mouse movement, formatted same as in class
        {
            this.Text = $"({e.X},{e.Y}) {e.Button}";
            switch (e.Button)
            {
                case MouseButtons.Left:
                    DrawLineSegment(e.X, e.Y);
                    break;
                case MouseButtons.Right:
                    // Save for context menu
                    break;
                case MouseButtons.Middle:
                    UpdatePenColor();
                    break;
                default:
                    //MessageBox.Show($"{e.Button}");
                    break;
            }
            //update last position on every move
            this.oldX = e.X;
            this.oldY = e.Y;
        }
        private void shake()//shaky shaky
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer("..\\..\\..\\lego-yoda-death-sound-effect.wav");
            player.Play();
            Random rand = new Random();
            int shakeAmount = 50;
            int originalY = this.Location.Y;
            int originalX = this.Location.X;
            for (int i = 0; i < shakeAmount; i++)
            {
                int offsetX = rand.Next(-shakeAmount, shakeAmount);
                int offsetY = rand.Next(-shakeAmount, shakeAmount);
                this.Location = new Point(originalX + offsetX, originalY + offsetY);

                System.Threading.Thread.Sleep(50);
            }
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            shake();
            DisplayPictureBox.Refresh();
        }
        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();

            about.Show();
            this.Hide();
        }
        private void DisplayPictureBox_Click(object sender, EventArgs e)
        {

        }
        private void PenSizeComboBox_Click(object sender, EventArgs e)
        {

        }
        private void SplashForm()
        {
            SplashForm splashForm = new SplashForm();
            splashForm.Show();
            System.Threading.Thread.Sleep(3000);
            splashForm.Close();
        }
        private void PenSizeComboBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            UpdatePenSize();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ClearButton_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void ClearButton_KeyDown(object sender, KeyEventArgs e)//keyboard button event
        {
            if (e.KeyCode == Keys.Escape)
            {
                ClearButton.PerformClick(); // Triggers the button's Click event
            }
        }
        private void DrawButton_KeyDown(object sender, KeyEventArgs e)//keyboard button event
        {
            if (e.KeyCode == Keys.Enter)
            {
                DrawButton.PerformClick(); // Triggers the button's Click event
            }
        }
        private void AboutMenuItem_Click_1(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm(); //instantiate the about form
            aboutForm.FormClosed += AboutForm_FormClosed;// map the formclosed event to a handler
            aboutForm.Show(); //Opens the about form

        }
        private void AboutForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.Show();// shows the graphics form when about form is closed
        }
        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ColorButton_Click(object sender, EventArgs e)
        {
            UpdatePenColor();
            UpdateDisplayBoxColor();
        }
    }
}

