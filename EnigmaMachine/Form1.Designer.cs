
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
            this.LblRotor = new System.Windows.Forms.Label();
            this.CbxRotor1 = new System.Windows.Forms.ComboBox();
            this.CbxRotor2 = new System.Windows.Forms.ComboBox();
            this.CbxRotor3 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblStartPos = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CbxStartPos1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CbxStartPos2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CbxStartPos3 = new System.Windows.Forms.ComboBox();
            this.RtbContent = new System.Windows.Forms.RichTextBox();
            this.RtbOutput = new System.Windows.Forms.RichTextBox();
            this.BtnEncode = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblRotor
            // 
            this.LblRotor.AutoSize = true;
            this.LblRotor.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblRotor.Location = new System.Drawing.Point(154, 37);
            this.LblRotor.Name = "LblRotor";
            this.LblRotor.Size = new System.Drawing.Size(82, 23);
            this.LblRotor.TabIndex = 0;
            this.LblRotor.Text = "Rotors";
            // 
            // CbxRotor1
            // 
            this.CbxRotor1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxRotor1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CbxRotor1.FormattingEnabled = true;
            this.CbxRotor1.Items.AddRange(new object[] {
            "I",
            "II",
            "III",
            "IV",
            "V",
            "VI",
            "VII",
            "VIII"});
            this.CbxRotor1.Location = new System.Drawing.Point(336, 34);
            this.CbxRotor1.Name = "CbxRotor1";
            this.CbxRotor1.Size = new System.Drawing.Size(151, 31);
            this.CbxRotor1.TabIndex = 1;
            this.CbxRotor1.SelectedIndexChanged += new System.EventHandler(this.CbxRotor1_SelectedIndexChanged);
            // 
            // CbxRotor2
            // 
            this.CbxRotor2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxRotor2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CbxRotor2.FormattingEnabled = true;
            this.CbxRotor2.Items.AddRange(new object[] {
            "I",
            "II",
            "III",
            "IV",
            "V",
            "VI",
            "VII",
            "VIII"});
            this.CbxRotor2.Location = new System.Drawing.Point(546, 34);
            this.CbxRotor2.Name = "CbxRotor2";
            this.CbxRotor2.Size = new System.Drawing.Size(151, 31);
            this.CbxRotor2.TabIndex = 2;
            this.CbxRotor2.SelectedIndexChanged += new System.EventHandler(this.CbxRotor2_SelectedIndexChanged);
            // 
            // CbxRotor3
            // 
            this.CbxRotor3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxRotor3.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CbxRotor3.FormattingEnabled = true;
            this.CbxRotor3.Items.AddRange(new object[] {
            "I",
            "II",
            "III",
            "IV",
            "V",
            "VI",
            "VII",
            "VIII"});
            this.CbxRotor3.Location = new System.Drawing.Point(758, 34);
            this.CbxRotor3.Name = "CbxRotor3";
            this.CbxRotor3.Size = new System.Drawing.Size(151, 31);
            this.CbxRotor3.TabIndex = 3;
            this.CbxRotor3.SelectedIndexChanged += new System.EventHandler(this.CbxRotor3_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(296, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "1.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(506, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "2.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(718, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "3.";
            // 
            // LblStartPos
            // 
            this.LblStartPos.AutoSize = true;
            this.LblStartPos.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblStartPos.Location = new System.Drawing.Point(22, 86);
            this.LblStartPos.Name = "LblStartPos";
            this.LblStartPos.Size = new System.Drawing.Size(214, 23);
            this.LblStartPos.TabIndex = 7;
            this.LblStartPos.Text = "Starting Position";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(296, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "1.";
            // 
            // CbxStartPos1
            // 
            this.CbxStartPos1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxStartPos1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CbxStartPos1.FormattingEnabled = true;
            this.CbxStartPos1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26"});
            this.CbxStartPos1.Location = new System.Drawing.Point(336, 83);
            this.CbxStartPos1.Name = "CbxStartPos1";
            this.CbxStartPos1.Size = new System.Drawing.Size(151, 31);
            this.CbxStartPos1.TabIndex = 8;
            this.CbxStartPos1.SelectedIndexChanged += new System.EventHandler(this.CbxStartPos1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(506, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "2.";
            // 
            // CbxStartPos2
            // 
            this.CbxStartPos2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxStartPos2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CbxStartPos2.FormattingEnabled = true;
            this.CbxStartPos2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26"});
            this.CbxStartPos2.Location = new System.Drawing.Point(546, 83);
            this.CbxStartPos2.Name = "CbxStartPos2";
            this.CbxStartPos2.Size = new System.Drawing.Size(151, 31);
            this.CbxStartPos2.TabIndex = 10;
            this.CbxStartPos2.SelectedIndexChanged += new System.EventHandler(this.CbxStartPos2_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(718, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "3.";
            // 
            // CbxStartPos3
            // 
            this.CbxStartPos3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxStartPos3.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CbxStartPos3.FormattingEnabled = true;
            this.CbxStartPos3.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26"});
            this.CbxStartPos3.Location = new System.Drawing.Point(758, 83);
            this.CbxStartPos3.Name = "CbxStartPos3";
            this.CbxStartPos3.Size = new System.Drawing.Size(151, 31);
            this.CbxStartPos3.TabIndex = 12;
            this.CbxStartPos3.SelectedIndexChanged += new System.EventHandler(this.CbxStartPos3_SelectedIndexChanged);
            // 
            // RtbContent
            // 
            this.RtbContent.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RtbContent.Location = new System.Drawing.Point(51, 186);
            this.RtbContent.Name = "RtbContent";
            this.RtbContent.Size = new System.Drawing.Size(398, 157);
            this.RtbContent.TabIndex = 15;
            this.RtbContent.Text = "";
            // 
            // RtbOutput
            // 
            this.RtbOutput.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RtbOutput.Location = new System.Drawing.Point(478, 186);
            this.RtbOutput.Name = "RtbOutput";
            this.RtbOutput.Size = new System.Drawing.Size(398, 157);
            this.RtbOutput.TabIndex = 16;
            this.RtbOutput.Text = "";
            // 
            // BtnEncode
            // 
            this.BtnEncode.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnEncode.Location = new System.Drawing.Point(735, 370);
            this.BtnEncode.Name = "BtnEncode";
            this.BtnEncode.Size = new System.Drawing.Size(132, 39);
            this.BtnEncode.TabIndex = 17;
            this.BtnEncode.Text = "Encode";
            this.BtnEncode.UseVisualStyleBackColor = true;
            this.BtnEncode.Click += new System.EventHandler(this.BtnEncode_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnReset.Location = new System.Drawing.Point(574, 370);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(132, 39);
            this.BtnReset.TabIndex = 18;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 431);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnEncode);
            this.Controls.Add(this.RtbOutput);
            this.Controls.Add(this.RtbContent);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CbxStartPos3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CbxStartPos2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CbxStartPos1);
            this.Controls.Add(this.LblStartPos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbxRotor3);
            this.Controls.Add(this.CbxRotor2);
            this.Controls.Add(this.CbxRotor1);
            this.Controls.Add(this.LblRotor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblRotor;
        private System.Windows.Forms.ComboBox CbxRotor1;
        private System.Windows.Forms.ComboBox CbxRotor2;
        private System.Windows.Forms.ComboBox CbxRotor3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblStartPos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CbxStartPos1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CbxStartPos2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CbxStartPos3;
        private System.Windows.Forms.RichTextBox RtbContent;
        private System.Windows.Forms.RichTextBox RtbOutput;
        private System.Windows.Forms.Button BtnEncode;
        private System.Windows.Forms.Button BtnReset;
    }
}

