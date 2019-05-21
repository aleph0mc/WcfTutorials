namespace WinFormClient1
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnWsAdd = new System.Windows.Forms.Button();
            this.btnWsSubtract = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnNtAdd = new System.Windows.Forms.Button();
            this.btnNtSubtract = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Result";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Number 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Number 1";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(161, 115);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(100, 20);
            this.txtResult.TabIndex = 20;
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(161, 89);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(100, 20);
            this.txtNumber2.TabIndex = 19;
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(161, 58);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(100, 20);
            this.txtNumber1.TabIndex = 18;
            // 
            // btnSubtract
            // 
            this.btnSubtract.Location = new System.Drawing.Point(118, 19);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(75, 23);
            this.btnSubtract.TabIndex = 17;
            this.btnSubtract.Text = "Subtract";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(14, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnSubtract);
            this.groupBox1.Location = new System.Drawing.Point(68, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 65);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BasicHttpBinding";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnWsAdd);
            this.groupBox2.Controls.Add(this.btnWsSubtract);
            this.groupBox2.Location = new System.Drawing.Point(68, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 65);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "WsHttpBinding";
            // 
            // btnWsAdd
            // 
            this.btnWsAdd.Location = new System.Drawing.Point(14, 19);
            this.btnWsAdd.Name = "btnWsAdd";
            this.btnWsAdd.Size = new System.Drawing.Size(75, 23);
            this.btnWsAdd.TabIndex = 16;
            this.btnWsAdd.Text = "Add";
            this.btnWsAdd.UseVisualStyleBackColor = true;
            this.btnWsAdd.Click += new System.EventHandler(this.btnWsAdd_Click);
            // 
            // btnWsSubtract
            // 
            this.btnWsSubtract.Location = new System.Drawing.Point(118, 19);
            this.btnWsSubtract.Name = "btnWsSubtract";
            this.btnWsSubtract.Size = new System.Drawing.Size(75, 23);
            this.btnWsSubtract.TabIndex = 17;
            this.btnWsSubtract.Text = "Subtract";
            this.btnWsSubtract.UseVisualStyleBackColor = true;
            this.btnWsSubtract.Click += new System.EventHandler(this.btnWsSubtract_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnNtAdd);
            this.groupBox3.Controls.Add(this.btnNtSubtract);
            this.groupBox3.Location = new System.Drawing.Point(68, 300);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(214, 65);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "NetHttpBinding";
            // 
            // btnNtAdd
            // 
            this.btnNtAdd.Location = new System.Drawing.Point(14, 19);
            this.btnNtAdd.Name = "btnNtAdd";
            this.btnNtAdd.Size = new System.Drawing.Size(75, 23);
            this.btnNtAdd.TabIndex = 16;
            this.btnNtAdd.Text = "Add";
            this.btnNtAdd.UseVisualStyleBackColor = true;
            this.btnNtAdd.Click += new System.EventHandler(this.btnNtAdd_Click);
            // 
            // btnNtSubtract
            // 
            this.btnNtSubtract.Location = new System.Drawing.Point(118, 19);
            this.btnNtSubtract.Name = "btnNtSubtract";
            this.btnNtSubtract.Size = new System.Drawing.Size(75, 23);
            this.btnNtSubtract.TabIndex = 17;
            this.btnNtSubtract.Text = "Subtract";
            this.btnNtSubtract.UseVisualStyleBackColor = true;
            this.btnNtSubtract.Click += new System.EventHandler(this.btnNtSubtract_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 377);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.txtNumber1);
            this.Name = "Form1";
            this.Text = "net.tcp://localhost:6666/MathService";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnWsAdd;
        private System.Windows.Forms.Button btnWsSubtract;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnNtAdd;
        private System.Windows.Forms.Button btnNtSubtract;
    }
}

