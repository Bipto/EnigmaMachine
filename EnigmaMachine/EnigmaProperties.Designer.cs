namespace EnigmaMachine
{
    partial class EnigmaProperties
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
            lblProperties = new Label();
            pnlProperties = new Panel();
            dgvRotors = new DataGridView();
            lblRotors = new Label();
            btnAdd = new Button();
            btnSave = new Button();
            pnlProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRotors).BeginInit();
            SuspendLayout();
            // 
            // lblProperties
            // 
            lblProperties.AutoSize = true;
            lblProperties.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblProperties.Location = new Point(29, 9);
            lblProperties.Name = "lblProperties";
            lblProperties.Size = new Size(105, 28);
            lblProperties.TabIndex = 0;
            lblProperties.Text = "Properties:";
            // 
            // pnlProperties
            // 
            pnlProperties.Controls.Add(dgvRotors);
            pnlProperties.Location = new Point(29, 65);
            pnlProperties.Name = "pnlProperties";
            pnlProperties.Size = new Size(740, 193);
            pnlProperties.TabIndex = 1;
            // 
            // dgvRotors
            // 
            dgvRotors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRotors.Dock = DockStyle.Fill;
            dgvRotors.Location = new Point(0, 0);
            dgvRotors.Name = "dgvRotors";
            dgvRotors.RowHeadersWidth = 51;
            dgvRotors.RowTemplate.Height = 29;
            dgvRotors.Size = new Size(740, 193);
            dgvRotors.TabIndex = 0;
            // 
            // lblRotors
            // 
            lblRotors.AutoSize = true;
            lblRotors.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblRotors.Location = new Point(29, 37);
            lblRotors.Name = "lblRotors";
            lblRotors.Size = new Size(68, 25);
            lblRotors.TabIndex = 0;
            lblRotors.Text = "Rotors:";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(675, 273);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add New";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(694, 346);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // EnigmaProperties
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 387);
            Controls.Add(btnSave);
            Controls.Add(btnAdd);
            Controls.Add(lblRotors);
            Controls.Add(pnlProperties);
            Controls.Add(lblProperties);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "EnigmaProperties";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Enigma Properties";
            pnlProperties.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRotors).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProperties;
        private Panel pnlProperties;
        private Label lblRotors;
        private DataGridView dgvRotors;
        private Button btnAdd;
        private Button btnSave;
    }
}