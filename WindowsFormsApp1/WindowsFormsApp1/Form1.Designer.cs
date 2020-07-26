namespace WindowsFormsApp1
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
            this.btnBrowse1 = new System.Windows.Forms.Button();
            this.btnBrowse2 = new System.Windows.Forms.Button();
            this.txtPath1 = new System.Windows.Forms.TextBox();
            this.txtPath2 = new System.Windows.Forms.TextBox();
            this.txtDiff = new System.Windows.Forms.TextBox();
            this.btnDiff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBrowse1
            // 
            this.btnBrowse1.Location = new System.Drawing.Point(309, 138);
            this.btnBrowse1.Name = "btnBrowse1";
            this.btnBrowse1.Size = new System.Drawing.Size(84, 23);
            this.btnBrowse1.TabIndex = 0;
            this.btnBrowse1.Text = "File 1";
            this.btnBrowse1.UseVisualStyleBackColor = true;
            this.btnBrowse1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBrowse2
            // 
            this.btnBrowse2.Location = new System.Drawing.Point(309, 192);
            this.btnBrowse2.Name = "btnBrowse2";
            this.btnBrowse2.Size = new System.Drawing.Size(84, 23);
            this.btnBrowse2.TabIndex = 1;
            this.btnBrowse2.Text = "File 2";
            this.btnBrowse2.UseVisualStyleBackColor = true;
            this.btnBrowse2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtPath1
            // 
            this.txtPath1.Location = new System.Drawing.Point(44, 139);
            this.txtPath1.Name = "txtPath1";
            this.txtPath1.Size = new System.Drawing.Size(231, 22);
            this.txtPath1.TabIndex = 2;
            this.txtPath1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtPath2
            // 
            this.txtPath2.Location = new System.Drawing.Point(44, 192);
            this.txtPath2.Name = "txtPath2";
            this.txtPath2.Size = new System.Drawing.Size(231, 22);
            this.txtPath2.TabIndex = 3;
            this.txtPath2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtDiff
            // 
            this.txtDiff.Location = new System.Drawing.Point(44, 245);
            this.txtDiff.Name = "txtDiff";
            this.txtDiff.Size = new System.Drawing.Size(231, 22);
            this.txtDiff.TabIndex = 4;
            this.txtDiff.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnDiff
            // 
            this.btnDiff.Location = new System.Drawing.Point(309, 244);
            this.btnDiff.Name = "btnDiff";
            this.btnDiff.Size = new System.Drawing.Size(84, 23);
            this.btnDiff.TabIndex = 5;
            this.btnDiff.Text = "Difference";
            this.btnDiff.UseVisualStyleBackColor = true;
            this.btnBrowse2.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDiff);
            this.Controls.Add(this.txtDiff);
            this.Controls.Add(this.txtPath2);
            this.Controls.Add(this.txtPath1);
            this.Controls.Add(this.btnBrowse2);
            this.Controls.Add(this.btnBrowse1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse1;
        private System.Windows.Forms.Button btnBrowse2;
        private System.Windows.Forms.TextBox txtPath1;
        private System.Windows.Forms.TextBox txtPath2;
        private System.Windows.Forms.TextBox txtDiff;
        private System.Windows.Forms.Button btnDiff;
    }
}

