namespace StansGrocery
{
    partial class StansGrocery
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
            components = new System.ComponentModel.Container();
            TopMenuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            ContextMenuStrip = new ContextMenuStrip(components);
            searchToolStripMenuItem1 = new ToolStripMenuItem();
            exitToolStripMenuItem1 = new ToolStripMenuItem();
            ItemNameTextBox = new TextBox();
            ItemComboBox = new ComboBox();
            DisplayListBox = new ListBox();
            AisleRadioButton = new RadioButton();
            FilterRadioButton = new RadioButton();
            SearchButton = new Button();
            TopMenuStrip.SuspendLayout();
            ContextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // TopMenuStrip
            // 
            TopMenuStrip.ImageScalingSize = new Size(20, 20);
            TopMenuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            TopMenuStrip.Location = new Point(0, 0);
            TopMenuStrip.Name = "TopMenuStrip";
            TopMenuStrip.Size = new Size(868, 28);
            TopMenuStrip.TabIndex = 0;
            TopMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { searchToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new Size(136, 26);
            searchToolStripMenuItem.Text = "Search";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(136, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(133, 26);
            aboutToolStripMenuItem.Text = "About";
            // 
            // ContextMenuStrip
            // 
            ContextMenuStrip.ImageScalingSize = new Size(20, 20);
            ContextMenuStrip.Items.AddRange(new ToolStripItem[] { searchToolStripMenuItem1, exitToolStripMenuItem1 });
            ContextMenuStrip.Name = "ContextMenuStrip";
            ContextMenuStrip.Size = new Size(123, 52);
            // 
            // searchToolStripMenuItem1
            // 
            searchToolStripMenuItem1.Name = "searchToolStripMenuItem1";
            searchToolStripMenuItem1.Size = new Size(122, 24);
            searchToolStripMenuItem1.Text = "Search";
            // 
            // exitToolStripMenuItem1
            // 
            exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            exitToolStripMenuItem1.Size = new Size(122, 24);
            exitToolStripMenuItem1.Text = "Exit";
            // 
            // ItemNameTextBox
            // 
            ItemNameTextBox.Location = new Point(102, 76);
            ItemNameTextBox.Name = "ItemNameTextBox";
            ItemNameTextBox.Size = new Size(125, 27);
            ItemNameTextBox.TabIndex = 1;
            // 
            // ItemComboBox
            // 
            ItemComboBox.FormattingEnabled = true;
            ItemComboBox.Location = new Point(268, 75);
            ItemComboBox.Name = "ItemComboBox";
            ItemComboBox.Size = new Size(151, 28);
            ItemComboBox.TabIndex = 2;
            ItemComboBox.SelectedIndexChanged += ItemComboBox_SelectedIndexChanged;
            // 
            // DisplayListBox
            // 
            DisplayListBox.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DisplayListBox.FormattingEnabled = true;
            DisplayListBox.Location = new Point(100, 134);
            DisplayListBox.Name = "DisplayListBox";
            DisplayListBox.Size = new Size(551, 224);
            DisplayListBox.TabIndex = 3;
            // 
            // AisleRadioButton
            // 
            AisleRadioButton.AutoSize = true;
            AisleRadioButton.Location = new Point(179, 415);
            AisleRadioButton.Name = "AisleRadioButton";
            AisleRadioButton.Size = new Size(62, 24);
            AisleRadioButton.TabIndex = 4;
            AisleRadioButton.TabStop = true;
            AisleRadioButton.Text = "Aisle";
            AisleRadioButton.UseVisualStyleBackColor = true;
            AisleRadioButton.CheckedChanged += AisleRadioButton_CheckedChanged;
            // 
            // FilterRadioButton
            // 
            FilterRadioButton.AutoSize = true;
            FilterRadioButton.Location = new Point(284, 398);
            FilterRadioButton.Name = "FilterRadioButton";
            FilterRadioButton.Size = new Size(90, 24);
            FilterRadioButton.TabIndex = 5;
            FilterRadioButton.TabStop = true;
            FilterRadioButton.Text = "Category";
            FilterRadioButton.UseVisualStyleBackColor = true;
            FilterRadioButton.CheckedChanged += FilterRadioButton_CheckedChanged;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(502, 391);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(145, 46);
            SearchButton.TabIndex = 6;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            // 
            // StansGrocery
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 469);
            Controls.Add(SearchButton);
            Controls.Add(FilterRadioButton);
            Controls.Add(AisleRadioButton);
            Controls.Add(DisplayListBox);
            Controls.Add(ItemComboBox);
            Controls.Add(ItemNameTextBox);
            Controls.Add(TopMenuStrip);
            MainMenuStrip = TopMenuStrip;
            Name = "StansGrocery";
            Text = "Stans Grocery";
            TopMenuStrip.ResumeLayout(false);
            TopMenuStrip.PerformLayout();
            ContextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip TopMenuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ContextMenuStrip ContextMenuStrip;
        private ToolStripMenuItem searchToolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem1;
        private TextBox ItemNameTextBox;
        private ComboBox ItemComboBox;
        private ListBox DisplayListBox;
        private RadioButton AisleRadioButton;
        private RadioButton FilterRadioButton;
        private Button SearchButton;
    }
}
