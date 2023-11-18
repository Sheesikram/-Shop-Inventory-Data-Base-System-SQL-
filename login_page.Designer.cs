
namespace final_project_DB
{
    partial class login_page
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
            this.label7 = new System.Windows.Forms.Label();
            this.fasih = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(219, 506);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(2, 265);
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 194);
            this.label2.Size = new System.Drawing.Size(152, 43);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 129);
            this.label1.Size = new System.Drawing.Size(188, 43);
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.fasih);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(219, 0);
            this.panel2.Size = new System.Drawing.Size(516, 506);
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(93, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 32);
            this.label7.TabIndex = 0;
            this.label7.Text = "Username";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // fasih
            // 
            this.fasih.Location = new System.Drawing.Point(269, 142);
            this.fasih.Multiline = true;
            this.fasih.Name = "fasih";
            this.fasih.Size = new System.Drawing.Size(131, 28);
            this.fasih.TabIndex = 2;
            this.fasih.TextChanged += new System.EventHandler(this.fasih_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(293, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(99, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 32);
            this.label6.TabIndex = 6;
            this.label6.Text = "password";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(269, 194);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 28);
            this.textBox1.TabIndex = 7;
            this.textBox1.UseSystemPasswordChar = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(171, 265);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 40);
            this.button4.TabIndex = 8;
            this.button4.Text = "reset";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // login_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(735, 506);
            this.Name = "login_page";
            this.Load += new System.EventHandler(this.login_page_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox fasih;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
    }
}