namespace MultipleForms
{
    partial class FormaSursa
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
            this.btnTrimite = new System.Windows.Forms.Button();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTrimite
            // 
            this.btnTrimite.Location = new System.Drawing.Point(52, 149);
            this.btnTrimite.Name = "btnTrimite";
            this.btnTrimite.Size = new System.Drawing.Size(75, 23);
            this.btnTrimite.TabIndex = 5;
            this.btnTrimite.Text = "Trimite";
            this.btnTrimite.UseVisualStyleBackColor = true;
            this.btnTrimite.Click += new System.EventHandler(this.btnTrimite_Click);
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(52, 87);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(239, 22);
            this.txtNume.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nume";
            // 
            // FormaSursa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 253);
            this.Controls.Add(this.btnTrimite);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.label1);
            this.Name = "FormaSursa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormaSursa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTrimite;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Label label1;
    }
}

