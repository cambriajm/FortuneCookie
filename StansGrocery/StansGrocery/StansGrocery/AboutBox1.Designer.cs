namespace StansGrocery
{
    partial class AboutForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            okButton = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // okButton
            // 
            okButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            okButton.DialogResult = DialogResult.Cancel;
            okButton.Location = new Point(284, 181);
            okButton.Margin = new Padding(4, 5, 4, 5);
            okButton.Name = "okButton";
            okButton.Size = new Size(100, 34);
            okButton.TabIndex = 25;
            okButton.Text = "&OK";
            okButton.Click += okButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(37, 39);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(248, 128);
            textBox1.TabIndex = 26;
            textBox1.Text = "This form is for Stans Grocery Store. Select the item wanted by Aisle and Category. The item can also be searched for in the search text box. The exit is under the file option.";
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 247);
            Controls.Add(textBox1);
            Controls.Add(okButton);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AboutForm";
            Padding = new Padding(12, 14, 12, 14);
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = " ";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Button okButton;
        private TextBox textBox1;
    }
}
