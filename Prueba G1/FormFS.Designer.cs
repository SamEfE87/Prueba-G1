namespace Prueba_G1
{
    partial class FormFS
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
            this.buttonVolverFS = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonVolverFS
            // 
            this.buttonVolverFS.Location = new System.Drawing.Point(230, 210);
            this.buttonVolverFS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonVolverFS.Name = "buttonVolverFS";
            this.buttonVolverFS.Size = new System.Drawing.Size(125, 54);
            this.buttonVolverFS.TabIndex = 0;
            this.buttonVolverFS.Text = "Volver";
            this.buttonVolverFS.UseVisualStyleBackColor = true;
            this.buttonVolverFS.Click += new System.EventHandler(this.buttonVolverFS_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fuera de Servicio";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormFS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonVolverFS);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormFS";
            this.Text = "FormFS";
            this.Load += new System.EventHandler(this.FormFS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonVolverFS;
        private System.Windows.Forms.Label label1;
    }
}