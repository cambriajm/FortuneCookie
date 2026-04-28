namespace GraphicsExample
{
    partial class GraphicsForm
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
            DisplayPictureBox = new PictureBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            drawToolStripMenuItem = new ToolStripMenuItem();
            clearToolStripMenuItem = new ToolStripMenuItem();
            colorToolStripMenuItem = new ToolStripMenuItem();
            penSizeToolStripMenuItem = new ToolStripMenuItem();
            PenSizeComboBox = new ToolStripComboBox();
            DrawButton = new Button();
            ExitButton = new Button();
            PenColorDialogue = new ColorDialog();
            ContextMenu = new MenuStrip();
            FileMenuItem = new ToolStripMenuItem();
            ExitMenuItem = new ToolStripMenuItem();
            EditTopMenuItem = new ToolStripMenuItem();
            ColorMenuItem = new ToolStripMenuItem();
            DrawItem = new ToolStripMenuItem();
            ClearMenu = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            AboutMenuItem = new ToolStripMenuItem();
            ClearButton = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ColorButton = new Button();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)DisplayPictureBox).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ContextMenu.SuspendLayout();
            SuspendLayout();
            // 
            // DisplayPictureBox
            // 
            DisplayPictureBox.AccessibleRole = AccessibleRole.Diagram;
            DisplayPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DisplayPictureBox.BackColor = SystemColors.ButtonShadow;
            DisplayPictureBox.BorderStyle = BorderStyle.FixedSingle;
            DisplayPictureBox.ContextMenuStrip = contextMenuStrip1;
            DisplayPictureBox.Location = new Point(12, 38);
            DisplayPictureBox.Name = "DisplayPictureBox";
            DisplayPictureBox.Size = new Size(731, 362);
            DisplayPictureBox.TabIndex = 0;
            DisplayPictureBox.TabStop = false;
            toolTip1.SetToolTip(DisplayPictureBox, "This is where you draw. Woah");
            DisplayPictureBox.Click += DisplayPictureBox_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { drawToolStripMenuItem, clearToolStripMenuItem, colorToolStripMenuItem, penSizeToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(133, 100);
            // 
            // drawToolStripMenuItem
            // 
            drawToolStripMenuItem.Name = "drawToolStripMenuItem";
            drawToolStripMenuItem.Size = new Size(132, 24);
            drawToolStripMenuItem.Text = "Draw";
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.Size = new Size(132, 24);
            clearToolStripMenuItem.Text = "Clear";
            // 
            // colorToolStripMenuItem
            // 
            colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            colorToolStripMenuItem.Size = new Size(132, 24);
            colorToolStripMenuItem.Text = "Color";
            // 
            // penSizeToolStripMenuItem
            // 
            penSizeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { PenSizeComboBox });
            penSizeToolStripMenuItem.Name = "penSizeToolStripMenuItem";
            penSizeToolStripMenuItem.Size = new Size(132, 24);
            penSizeToolStripMenuItem.Text = "Pen Size";
            // 
            // PenSizeComboBox
            // 
            PenSizeComboBox.Name = "PenSizeComboBox";
            PenSizeComboBox.Size = new Size(121, 28);
            PenSizeComboBox.Click += PenSizeComboBox_Click;
            // 
            // DrawButton
            // 
            DrawButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            DrawButton.Location = new Point(401, 420);
            DrawButton.Name = "DrawButton";
            DrawButton.Size = new Size(150, 59);
            DrawButton.TabIndex = 3;
            DrawButton.Text = "Draw";
            toolTip1.SetToolTip(DrawButton, "This will draw the grid and three waveforms");
            DrawButton.UseVisualStyleBackColor = true;
            DrawButton.Click += DrawButton_Click;
            DrawButton.KeyDown += DrawButton_KeyDown;
            // 
            // ExitButton
            // 
            ExitButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ExitButton.AutoSize = true;
            ExitButton.Location = new Point(593, 420);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(150, 59);
            ExitButton.TabIndex = 4;
            ExitButton.Text = "E&xit";
            toolTip1.SetToolTip(ExitButton, "GET OUT OF HERE BUTTON!");
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // ContextMenu
            // 
            ContextMenu.ImageScalingSize = new Size(20, 20);
            ContextMenu.Items.AddRange(new ToolStripItem[] { FileMenuItem, EditTopMenuItem, helpToolStripMenuItem });
            ContextMenu.Location = new Point(0, 0);
            ContextMenu.Name = "ContextMenu";
            ContextMenu.Size = new Size(755, 28);
            ContextMenu.TabIndex = 3;
            ContextMenu.Text = "menuStrip1";
            // 
            // FileMenuItem
            // 
            FileMenuItem.AutoToolTip = true;
            FileMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ExitMenuItem });
            FileMenuItem.Name = "FileMenuItem";
            FileMenuItem.Size = new Size(46, 24);
            FileMenuItem.Text = "&File";
            FileMenuItem.ToolTipText = "Menu item which allows you to close the file.";
            // 
            // ExitMenuItem
            // 
            ExitMenuItem.Name = "ExitMenuItem";
            ExitMenuItem.Size = new Size(116, 26);
            ExitMenuItem.Text = "E&xit";
            ExitMenuItem.Click += ExitMenuItem_Click;
            // 
            // EditTopMenuItem
            // 
            EditTopMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ColorMenuItem, DrawItem, ClearMenu });
            EditTopMenuItem.Name = "EditTopMenuItem";
            EditTopMenuItem.Size = new Size(49, 24);
            EditTopMenuItem.Text = "&Edit";
            EditTopMenuItem.ToolTipText = "Edit menu item, here the edit options are found";
            // 
            // ColorMenuItem
            // 
            ColorMenuItem.Name = "ColorMenuItem";
            ColorMenuItem.Size = new Size(128, 26);
            ColorMenuItem.Text = "Color";
            ColorMenuItem.ToolTipText = "Color can be selected, first pen, then the background color";
            ColorMenuItem.Click += ColorButton_Click;
            // 
            // DrawItem
            // 
            DrawItem.Name = "DrawItem";
            DrawItem.Size = new Size(128, 26);
            DrawItem.Text = "Draw";
            DrawItem.ToolTipText = "This will draw a grid, and three waveforms";
            // 
            // ClearMenu
            // 
            ClearMenu.Name = "ClearMenu";
            ClearMenu.Size = new Size(128, 26);
            ClearMenu.Text = "Clear";
            ClearMenu.ToolTipText = "This will clear the drawing";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AboutMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "&Help";
            helpToolStripMenuItem.ToolTipText = "HELP MEEEEE";
            // 
            // AboutMenuItem
            // 
            AboutMenuItem.Name = "AboutMenuItem";
            AboutMenuItem.Size = new Size(133, 26);
            AboutMenuItem.Text = "About";
            AboutMenuItem.ToolTipText = "This sends you to the help form";
            AboutMenuItem.Click += AboutMenuItem_Click_1;
            // 
            // ClearButton
            // 
            ClearButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ClearButton.AutoEllipsis = true;
            ClearButton.Location = new Point(207, 420);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(150, 59);
            ClearButton.TabIndex = 2;
            ClearButton.Text = "Clear";
            toolTip1.SetToolTip(ClearButton, "This clears the drawing");
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            ClearButton.KeyDown += ClearButton_KeyDown;
            ClearButton.KeyPress += ClearButton_KeyPress;
            // 
            // ColorButton
            // 
            ColorButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ColorButton.ImageAlign = ContentAlignment.TopRight;
            ColorButton.Location = new Point(12, 420);
            ColorButton.Name = "ColorButton";
            ColorButton.Size = new Size(150, 59);
            ColorButton.TabIndex = 1;
            ColorButton.Text = "Color";
            toolTip1.SetToolTip(ColorButton, "Click to select color, pen first then the background");
            ColorButton.UseVisualStyleBackColor = true;
            ColorButton.Click += ColorButton_Click;
            // 
            // GraphicsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 491);
            Controls.Add(ColorButton);
            Controls.Add(ClearButton);
            Controls.Add(ExitButton);
            Controls.Add(DrawButton);
            Controls.Add(DisplayPictureBox);
            Controls.Add(ContextMenu);
            Cursor = Cursors.Hand;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = ContextMenu;
            Name = "GraphicsForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EtchOSketch";
            toolTip1.SetToolTip(this, "MY LEGGG (like the spongebob fish guy)");
            ((System.ComponentModel.ISupportInitialize)DisplayPictureBox).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ContextMenu.ResumeLayout(false);
            ContextMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button DrawButton;
        private Button ExitButton;
        private ColorDialog PenColorDialogue;
        private MenuStrip ContextMenu;
        private ToolStripMenuItem FileMenuItem;
        private ToolStripMenuItem EditTopMenuItem;
        private ToolStripMenuItem ExitMenuItem;
        private ToolStripMenuItem ColorMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem drawToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ToolStripMenuItem penSizeToolStripMenuItem;
        private Button ClearButton;
        private ToolStripComboBox PenSizeComboBox;
        private System.Windows.Forms.Timer timer1;
        protected PictureBox DisplayPictureBox;
        private Button ColorButton;
        private ToolStripMenuItem DrawItem;
        private ToolStripMenuItem ClearMenu;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem AboutMenuItem;
        private ToolTip toolTip1;
    }
}
