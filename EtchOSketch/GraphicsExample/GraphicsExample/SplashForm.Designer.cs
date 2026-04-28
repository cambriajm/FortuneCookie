namespace GraphicsExample
{
    partial class SplashForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashForm));
            SplashTimer = new System.Windows.Forms.Timer(components);
            frodoTextBox = new TextBox();
            SuspendLayout();
            // 
            // frodoTextBox
            // 
            frodoTextBox.BackColor = SystemColors.MenuBar;
            frodoTextBox.BorderStyle = BorderStyle.FixedSingle;
            frodoTextBox.Font = new Font("Comic Sans MS", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            frodoTextBox.Location = new Point(110, 45);
            frodoTextBox.Name = "frodoTextBox";
            frodoTextBox.Size = new Size(323, 67);
            frodoTextBox.TabIndex = 0;
            frodoTextBox.Text = "It's Mr Frodo! ";
            frodoTextBox.TextChanged += textBox1_TextChanged;
            // 
            // SplashForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(frodoTextBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SplashForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SplashForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer SplashTimer;
        private TextBox frodoTextBox;
    }
}