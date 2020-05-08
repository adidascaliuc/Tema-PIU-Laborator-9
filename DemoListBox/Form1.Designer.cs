namespace DemoListe
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
            this.btnAdauga = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lstNume = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSterge = new System.Windows.Forms.Button();
            this.cmbNume = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(140, 57);
            this.btnAdauga.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(56, 28);
            this.btnAdauga.TabIndex = 2;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lista nume";
            // 
            // lstNume
            // 
            this.lstNume.FormattingEnabled = true;
            this.lstNume.Location = new System.Drawing.Point(222, 57);
            this.lstNume.Margin = new System.Windows.Forms.Padding(2);
            this.lstNume.Name = "lstNume";
            this.lstNume.Size = new System.Drawing.Size(91, 69);
            this.lstNume.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduceti un nume";
            // 
            // btnSterge
            // 
            this.btnSterge.Location = new System.Drawing.Point(140, 103);
            this.btnSterge.Margin = new System.Windows.Forms.Padding(2);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(56, 23);
            this.btnSterge.TabIndex = 5;
            this.btnSterge.Text = "Sterge";
            this.btnSterge.UseVisualStyleBackColor = true;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // cmbNume
            // 
            this.cmbNume.FormattingEnabled = true;
            this.cmbNume.Items.AddRange(new object[] {
            "Adi",
            "Marcel",
            "Vasile",
            "Gheorghe"});
            this.cmbNume.Location = new System.Drawing.Point(21, 57);
            this.cmbNume.Name = "cmbNume";
            this.cmbNume.Size = new System.Drawing.Size(95, 21);
            this.cmbNume.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 179);
            this.Controls.Add(this.cmbNume);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstNume);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "DemoListe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstNume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.ComboBox cmbNume;
    }
}

