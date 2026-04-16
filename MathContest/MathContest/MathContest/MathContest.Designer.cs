namespace MathContest
{
    partial class MathContest
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
            SubmitButton = new Button();
            ClearButton = new Button();
            ExitButton = new Button();
            SummaryButton = new Button();
            StudentNameTextBox = new TextBox();
            StudentNameLabel = new Label();
            GradeLabel = new Label();
            AgeLabel = new Label();
            GradeTextBox = new TextBox();
            AgeTextBox = new TextBox();
            SuspendLayout();
            // 
            // SubmitButton
            // 
            SubmitButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SubmitButton.Location = new Point(734, 12);
            SubmitButton.Margin = new Padding(4, 3, 4, 3);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(156, 65);
            SubmitButton.TabIndex = 0;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            ClearButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ClearButton.Location = new Point(734, 97);
            ClearButton.Margin = new Padding(4, 3, 4, 3);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(156, 65);
            ClearButton.TabIndex = 1;
            ClearButton.Text = "Button";
            ClearButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            ExitButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ExitButton.Location = new Point(734, 267);
            ExitButton.Margin = new Padding(4, 3, 4, 3);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(156, 65);
            ExitButton.TabIndex = 3;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            // 
            // SummaryButton
            // 
            SummaryButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SummaryButton.Location = new Point(734, 182);
            SummaryButton.Margin = new Padding(4, 3, 4, 3);
            SummaryButton.Name = "SummaryButton";
            SummaryButton.Size = new Size(156, 65);
            SummaryButton.TabIndex = 2;
            SummaryButton.Text = "Summary";
            SummaryButton.UseVisualStyleBackColor = true;
            // 
            // StudentNameTextBox
            // 
            StudentNameTextBox.Location = new Point(165, 46);
            StudentNameTextBox.Margin = new Padding(4, 3, 4, 3);
            StudentNameTextBox.Name = "StudentNameTextBox";
            StudentNameTextBox.Size = new Size(194, 31);
            StudentNameTextBox.TabIndex = 4;
            // 
            // StudentNameLabel
            // 
            StudentNameLabel.AutoSize = true;
            StudentNameLabel.Location = new Point(18, 54);
            StudentNameLabel.Margin = new Padding(4, 0, 4, 0);
            StudentNameLabel.Name = "StudentNameLabel";
            StudentNameLabel.Size = new Size(139, 23);
            StudentNameLabel.TabIndex = 5;
            StudentNameLabel.Text = "Student Name";
            // 
            // GradeLabel
            // 
            GradeLabel.AutoSize = true;
            GradeLabel.Location = new Point(522, 54);
            GradeLabel.Margin = new Padding(4, 0, 4, 0);
            GradeLabel.Name = "GradeLabel";
            GradeLabel.Size = new Size(66, 23);
            GradeLabel.TabIndex = 6;
            GradeLabel.Text = "Grade";
            // 
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.Location = new Point(367, 54);
            AgeLabel.Margin = new Padding(4, 0, 4, 0);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(44, 23);
            AgeLabel.TabIndex = 7;
            AgeLabel.Text = "Age";
            AgeLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // GradeTextBox
            // 
            GradeTextBox.Location = new Point(419, 46);
            GradeTextBox.Margin = new Padding(4, 3, 4, 3);
            GradeTextBox.Name = "GradeTextBox";
            GradeTextBox.Size = new Size(73, 31);
            GradeTextBox.TabIndex = 8;
            // 
            // AgeTextBox
            // 
            AgeTextBox.Location = new Point(596, 46);
            AgeTextBox.Margin = new Padding(4, 3, 4, 3);
            AgeTextBox.Name = "AgeTextBox";
            AgeTextBox.Size = new Size(73, 31);
            AgeTextBox.TabIndex = 9;
            // 
            // MathContest
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 505);
            Controls.Add(AgeTextBox);
            Controls.Add(GradeTextBox);
            Controls.Add(AgeLabel);
            Controls.Add(GradeLabel);
            Controls.Add(StudentNameLabel);
            Controls.Add(StudentNameTextBox);
            Controls.Add(ExitButton);
            Controls.Add(SummaryButton);
            Controls.Add(ClearButton);
            Controls.Add(SubmitButton);
            Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MathContest";
            Text = "Math Contest";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SubmitButton;
        private Button ClearButton;
        private Button ExitButton;
        private Button SummaryButton;
        private TextBox StudentNameTextBox;
        private Label StudentNameLabel;
        private Label GradeLabel;
        private Label AgeLabel;
        private TextBox GradeTextBox;
        private TextBox AgeTextBox;
    }
}
