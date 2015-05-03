namespace Slump
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
            this.btnSlumpa = new System.Windows.Forms.Button();
            this.btnSpecifik = new System.Windows.Forms.Button();
            this.txtRadnummer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnÖppnaFil = new System.Windows.Forms.Button();
            this.txtSökväg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstTidigareSlag = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnSlumpa
            // 
            this.btnSlumpa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSlumpa.Location = new System.Drawing.Point(371, 78);
            this.btnSlumpa.Name = "btnSlumpa";
            this.btnSlumpa.Size = new System.Drawing.Size(75, 23);
            this.btnSlumpa.TabIndex = 0;
            this.btnSlumpa.Text = "Slumpa";
            this.btnSlumpa.UseVisualStyleBackColor = true;
            this.btnSlumpa.Click += new System.EventHandler(this.btnSlumpa_Click);
            // 
            // btnSpecifik
            // 
            this.btnSpecifik.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSpecifik.Location = new System.Drawing.Point(290, 78);
            this.btnSpecifik.Name = "btnSpecifik";
            this.btnSpecifik.Size = new System.Drawing.Size(75, 23);
            this.btnSpecifik.TabIndex = 1;
            this.btnSpecifik.Text = "Gå till";
            this.btnSpecifik.UseVisualStyleBackColor = true;
            this.btnSpecifik.Click += new System.EventHandler(this.btnSpecifik_Click);
            // 
            // txtRadnummer
            // 
            this.txtRadnummer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRadnummer.Location = new System.Drawing.Point(12, 81);
            this.txtRadnummer.Name = "txtRadnummer";
            this.txtRadnummer.Size = new System.Drawing.Size(272, 20);
            this.txtRadnummer.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnÖppnaFil
            // 
            this.btnÖppnaFil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnÖppnaFil.Location = new System.Drawing.Point(369, 16);
            this.btnÖppnaFil.Name = "btnÖppnaFil";
            this.btnÖppnaFil.Size = new System.Drawing.Size(75, 23);
            this.btnÖppnaFil.TabIndex = 4;
            this.btnÖppnaFil.Text = "Öppna fil";
            this.btnÖppnaFil.UseVisualStyleBackColor = true;
            this.btnÖppnaFil.Click += new System.EventHandler(this.btnÖppnaFil_Click);
            // 
            // txtSökväg
            // 
            this.txtSökväg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSökväg.Location = new System.Drawing.Point(12, 19);
            this.txtSökväg.Name = "txtSökväg";
            this.txtSökväg.ReadOnly = true;
            this.txtSökväg.Size = new System.Drawing.Size(351, 20);
            this.txtSökväg.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Rad nummer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Resultat";
            // 
            // lstTidigareSlag
            // 
            this.lstTidigareSlag.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstTidigareSlag.FormattingEnabled = true;
            this.lstTidigareSlag.Location = new System.Drawing.Point(12, 121);
            this.lstTidigareSlag.Name = "lstTidigareSlag";
            this.lstTidigareSlag.Size = new System.Drawing.Size(432, 199);
            this.lstTidigareSlag.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 338);
            this.Controls.Add(this.lstTidigareSlag);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSökväg);
            this.Controls.Add(this.btnÖppnaFil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRadnummer);
            this.Controls.Add(this.btnSpecifik);
            this.Controls.Add(this.btnSlumpa);
            this.Name = "Form1";
            this.Text = "Slumpprogram";            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSlumpa;
        private System.Windows.Forms.Button btnSpecifik;
        private System.Windows.Forms.TextBox txtRadnummer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnÖppnaFil;
        private System.Windows.Forms.TextBox txtSökväg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstTidigareSlag;
    }
}

