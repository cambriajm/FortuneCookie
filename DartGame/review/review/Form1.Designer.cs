namespace review
{
    partial class reviewform
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ExitButton = new Button();
            drawPicBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)drawPicBox).BeginInit();
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(676, 380);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(112, 58);
            ExitButton.TabIndex = 0;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // drawPicBox
            // 
            drawPicBox.Location = new Point(21, 24);
            drawPicBox.Name = "drawPicBox";
            drawPicBox.Size = new Size(724, 344);
            drawPicBox.TabIndex = 1;
            drawPicBox.TabStop = false;
            drawPicBox.Click += drawPicBox_Click;
            // 
            // reviewform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(drawPicBox);
            Controls.Add(ExitButton);
            Name = "reviewform";
            Text = "reviewform";
            ((System.ComponentModel.ISupportInitialize)drawPicBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button ExitButton;
        private PictureBox drawPicBox;
    }
}
