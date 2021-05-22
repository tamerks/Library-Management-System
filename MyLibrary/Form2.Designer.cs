
namespace MyLibrary
{
    partial class Form2
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.page11 = new MyLibrary.Page1();
            this.page31 = new MyLibrary.Page3();
            this.page21 = new MyLibrary.Page2();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(172, 450);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "My Library";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 74);
            this.button2.TabIndex = 0;
            this.button2.Text = "Publisher";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 266);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(172, 74);
            this.button3.TabIndex = 2;
            this.button3.Text = "Author";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 74);
            this.button1.TabIndex = 0;
            this.button1.Text = "Book";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.page21);
            this.panel1.Controls.Add(this.page31);
            this.panel1.Controls.Add(this.page11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(172, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 450);
            this.panel1.TabIndex = 2;
            // 
            // page11
            // 
            this.page11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.page11.Location = new System.Drawing.Point(0, 0);
            this.page11.Name = "page11";
            this.page11.Size = new System.Drawing.Size(628, 450);
            this.page11.TabIndex = 0;
            this.page11.Load += new System.EventHandler(this.page11_Load);
            // 
            // page31
            // 
            this.page31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.page31.Location = new System.Drawing.Point(0, 0);
            this.page31.Name = "page31";
            this.page31.Size = new System.Drawing.Size(628, 450);
            this.page31.TabIndex = 1;
            // 
            // page21
            // 
            this.page21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.page21.Location = new System.Drawing.Point(0, 0);
            this.page21.Name = "page21";
            this.page21.Size = new System.Drawing.Size(628, 450);
            this.page21.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private Page1 page11;
        private Page2 page21;
        private Page3 page31;
    }
}