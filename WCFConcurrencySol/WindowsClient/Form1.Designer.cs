namespace WindowsClient
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
            this.btnProdCateg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProdCateg
            // 
            this.btnProdCateg.Location = new System.Drawing.Point(48, 81);
            this.btnProdCateg.Name = "btnProdCateg";
            this.btnProdCateg.Size = new System.Drawing.Size(237, 35);
            this.btnProdCateg.TabIndex = 0;
            this.btnProdCateg.Text = "Add Product Category";
            this.btnProdCateg.UseVisualStyleBackColor = true;
            this.btnProdCateg.Click += new System.EventHandler(this.btnProdCateg_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 265);
            this.Controls.Add(this.btnProdCateg);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProdCateg;
    }
}

