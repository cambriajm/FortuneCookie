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
            StudentInfoGroupBox = new GroupBox();
            AddButton = new RadioButton();
            SubtractButton = new RadioButton();
            DivideButton = new RadioButton();
            MultiplyButton = new RadioButton();
            ButtonGroupBox = new GroupBox();
            FirstNumberTextBox = new TextBox();
            SecondNumberTextBox = new TextBox();
            StudentAnswerTextBox = new TextBox();
            FirstNumberLabel = new Label();
            SecondNumberLabel = new Label();
            StudentAnswerLabel = new Label();
            MathGroupBox = new GroupBox();
            StudentInfoGroupBox.SuspendLayout();
            ButtonGroupBox.SuspendLayout();
            MathGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // SubmitButton
            // 
            SubmitButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SubmitButton.Location = new Point(741, 102);
            SubmitButton.Margin = new Padding(4, 3, 4, 3);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(156, 65);
            SubmitButton.TabIndex = 0;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ClearButton.Location = new Point(741, 187);
            ClearButton.Margin = new Padding(4, 3, 4, 3);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(156, 65);
            ClearButton.TabIndex = 1;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ExitButton.Location = new Point(741, 357);
            ExitButton.Margin = new Padding(4, 3, 4, 3);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(156, 65);
            ExitButton.TabIndex = 3;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // SummaryButton
            // 
            SummaryButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SummaryButton.Location = new Point(741, 272);
            SummaryButton.Margin = new Padding(4, 3, 4, 3);
            SummaryButton.Name = "SummaryButton";
            SummaryButton.Size = new Size(156, 65);
            SummaryButton.TabIndex = 2;
            SummaryButton.Text = "Summary";
            SummaryButton.UseVisualStyleBackColor = true;
            SummaryButton.Click += SummaryButton_Click;
            // 
            // StudentNameTextBox
            // 
            StudentNameTextBox.Location = new Point(163, 34);
            StudentNameTextBox.Margin = new Padding(4, 3, 4, 3);
            StudentNameTextBox.Name = "StudentNameTextBox";
            StudentNameTextBox.Size = new Size(194, 31);
            StudentNameTextBox.TabIndex = 4;
            // 
            // StudentNameLabel
            // 
            StudentNameLabel.AutoSize = true;
            StudentNameLabel.Location = new Point(16, 42);
            StudentNameLabel.Margin = new Padding(4, 0, 4, 0);
            StudentNameLabel.Name = "StudentNameLabel";
            StudentNameLabel.Size = new Size(139, 23);
            StudentNameLabel.TabIndex = 5;
            StudentNameLabel.Text = "Student Name";
            // 
            // GradeLabel
            // 
            GradeLabel.AutoSize = true;
            GradeLabel.Location = new Point(520, 42);
            GradeLabel.Margin = new Padding(4, 0, 4, 0);
            GradeLabel.Name = "GradeLabel";
            GradeLabel.Size = new Size(66, 23);
            GradeLabel.TabIndex = 6;
            GradeLabel.Text = "Grade";
            // 
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.Location = new Point(365, 42);
            AgeLabel.Margin = new Padding(4, 0, 4, 0);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(44, 23);
            AgeLabel.TabIndex = 7;
            AgeLabel.Text = "Age";
            AgeLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // GradeTextBox
            // 
            GradeTextBox.Location = new Point(417, 34);
            GradeTextBox.Margin = new Padding(4, 3, 4, 3);
            GradeTextBox.Name = "GradeTextBox";
            GradeTextBox.Size = new Size(73, 31);
            GradeTextBox.TabIndex = 8;
            // 
            // AgeTextBox
            // 
            AgeTextBox.Location = new Point(594, 34);
            AgeTextBox.Margin = new Padding(4, 3, 4, 3);
            AgeTextBox.Name = "AgeTextBox";
            AgeTextBox.Size = new Size(73, 31);
            AgeTextBox.TabIndex = 9;
            // 
            // StudentInfoGroupBox
            // 
            StudentInfoGroupBox.Controls.Add(AgeTextBox);
            StudentInfoGroupBox.Controls.Add(GradeTextBox);
            StudentInfoGroupBox.Controls.Add(AgeLabel);
            StudentInfoGroupBox.Controls.Add(GradeLabel);
            StudentInfoGroupBox.Controls.Add(StudentNameLabel);
            StudentInfoGroupBox.Controls.Add(StudentNameTextBox);
            StudentInfoGroupBox.Location = new Point(11, 12);
            StudentInfoGroupBox.Name = "StudentInfoGroupBox";
            StudentInfoGroupBox.Size = new Size(684, 102);
            StudentInfoGroupBox.TabIndex = 10;
            StudentInfoGroupBox.TabStop = false;
            StudentInfoGroupBox.Text = "Student Information";
            // 
            // AddButton
            // 
            AddButton.AutoSize = true;
            AddButton.Location = new Point(78, 49);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(68, 27);
            AddButton.TabIndex = 11;
            AddButton.TabStop = true;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            // 
            // SubtractButton
            // 
            SubtractButton.AutoSize = true;
            SubtractButton.Location = new Point(78, 95);
            SubtractButton.Name = "SubtractButton";
            SubtractButton.Size = new Size(108, 27);
            SubtractButton.TabIndex = 12;
            SubtractButton.TabStop = true;
            SubtractButton.Text = "Subtract";
            SubtractButton.UseVisualStyleBackColor = true;
            // 
            // DivideButton
            // 
            DivideButton.AutoSize = true;
            DivideButton.Location = new Point(78, 187);
            DivideButton.Name = "DivideButton";
            DivideButton.Size = new Size(90, 27);
            DivideButton.TabIndex = 14;
            DivideButton.TabStop = true;
            DivideButton.Text = "Divide";
            DivideButton.UseVisualStyleBackColor = true;
            // 
            // MultiplyButton
            // 
            MultiplyButton.AutoSize = true;
            MultiplyButton.Location = new Point(78, 141);
            MultiplyButton.Name = "MultiplyButton";
            MultiplyButton.Size = new Size(107, 27);
            MultiplyButton.TabIndex = 13;
            MultiplyButton.TabStop = true;
            MultiplyButton.Text = "Multiply";
            MultiplyButton.UseVisualStyleBackColor = true;
            // 
            // ButtonGroupBox
            // 
            ButtonGroupBox.Controls.Add(DivideButton);
            ButtonGroupBox.Controls.Add(MultiplyButton);
            ButtonGroupBox.Controls.Add(SubtractButton);
            ButtonGroupBox.Controls.Add(AddButton);
            ButtonGroupBox.Location = new Point(449, 182);
            ButtonGroupBox.Name = "ButtonGroupBox";
            ButtonGroupBox.Size = new Size(246, 258);
            ButtonGroupBox.TabIndex = 15;
            ButtonGroupBox.TabStop = false;
            ButtonGroupBox.Text = "Equation Type";
            // 
            // FirstNumberTextBox
            // 
            FirstNumberTextBox.Location = new Point(173, 45);
            FirstNumberTextBox.Name = "FirstNumberTextBox";
            FirstNumberTextBox.Size = new Size(194, 31);
            FirstNumberTextBox.TabIndex = 16;
            // 
            // SecondNumberTextBox
            // 
            SecondNumberTextBox.Location = new Point(173, 115);
            SecondNumberTextBox.Name = "SecondNumberTextBox";
            SecondNumberTextBox.Size = new Size(194, 31);
            SecondNumberTextBox.TabIndex = 17;
            // 
            // StudentAnswerTextBox
            // 
            StudentAnswerTextBox.Location = new Point(173, 182);
            StudentAnswerTextBox.Name = "StudentAnswerTextBox";
            StudentAnswerTextBox.Size = new Size(194, 31);
            StudentAnswerTextBox.TabIndex = 18;
            // 
            // FirstNumberLabel
            // 
            FirstNumberLabel.AutoSize = true;
            FirstNumberLabel.Location = new Point(26, 49);
            FirstNumberLabel.Name = "FirstNumberLabel";
            FirstNumberLabel.Size = new Size(132, 23);
            FirstNumberLabel.TabIndex = 19;
            FirstNumberLabel.Text = "First Number";
            // 
            // SecondNumberLabel
            // 
            SecondNumberLabel.AutoSize = true;
            SecondNumberLabel.Location = new Point(10, 118);
            SecondNumberLabel.Name = "SecondNumberLabel";
            SecondNumberLabel.Size = new Size(155, 23);
            SecondNumberLabel.TabIndex = 20;
            SecondNumberLabel.Text = "Second Number";
            // 
            // StudentAnswerLabel
            // 
            StudentAnswerLabel.AutoSize = true;
            StudentAnswerLabel.Location = new Point(12, 185);
            StudentAnswerLabel.Name = "StudentAnswerLabel";
            StudentAnswerLabel.Size = new Size(155, 23);
            StudentAnswerLabel.TabIndex = 21;
            StudentAnswerLabel.Text = "Student Answer";
            // 
            // MathGroupBox
            // 
            MathGroupBox.Controls.Add(StudentAnswerLabel);
            MathGroupBox.Controls.Add(SecondNumberLabel);
            MathGroupBox.Controls.Add(FirstNumberLabel);
            MathGroupBox.Controls.Add(StudentAnswerTextBox);
            MathGroupBox.Controls.Add(SecondNumberTextBox);
            MathGroupBox.Controls.Add(FirstNumberTextBox);
            MathGroupBox.Location = new Point(23, 182);
            MathGroupBox.Name = "MathGroupBox";
            MathGroupBox.Size = new Size(404, 258);
            MathGroupBox.TabIndex = 22;
            MathGroupBox.TabStop = false;
            MathGroupBox.Text = "Current Math Problem";
            // 
            // MathContest
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 505);
            Controls.Add(MathGroupBox);
            Controls.Add(ButtonGroupBox);
            Controls.Add(StudentInfoGroupBox);
            Controls.Add(ExitButton);
            Controls.Add(SummaryButton);
            Controls.Add(ClearButton);
            Controls.Add(SubmitButton);
            Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MathContest";
            Text = "Math Contest";
            StudentInfoGroupBox.ResumeLayout(false);
            StudentInfoGroupBox.PerformLayout();
            ButtonGroupBox.ResumeLayout(false);
            ButtonGroupBox.PerformLayout();
            MathGroupBox.ResumeLayout(false);
            MathGroupBox.PerformLayout();
            ResumeLayout(false);
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
        private GroupBox StudentInfoGroupBox;
        private RadioButton AddButton;
        private RadioButton SubtractButton;
        private RadioButton DivideButton;
        private RadioButton MultiplyButton;
        private GroupBox ButtonGroupBox;
        private TextBox FirstNumberTextBox;
        private TextBox SecondNumberTextBox;
        private TextBox StudentAnswerTextBox;
        private Label FirstNumberLabel;
        private Label SecondNumberLabel;
        private Label StudentAnswerLabel;
        private GroupBox MathGroupBox;
    }
}
