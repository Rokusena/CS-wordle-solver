namespace WindowsFormsApp6
{
    partial class Form1
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
            this.textBoxLetter1 = new System.Windows.Forms.TextBox();
            this.textBoxLetter2 = new System.Windows.Forms.TextBox();
            this.textBoxLetter3 = new System.Windows.Forms.TextBox();
            this.textBoxLetter4 = new System.Windows.Forms.TextBox();
            this.textBoxLetter5 = new System.Windows.Forms.TextBox();
            this.textBoxPastTryes = new System.Windows.Forms.TextBox();
            this.L1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxSolutions = new System.Windows.Forms.ListBox();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.buttonResset = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonL1C = new System.Windows.Forms.Button();
            this.buttonL5C = new System.Windows.Forms.Button();
            this.buttonL4C = new System.Windows.Forms.Button();
            this.buttonL3C = new System.Windows.Forms.Button();
            this.buttonL2C = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxLetter1
            // 
            this.textBoxLetter1.Location = new System.Drawing.Point(79, 38);
            this.textBoxLetter1.MaxLength = 1;
            this.textBoxLetter1.Name = "textBoxLetter1";
            this.textBoxLetter1.Size = new System.Drawing.Size(23, 20);
            this.textBoxLetter1.TabIndex = 0;
            this.textBoxLetter1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxLetter2
            // 
            this.textBoxLetter2.Location = new System.Drawing.Point(139, 38);
            this.textBoxLetter2.MaxLength = 1;
            this.textBoxLetter2.Name = "textBoxLetter2";
            this.textBoxLetter2.Size = new System.Drawing.Size(23, 20);
            this.textBoxLetter2.TabIndex = 1;
            // 
            // textBoxLetter3
            // 
            this.textBoxLetter3.Location = new System.Drawing.Point(195, 38);
            this.textBoxLetter3.MaxLength = 1;
            this.textBoxLetter3.Name = "textBoxLetter3";
            this.textBoxLetter3.Size = new System.Drawing.Size(23, 20);
            this.textBoxLetter3.TabIndex = 2;
            // 
            // textBoxLetter4
            // 
            this.textBoxLetter4.Location = new System.Drawing.Point(251, 38);
            this.textBoxLetter4.MaxLength = 1;
            this.textBoxLetter4.Name = "textBoxLetter4";
            this.textBoxLetter4.Size = new System.Drawing.Size(23, 20);
            this.textBoxLetter4.TabIndex = 3;
            // 
            // textBoxLetter5
            // 
            this.textBoxLetter5.Location = new System.Drawing.Point(304, 38);
            this.textBoxLetter5.MaxLength = 1;
            this.textBoxLetter5.Name = "textBoxLetter5";
            this.textBoxLetter5.Size = new System.Drawing.Size(23, 20);
            this.textBoxLetter5.TabIndex = 4;
            // 
            // textBoxPastTryes
            // 
            this.textBoxPastTryes.Location = new System.Drawing.Point(79, 167);
            this.textBoxPastTryes.Multiline = true;
            this.textBoxPastTryes.Name = "textBoxPastTryes";
            this.textBoxPastTryes.ReadOnly = true;
            this.textBoxPastTryes.Size = new System.Drawing.Size(240, 177);
            this.textBoxPastTryes.TabIndex = 5;
            // 
            // L1
            // 
            this.L1.AutoSize = true;
            this.L1.Location = new System.Drawing.Point(76, 19);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(19, 13);
            this.L1.TabIndex = 6;
            this.L1.Text = "L1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "L5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "L3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "L2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "L4";
            // 
            // listBoxSolutions
            // 
            this.listBoxSolutions.FormattingEnabled = true;
            this.listBoxSolutions.Location = new System.Drawing.Point(639, 145);
            this.listBoxSolutions.Name = "listBoxSolutions";
            this.listBoxSolutions.Size = new System.Drawing.Size(198, 407);
            this.listBoxSolutions.TabIndex = 11;
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(639, 74);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(118, 53);
            this.buttonCheck.TabIndex = 12;
            this.buttonCheck.Text = "Check";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // buttonResset
            // 
            this.buttonResset.Location = new System.Drawing.Point(763, 74);
            this.buttonResset.Name = "buttonResset";
            this.buttonResset.Size = new System.Drawing.Size(118, 53);
            this.buttonResset.TabIndex = 13;
            this.buttonResset.Text = "Resset";
            this.buttonResset.UseVisualStyleBackColor = true;
            this.buttonResset.Click += new System.EventHandler(this.buttonResset_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(636, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Posible answers left :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(744, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "0";
            // 
            // buttonL1C
            // 
            this.buttonL1C.Location = new System.Drawing.Point(79, 74);
            this.buttonL1C.Name = "buttonL1C";
            this.buttonL1C.Size = new System.Drawing.Size(23, 23);
            this.buttonL1C.TabIndex = 16;
            this.buttonL1C.UseVisualStyleBackColor = true;
            this.buttonL1C.Click += new System.EventHandler(this.buttonL1C_Click);
            // 
            // buttonL5C
            // 
            this.buttonL5C.Location = new System.Drawing.Point(304, 74);
            this.buttonL5C.Name = "buttonL5C";
            this.buttonL5C.Size = new System.Drawing.Size(23, 23);
            this.buttonL5C.TabIndex = 18;
            this.buttonL5C.UseVisualStyleBackColor = true;
            this.buttonL5C.Click += new System.EventHandler(this.buttonL5C_Click);
            // 
            // buttonL4C
            // 
            this.buttonL4C.Location = new System.Drawing.Point(251, 74);
            this.buttonL4C.Name = "buttonL4C";
            this.buttonL4C.Size = new System.Drawing.Size(23, 23);
            this.buttonL4C.TabIndex = 19;
            this.buttonL4C.UseVisualStyleBackColor = true;
            this.buttonL4C.Click += new System.EventHandler(this.buttonL4C_Click);
            // 
            // buttonL3C
            // 
            this.buttonL3C.Location = new System.Drawing.Point(195, 74);
            this.buttonL3C.Name = "buttonL3C";
            this.buttonL3C.Size = new System.Drawing.Size(23, 23);
            this.buttonL3C.TabIndex = 20;
            this.buttonL3C.UseVisualStyleBackColor = true;
            this.buttonL3C.Click += new System.EventHandler(this.buttonL3C_Click);
            // 
            // buttonL2C
            // 
            this.buttonL2C.Location = new System.Drawing.Point(139, 74);
            this.buttonL2C.Name = "buttonL2C";
            this.buttonL2C.Size = new System.Drawing.Size(23, 23);
            this.buttonL2C.TabIndex = 21;
            this.buttonL2C.UseVisualStyleBackColor = true;
            this.buttonL2C.Click += new System.EventHandler(this.buttonL2C_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "label7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 594);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonL2C);
            this.Controls.Add(this.buttonL3C);
            this.Controls.Add(this.buttonL4C);
            this.Controls.Add(this.buttonL5C);
            this.Controls.Add(this.buttonL1C);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonResset);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.listBoxSolutions);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.L1);
            this.Controls.Add(this.textBoxPastTryes);
            this.Controls.Add(this.textBoxLetter5);
            this.Controls.Add(this.textBoxLetter4);
            this.Controls.Add(this.textBoxLetter3);
            this.Controls.Add(this.textBoxLetter2);
            this.Controls.Add(this.textBoxLetter1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLetter1;
        private System.Windows.Forms.TextBox textBoxLetter2;
        private System.Windows.Forms.TextBox textBoxLetter3;
        private System.Windows.Forms.TextBox textBoxLetter4;
        private System.Windows.Forms.TextBox textBoxLetter5;
        private System.Windows.Forms.TextBox textBoxPastTryes;
        private System.Windows.Forms.Label L1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxSolutions;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Button buttonResset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonL1C;
        private System.Windows.Forms.Button buttonL5C;
        private System.Windows.Forms.Button buttonL4C;
        private System.Windows.Forms.Button buttonL3C;
        private System.Windows.Forms.Button buttonL2C;
        private System.Windows.Forms.Label label7;
    }
}

