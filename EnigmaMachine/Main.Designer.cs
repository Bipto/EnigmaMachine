namespace EnigmaMachine
{
    partial class Main
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
            pnlInput = new Panel();
            pnlInputContent = new Panel();
            tbxInput = new TextBox();
            pnlInputTitle = new Panel();
            lblInput = new Label();
            rbtDecrypt = new RadioButton();
            rbtEncrypt = new RadioButton();
            pnlOutput = new Panel();
            tbxOutput = new TextBox();
            pnlOutputTitle = new Panel();
            lblOutput = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            propertiesToolStripMenuItem = new ToolStripMenuItem();
            configureToolStripMenuItem = new ToolStripMenuItem();
            pnlInput.SuspendLayout();
            pnlInputContent.SuspendLayout();
            pnlInputTitle.SuspendLayout();
            pnlOutput.SuspendLayout();
            pnlOutputTitle.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlInput
            // 
            pnlInput.Controls.Add(pnlInputContent);
            pnlInput.Controls.Add(pnlInputTitle);
            pnlInput.Dock = DockStyle.Top;
            pnlInput.Location = new Point(0, 36);
            pnlInput.Name = "pnlInput";
            pnlInput.Size = new Size(1207, 125);
            pnlInput.TabIndex = 0;
            // 
            // pnlInputContent
            // 
            pnlInputContent.Controls.Add(tbxInput);
            pnlInputContent.Dock = DockStyle.Fill;
            pnlInputContent.Location = new Point(0, 38);
            pnlInputContent.Name = "pnlInputContent";
            pnlInputContent.Size = new Size(1207, 87);
            pnlInputContent.TabIndex = 2;
            // 
            // tbxInput
            // 
            tbxInput.Dock = DockStyle.Fill;
            tbxInput.Font = new Font("Segoe UI", 12F);
            tbxInput.Location = new Point(0, 0);
            tbxInput.Multiline = true;
            tbxInput.Name = "tbxInput";
            tbxInput.Size = new Size(1207, 87);
            tbxInput.TabIndex = 0;
            tbxInput.TextChanged += tbxInput_TextChanged_1;
            // 
            // pnlInputTitle
            // 
            pnlInputTitle.Controls.Add(lblInput);
            pnlInputTitle.Controls.Add(rbtDecrypt);
            pnlInputTitle.Controls.Add(rbtEncrypt);
            pnlInputTitle.Dock = DockStyle.Top;
            pnlInputTitle.Location = new Point(0, 0);
            pnlInputTitle.Name = "pnlInputTitle";
            pnlInputTitle.Size = new Size(1207, 38);
            pnlInputTitle.TabIndex = 1;
            // 
            // lblInput
            // 
            lblInput.AutoSize = true;
            lblInput.Dock = DockStyle.Top;
            lblInput.Font = new Font("Segoe UI", 12F);
            lblInput.Location = new Point(0, 0);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(62, 28);
            lblInput.TabIndex = 6;
            lblInput.Text = "Input:";
            // 
            // rbtDecrypt
            // 
            rbtDecrypt.AutoSize = true;
            rbtDecrypt.Font = new Font("Segoe UI", 12F);
            rbtDecrypt.Location = new Point(367, 3);
            rbtDecrypt.Name = "rbtDecrypt";
            rbtDecrypt.Size = new Size(102, 32);
            rbtDecrypt.TabIndex = 5;
            rbtDecrypt.TabStop = true;
            rbtDecrypt.Text = "Decrypt";
            rbtDecrypt.UseVisualStyleBackColor = true;
            // 
            // rbtEncrypt
            // 
            rbtEncrypt.AutoSize = true;
            rbtEncrypt.Checked = true;
            rbtEncrypt.Font = new Font("Segoe UI", 12F);
            rbtEncrypt.Location = new Point(262, 3);
            rbtEncrypt.Name = "rbtEncrypt";
            rbtEncrypt.Size = new Size(99, 32);
            rbtEncrypt.TabIndex = 4;
            rbtEncrypt.TabStop = true;
            rbtEncrypt.Text = "Encrypt";
            rbtEncrypt.UseVisualStyleBackColor = true;
            // 
            // pnlOutput
            // 
            pnlOutput.Controls.Add(tbxOutput);
            pnlOutput.Controls.Add(pnlOutputTitle);
            pnlOutput.Dock = DockStyle.Top;
            pnlOutput.Location = new Point(0, 161);
            pnlOutput.Name = "pnlOutput";
            pnlOutput.Size = new Size(1207, 125);
            pnlOutput.TabIndex = 1;
            // 
            // tbxOutput
            // 
            tbxOutput.Dock = DockStyle.Fill;
            tbxOutput.Font = new Font("Segoe UI", 12F);
            tbxOutput.Location = new Point(0, 38);
            tbxOutput.Multiline = true;
            tbxOutput.Name = "tbxOutput";
            tbxOutput.ReadOnly = true;
            tbxOutput.Size = new Size(1207, 87);
            tbxOutput.TabIndex = 5;
            // 
            // pnlOutputTitle
            // 
            pnlOutputTitle.Controls.Add(lblOutput);
            pnlOutputTitle.Dock = DockStyle.Top;
            pnlOutputTitle.Location = new Point(0, 0);
            pnlOutputTitle.Name = "pnlOutputTitle";
            pnlOutputTitle.Size = new Size(1207, 38);
            pnlOutputTitle.TabIndex = 3;
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Dock = DockStyle.Top;
            lblOutput.Font = new Font("Segoe UI", 12F);
            lblOutput.Location = new Point(0, 0);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(79, 28);
            lblOutput.TabIndex = 6;
            lblOutput.Text = "Output:";
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 12F);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, propertiesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1207, 36);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { closeToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(56, 32);
            fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(145, 32);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // propertiesToolStripMenuItem
            // 
            propertiesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { configureToolStripMenuItem });
            propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            propertiesToolStripMenuItem.Size = new Size(115, 32);
            propertiesToolStripMenuItem.Text = "Properties";
            // 
            // configureToolStripMenuItem
            // 
            configureToolStripMenuItem.Name = "configureToolStripMenuItem";
            configureToolStripMenuItem.Size = new Size(184, 32);
            configureToolStripMenuItem.Text = "Configure";
            configureToolStripMenuItem.Click += configureToolStripMenuItem_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1207, 617);
            Controls.Add(pnlOutput);
            Controls.Add(pnlInput);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Main";
            Text = "Enigma Machine";
            pnlInput.ResumeLayout(false);
            pnlInputContent.ResumeLayout(false);
            pnlInputContent.PerformLayout();
            pnlInputTitle.ResumeLayout(false);
            pnlInputTitle.PerformLayout();
            pnlOutput.ResumeLayout(false);
            pnlOutput.PerformLayout();
            pnlOutputTitle.ResumeLayout(false);
            pnlOutputTitle.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlInput;
        private Panel pnlOutput;
        private RadioButton rbtDecrypt;
        private RadioButton rbtEncrypt;
        private Panel pnlInputContent;
        private Panel pnlInputTitle;
        private Label lblInput;
        private TextBox tbxOutput;
        private Panel pnlOutputTitle;
        private Label lblOutput;
        private TextBox tbxInput;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem propertiesToolStripMenuItem;
        private ToolStripMenuItem configureToolStripMenuItem;
    }
}