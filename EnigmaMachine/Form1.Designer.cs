namespace EnigmaMachine
{
    partial class Form1
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
            tbxInput = new TextBox();
            lblInputTitle = new Label();
            pnlOutput = new Panel();
            tbxOutput = new TextBox();
            lblOutputTitle = new Label();
            pnlProperties = new Panel();
            btnGenerate = new Button();
            lblPropertiesTitle = new Label();
            pnlInput.SuspendLayout();
            pnlOutput.SuspendLayout();
            pnlProperties.SuspendLayout();
            SuspendLayout();
            // 
            // pnlInput
            // 
            pnlInput.Controls.Add(tbxInput);
            pnlInput.Controls.Add(lblInputTitle);
            pnlInput.Dock = DockStyle.Top;
            pnlInput.Location = new Point(0, 0);
            pnlInput.Name = "pnlInput";
            pnlInput.Size = new Size(1207, 125);
            pnlInput.TabIndex = 0;
            // 
            // tbxInput
            // 
            tbxInput.Dock = DockStyle.Fill;
            tbxInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbxInput.Location = new Point(0, 28);
            tbxInput.Multiline = true;
            tbxInput.Name = "tbxInput";
            tbxInput.Size = new Size(1207, 97);
            tbxInput.TabIndex = 1;
            // 
            // lblInputTitle
            // 
            lblInputTitle.AutoSize = true;
            lblInputTitle.Dock = DockStyle.Top;
            lblInputTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblInputTitle.Location = new Point(0, 0);
            lblInputTitle.Name = "lblInputTitle";
            lblInputTitle.Size = new Size(62, 28);
            lblInputTitle.TabIndex = 0;
            lblInputTitle.Text = "Input:";
            // 
            // pnlOutput
            // 
            pnlOutput.Controls.Add(tbxOutput);
            pnlOutput.Controls.Add(lblOutputTitle);
            pnlOutput.Dock = DockStyle.Top;
            pnlOutput.Location = new Point(0, 125);
            pnlOutput.Name = "pnlOutput";
            pnlOutput.Size = new Size(1207, 125);
            pnlOutput.TabIndex = 1;
            // 
            // tbxOutput
            // 
            tbxOutput.Dock = DockStyle.Fill;
            tbxOutput.Enabled = false;
            tbxOutput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbxOutput.Location = new Point(0, 28);
            tbxOutput.Multiline = true;
            tbxOutput.Name = "tbxOutput";
            tbxOutput.Size = new Size(1207, 97);
            tbxOutput.TabIndex = 3;
            // 
            // lblOutputTitle
            // 
            lblOutputTitle.AutoSize = true;
            lblOutputTitle.Dock = DockStyle.Top;
            lblOutputTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblOutputTitle.Location = new Point(0, 0);
            lblOutputTitle.Name = "lblOutputTitle";
            lblOutputTitle.Size = new Size(79, 28);
            lblOutputTitle.TabIndex = 2;
            lblOutputTitle.Text = "Output:";
            // 
            // pnlProperties
            // 
            pnlProperties.Controls.Add(btnGenerate);
            pnlProperties.Controls.Add(lblPropertiesTitle);
            pnlProperties.Dock = DockStyle.Top;
            pnlProperties.Location = new Point(0, 250);
            pnlProperties.Name = "pnlProperties";
            pnlProperties.Size = new Size(1207, 125);
            pnlProperties.TabIndex = 2;
            // 
            // btnGenerate
            // 
            btnGenerate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGenerate.Location = new Point(3, 31);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(145, 43);
            btnGenerate.TabIndex = 3;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // lblPropertiesTitle
            // 
            lblPropertiesTitle.AutoSize = true;
            lblPropertiesTitle.Dock = DockStyle.Top;
            lblPropertiesTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPropertiesTitle.Location = new Point(0, 0);
            lblPropertiesTitle.Name = "lblPropertiesTitle";
            lblPropertiesTitle.Size = new Size(101, 28);
            lblPropertiesTitle.TabIndex = 2;
            lblPropertiesTitle.Text = "Properties";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1207, 617);
            Controls.Add(pnlProperties);
            Controls.Add(pnlOutput);
            Controls.Add(pnlInput);
            Name = "Form1";
            Text = "Form1";
            pnlInput.ResumeLayout(false);
            pnlInput.PerformLayout();
            pnlOutput.ResumeLayout(false);
            pnlOutput.PerformLayout();
            pnlProperties.ResumeLayout(false);
            pnlProperties.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlInput;
        private TextBox tbxInput;
        private Label lblInputTitle;
        private Panel pnlOutput;
        private TextBox tbxOutput;
        private Label lblOutputTitle;
        private Panel pnlProperties;
        private Button btnGenerate;
        private Label lblPropertiesTitle;
    }
}