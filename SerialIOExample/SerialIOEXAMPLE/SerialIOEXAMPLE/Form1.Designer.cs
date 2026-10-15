using System.Drawing;
using System.Windows.Forms;

namespace SerialExample
{
    partial class SerialForm
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
            this.components = new System.ComponentModel.Container();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.ReadButton = new System.Windows.Forms.Button();
            this.SendButton = new System.Windows.Forms.Button();
            this.SerialTextBox = new System.Windows.Forms.TextBox();
            this.StatusTimer = new System.Windows.Forms.Timer(this.components);
            this.PortsComboBox = new System.Windows.Forms.ComboBox();
            this.ComListBox = new System.Windows.Forms.ListBox();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.AnalogTimer = new System.Windows.Forms.Timer(this.components);
            this.AN1CheckBox = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.Location = new System.Drawing.Point(577, 307);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(105, 50);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "E&xit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ConnectButton
            // 
            this.ConnectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ConnectButton.Location = new System.Drawing.Point(466, 307);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(105, 50);
            this.ConnectButton.TabIndex = 2;
            this.ConnectButton.Text = "&Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // ReadButton
            // 
            this.ReadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ReadButton.Location = new System.Drawing.Point(355, 307);
            this.ReadButton.Name = "ReadButton";
            this.ReadButton.Size = new System.Drawing.Size(105, 50);
            this.ReadButton.TabIndex = 3;
            this.ReadButton.Text = "&Read";
            this.ReadButton.UseVisualStyleBackColor = true;
            this.ReadButton.Click += new System.EventHandler(this.ReadButton_Click);
            // 
            // SendButton
            // 
            this.SendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SendButton.Location = new System.Drawing.Point(244, 307);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(105, 50);
            this.SendButton.TabIndex = 4;
            this.SendButton.Text = "&Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // SerialTextBox
            // 
            this.SerialTextBox.Location = new System.Drawing.Point(14, 53);
            this.SerialTextBox.Name = "SerialTextBox";
            this.SerialTextBox.Size = new System.Drawing.Size(138, 22);
            this.SerialTextBox.TabIndex = 5;
            // 
            // StatusTimer
            // 
            this.StatusTimer.Enabled = true;
            // 
            // PortsComboBox
            // 
            this.PortsComboBox.FormattingEnabled = true;
            this.PortsComboBox.Location = new System.Drawing.Point(14, 13);
            this.PortsComboBox.Name = "PortsComboBox";
            this.PortsComboBox.Size = new System.Drawing.Size(138, 24);
            this.PortsComboBox.TabIndex = 7;
            // 
            // ComListBox
            // 
            this.ComListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComListBox.FormattingEnabled = true;
            this.ComListBox.ItemHeight = 16;
            this.ComListBox.Location = new System.Drawing.Point(160, 13);
            this.ComListBox.Name = "ComListBox";
            this.ComListBox.Size = new System.Drawing.Size(522, 276);
            this.ComListBox.TabIndex = 8;
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(14, 90);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(138, 22);
            this.OutputTextBox.TabIndex = 9;
            // 
            // AN1CheckBox
            // 
            this.AN1CheckBox.AutoSize = true;
            this.AN1CheckBox.Location = new System.Drawing.Point(14, 118);
            this.AN1CheckBox.Name = "AN1CheckBox";
            this.AN1CheckBox.Size = new System.Drawing.Size(55, 20);
            this.AN1CheckBox.TabIndex = 10;
            this.AN1CheckBox.Text = "AN1";
            this.AN1CheckBox.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 360);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(694, 26);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(63, 20);
            this.StatusLabel.Text = "Loading";
            // 
            // SerialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 386);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.AN1CheckBox);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.ComListBox);
            this.Controls.Add(this.PortsComboBox);
            this.Controls.Add(this.SerialTextBox);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.ReadButton);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.ExitButton);
            this.Name = "SerialForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ExitButton;
        private Button ConnectButton;
        private Button ReadButton;
        private Button SendButton;
        private TextBox SerialTextBox;
        private System.Windows.Forms.Timer StatusTimer;
        private ComboBox PortsComboBox;
        private ListBox ComListBox;
        private TextBox OutputTextBox;
        private Timer AnalogTimer;
        private CheckBox AN1CheckBox;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel StatusLabel;
    }
}