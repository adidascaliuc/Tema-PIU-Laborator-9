namespace MultipleForms
{
    partial class FormaDestinatie
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
            this.btnModifica = new System.Windows.Forms.Button();
            this.lblAfisare = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnModifica
            // 
            this.btnModifica.Location = new System.Drawing.Point(81, 130);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(75, 23);
            this.btnModifica.TabIndex = 0;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // lblAfisare
            // 
            this.lblAfisare.AutoSize = true;
            this.lblAfisare.Location = new System.Drawing.Point(81, 79);
            this.lblAfisare.Name = "lblAfisare";
            this.lblAfisare.Size = new System.Drawing.Size(0, 17);
            this.lblAfisare.TabIndex = 1;
            // 
            // FormaDestinatie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 253);
            this.Controls.Add(this.lblAfisare);
            this.Controls.Add(this.btnModifica);
            this.Location = new System.Drawing.Point(400, 0);
            this.Name = "FormaDestinatie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormaDestinatie";
            this.Load += new System.EventHandler(this.FormaDestinatie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Label lblAfisare;
    }
}