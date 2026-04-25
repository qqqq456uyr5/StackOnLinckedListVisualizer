namespace StackOnLinckedListVisualizer
{
    partial class VisualisationForm
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
            pictureBox = new PictureBox();
            groupbuttonsBox = new GroupBox();
            buttonClear = new Button();
            buttonPeek = new Button();
            buttonIsEmpty = new Button();
            textPushBox = new TextBox();
            popButton = new Button();
            pushButton = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            groupInformationBox = new GroupBox();
            labelSize = new Label();
            labelTop = new Label();
            labelDescription = new Label();
            labelName = new Label();
            richTextLogoBox = new RichTextBox();
            groupLogBox = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            groupbuttonsBox.SuspendLayout();
            menuStrip1.SuspendLayout();
            groupInformationBox.SuspendLayout();
            groupLogBox.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.BackColor = Color.White;
            pictureBox.Location = new Point(12, 32);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(1004, 154);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            pictureBox.Paint += pictureBox_Paint;
            // 
            // groupbuttonsBox
            // 
            groupbuttonsBox.Controls.Add(buttonClear);
            groupbuttonsBox.Controls.Add(buttonPeek);
            groupbuttonsBox.Controls.Add(buttonIsEmpty);
            groupbuttonsBox.Controls.Add(textPushBox);
            groupbuttonsBox.Controls.Add(popButton);
            groupbuttonsBox.Controls.Add(pushButton);
            groupbuttonsBox.Location = new Point(12, 188);
            groupbuttonsBox.Name = "groupbuttonsBox";
            groupbuttonsBox.Size = new Size(197, 210);
            groupbuttonsBox.TabIndex = 1;
            groupbuttonsBox.TabStop = false;
            groupbuttonsBox.Text = "Function";
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(109, 177);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(82, 27);
            buttonClear.TabIndex = 4;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonPeek
            // 
            buttonPeek.Location = new Point(6, 144);
            buttonPeek.Name = "buttonPeek";
            buttonPeek.Size = new Size(82, 27);
            buttonPeek.TabIndex = 5;
            buttonPeek.Text = "Peek";
            buttonPeek.UseVisualStyleBackColor = true;
            buttonPeek.Click += buttonPeek_Click;
            // 
            // buttonIsEmpty
            // 
            buttonIsEmpty.Location = new Point(6, 177);
            buttonIsEmpty.Name = "buttonIsEmpty";
            buttonIsEmpty.Size = new Size(82, 27);
            buttonIsEmpty.TabIndex = 4;
            buttonIsEmpty.Text = "Empty?";
            buttonIsEmpty.UseVisualStyleBackColor = true;
            buttonIsEmpty.Click += buttonIsEmpty_Click;
            // 
            // textPushBox
            // 
            textPushBox.Location = new Point(109, 26);
            textPushBox.Name = "textPushBox";
            textPushBox.Size = new Size(82, 27);
            textPushBox.TabIndex = 2;
            textPushBox.TextAlign = HorizontalAlignment.Center;
            // 
            // popButton
            // 
            popButton.Location = new Point(6, 59);
            popButton.Name = "popButton";
            popButton.Size = new Size(82, 27);
            popButton.TabIndex = 1;
            popButton.Text = "Pop";
            popButton.UseVisualStyleBackColor = true;
            popButton.Click += popButton_Click;
            // 
            // pushButton
            // 
            pushButton.Location = new Point(6, 26);
            pushButton.Name = "pushButton";
            pushButton.Size = new Size(82, 27);
            pushButton.TabIndex = 0;
            pushButton.Text = "Push";
            pushButton.UseVisualStyleBackColor = true;
            pushButton.Click += pushButton_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1028, 28);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem, loadToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(125, 26);
            saveToolStripMenuItem.Text = "Save";
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(125, 26);
            loadToolStripMenuItem.Text = "Load";
            // 
            // groupInformationBox
            // 
            groupInformationBox.Controls.Add(labelSize);
            groupInformationBox.Controls.Add(labelTop);
            groupInformationBox.Controls.Add(labelDescription);
            groupInformationBox.Controls.Add(labelName);
            groupInformationBox.Location = new Point(258, 188);
            groupInformationBox.Name = "groupInformationBox";
            groupInformationBox.Size = new Size(250, 210);
            groupInformationBox.TabIndex = 4;
            groupInformationBox.TabStop = false;
            groupInformationBox.Text = "Information";
            // 
            // labelSize
            // 
            labelSize.BackColor = Color.White;
            labelSize.Location = new Point(8, 177);
            labelSize.Name = "labelSize";
            labelSize.Size = new Size(198, 25);
            labelSize.TabIndex = 3;
            // 
            // labelTop
            // 
            labelTop.BackColor = Color.White;
            labelTop.Location = new Point(6, 144);
            labelTop.Name = "labelTop";
            labelTop.Size = new Size(198, 25);
            labelTop.TabIndex = 2;
            // 
            // labelDescription
            // 
            labelDescription.BackColor = Color.White;
            labelDescription.Location = new Point(4, 73);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(200, 62);
            labelDescription.TabIndex = 1;
            // 
            // labelName
            // 
            labelName.BackColor = Color.White;
            labelName.Location = new Point(6, 23);
            labelName.MaximumSize = new Size(200, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(200, 44);
            labelName.TabIndex = 0;
            // 
            // richTextLogoBox
            // 
            richTextLogoBox.Location = new Point(6, 19);
            richTextLogoBox.Name = "richTextLogoBox";
            richTextLogoBox.ReadOnly = true;
            richTextLogoBox.Size = new Size(478, 277);
            richTextLogoBox.TabIndex = 5; 
            // 
            // groupLogBox
            // 
            groupLogBox.Controls.Add(richTextLogoBox);
            groupLogBox.Location = new Point(526, 188);
            groupLogBox.Name = "groupLogBox";
            groupLogBox.Size = new Size(490, 302);
            groupLogBox.TabIndex = 6;
            groupLogBox.TabStop = false;
            groupLogBox.Text = "Activity Logs";
            // 
            // VisualisationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 532);
            Controls.Add(groupLogBox);
            Controls.Add(groupInformationBox);
            Controls.Add(menuStrip1);
            Controls.Add(groupbuttonsBox);
            Controls.Add(pictureBox);
            MainMenuStrip = menuStrip1;
            Name = "VisualisationForm";
            Text = "VisualisationForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            groupbuttonsBox.ResumeLayout(false);
            groupbuttonsBox.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupInformationBox.ResumeLayout(false);
            groupLogBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox;
        private GroupBox groupbuttonsBox;
        private TextBox textPushBox;
        private Button popButton;
        private Button pushButton;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem wefToolStripMenuItem2;
        private ToolStripMenuItem wefToolStripMenuItem3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private Button buttonClear;
        private Button buttonPeek;
        private Button buttonIsEmpty;
        private GroupBox groupInformationBox;
        private Label labelDescription;
        private Label labelName;
        private Label labelSize;
        private Label labelTop;
        private RichTextBox richTextLogoBox;
        private GroupBox groupLogBox;
    }
}