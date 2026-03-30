namespace CamDiner
{
    partial class CamsDiner
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
            DinerLabel = new Label();
            ExitButton = new Button();
            SoupButton = new Button();
            SpecialButton = new Button();
            FishButton = new Button();
            Diner2Label = new Label();
            SuspendLayout();
            // 
            // DinerLabel
            // 
            DinerLabel.AutoSize = true;
            DinerLabel.Font = new Font("Showcard Gothic", 36F, FontStyle.Underline, GraphicsUnit.Point, 0);
            DinerLabel.Location = new Point(240, 56);
            DinerLabel.Name = "DinerLabel";
            DinerLabel.Size = new Size(386, 74);
            DinerLabel.TabIndex = 0;
            DinerLabel.Text = "Cam's Diner";
            // 
            // ExitButton
            // 
            ExitButton.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExitButton.Location = new Point(746, 437);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(118, 58);
            ExitButton.TabIndex = 4;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // SoupButton
            // 
            SoupButton.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SoupButton.Location = new Point(12, 437);
            SoupButton.Name = "SoupButton";
            SoupButton.Size = new Size(118, 58);
            SoupButton.TabIndex = 1;
            SoupButton.Text = "Daily Soup";
            SoupButton.UseVisualStyleBackColor = true;
            SoupButton.Click += SoupButton_Click;
            // 
            // SpecialButton
            // 
            SpecialButton.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SpecialButton.Location = new Point(145, 437);
            SpecialButton.Name = "SpecialButton";
            SpecialButton.Size = new Size(118, 58);
            SpecialButton.TabIndex = 2;
            SpecialButton.Text = "Chef Special";
            SpecialButton.UseVisualStyleBackColor = true;
            SpecialButton.Click += SpecialButton_Click;
            // 
            // FishButton
            // 
            FishButton.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FishButton.Location = new Point(279, 437);
            FishButton.Name = "FishButton";
            FishButton.Size = new Size(118, 58);
            FishButton.TabIndex = 3;
            FishButton.Text = "Daily Fish";
            FishButton.UseVisualStyleBackColor = true;
            FishButton.Click += FishButton_Click;
            // 
            // Diner2Label
            // 
            Diner2Label.AutoSize = true;
            Diner2Label.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Diner2Label.Location = new Point(279, 175);
            Diner2Label.Name = "Diner2Label";
            Diner2Label.Size = new Size(0, 26);
            Diner2Label.TabIndex = 5;
            // 
            // CamsDiner
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 507);
            Controls.Add(Diner2Label);
            Controls.Add(FishButton);
            Controls.Add(SpecialButton);
            Controls.Add(SoupButton);
            Controls.Add(ExitButton);
            Controls.Add(DinerLabel);
            Name = "CamsDiner";
            Text = "Cam's Diner";
            Load += CamsDiner_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DinerLabel;
        private Button ExitButton;
        private Button SoupButton;
        private Button SpecialButton;
        private Button FishButton;
        private Label Diner2Label;
    }
}
