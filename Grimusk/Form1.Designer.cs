namespace Grimusk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Data = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Instructions = new System.Windows.Forms.ListBox();
            this.btn_sum = new System.Windows.Forms.Button();
            this.btn_sub = new System.Windows.Forms.Button();
            this.btn_hlt = new System.Windows.Forms.Button();
            this.btn_mul = new System.Windows.Forms.Button();
            this.btn_pow = new System.Windows.Forms.Button();
            this.btn_sqr = new System.Windows.Forms.Button();
            this.Log = new System.Windows.Forms.ListBox();
            this.addr1 = new System.Windows.Forms.TextBox();
            this.addr2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_execute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Data
            // 
            this.Data.BackColor = System.Drawing.Color.LightGray;
            this.Data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Data.Font = new System.Drawing.Font("Lucida Console", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Data.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(10)))), ((int)(((byte)(19)))));
            this.Data.FormattingEnabled = true;
            this.Data.ItemHeight = 22;
            this.Data.Location = new System.Drawing.Point(12, 56);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(128, 244);
            this.Data.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(33, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(16, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Instruções";
            // 
            // Instructions
            // 
            this.Instructions.BackColor = System.Drawing.Color.LightGray;
            this.Instructions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Instructions.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Instructions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(10)))), ((int)(((byte)(19)))));
            this.Instructions.FormattingEnabled = true;
            this.Instructions.HorizontalScrollbar = true;
            this.Instructions.ItemHeight = 14;
            this.Instructions.Location = new System.Drawing.Point(12, 332);
            this.Instructions.Name = "Instructions";
            this.Instructions.Size = new System.Drawing.Size(128, 212);
            this.Instructions.TabIndex = 2;
            // 
            // btn_sum
            // 
            this.btn_sum.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_sum.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_sum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sum.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sum.Location = new System.Drawing.Point(155, 347);
            this.btn_sum.Name = "btn_sum";
            this.btn_sum.Size = new System.Drawing.Size(86, 44);
            this.btn_sum.TabIndex = 4;
            this.btn_sum.Text = "SUM";
            this.btn_sum.UseVisualStyleBackColor = false;
            this.btn_sum.Click += new System.EventHandler(this.btn_sum_Click);
            // 
            // btn_sub
            // 
            this.btn_sub.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_sub.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_sub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sub.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sub.Location = new System.Drawing.Point(155, 397);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(86, 44);
            this.btn_sub.TabIndex = 5;
            this.btn_sub.Text = "SUB";
            this.btn_sub.UseVisualStyleBackColor = false;
            // 
            // btn_hlt
            // 
            this.btn_hlt.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_hlt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_hlt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hlt.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hlt.Location = new System.Drawing.Point(155, 497);
            this.btn_hlt.Name = "btn_hlt";
            this.btn_hlt.Size = new System.Drawing.Size(86, 44);
            this.btn_hlt.TabIndex = 6;
            this.btn_hlt.Text = "HLT";
            this.btn_hlt.UseVisualStyleBackColor = false;
            // 
            // btn_mul
            // 
            this.btn_mul.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_mul.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_mul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mul.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mul.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_mul.Location = new System.Drawing.Point(155, 447);
            this.btn_mul.Name = "btn_mul";
            this.btn_mul.Size = new System.Drawing.Size(86, 44);
            this.btn_mul.TabIndex = 7;
            this.btn_mul.Text = "MUL";
            this.btn_mul.UseVisualStyleBackColor = false;
            // 
            // btn_pow
            // 
            this.btn_pow.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_pow.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_pow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pow.Font = new System.Drawing.Font("Arial", 32F);
            this.btn_pow.Location = new System.Drawing.Point(247, 347);
            this.btn_pow.Name = "btn_pow";
            this.btn_pow.Size = new System.Drawing.Size(144, 94);
            this.btn_pow.TabIndex = 8;
            this.btn_pow.Text = "POW";
            this.btn_pow.UseVisualStyleBackColor = false;
            // 
            // btn_sqr
            // 
            this.btn_sqr.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_sqr.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_sqr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sqr.Font = new System.Drawing.Font("Arial", 32F);
            this.btn_sqr.Location = new System.Drawing.Point(247, 447);
            this.btn_sqr.Name = "btn_sqr";
            this.btn_sqr.Size = new System.Drawing.Size(144, 94);
            this.btn_sqr.TabIndex = 9;
            this.btn_sqr.Text = "SQR";
            this.btn_sqr.UseVisualStyleBackColor = false;
            // 
            // Log
            // 
            this.Log.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Log.Font = new System.Drawing.Font("Consolas", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Log.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(10)))), ((int)(((byte)(19)))));
            this.Log.FormattingEnabled = true;
            this.Log.ItemHeight = 26;
            this.Log.Location = new System.Drawing.Point(397, 47);
            this.Log.Name = "Log";
            this.Log.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.Log.Size = new System.Drawing.Size(391, 494);
            this.Log.TabIndex = 10;
            // 
            // addr1
            // 
            this.addr1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.addr1.Location = new System.Drawing.Point(154, 309);
            this.addr1.Name = "addr1";
            this.addr1.Size = new System.Drawing.Size(109, 35);
            this.addr1.TabIndex = 11;
            // 
            // addr2
            // 
            this.addr2.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.addr2.Location = new System.Drawing.Point(278, 309);
            this.addr2.Name = "addr2";
            this.addr2.Size = new System.Drawing.Size(113, 35);
            this.addr2.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(167, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 28);
            this.label3.TabIndex = 13;
            this.label3.Text = "ADDR1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(293, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 28);
            this.label4.TabIndex = 14;
            this.label4.Text = "ADDR2";
            // 
            // btn_execute
            // 
            this.btn_execute.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_execute.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_execute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_execute.Font = new System.Drawing.Font("Arial", 32F);
            this.btn_execute.Location = new System.Drawing.Point(155, 220);
            this.btn_execute.Name = "btn_execute";
            this.btn_execute.Size = new System.Drawing.Size(236, 55);
            this.btn_execute.TabIndex = 15;
            this.btn_execute.Text = "Executar";
            this.btn_execute.UseVisualStyleBackColor = false;
            this.btn_execute.Click += new System.EventHandler(this.btn_execute_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(800, 566);
            this.Controls.Add(this.btn_execute);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addr2);
            this.Controls.Add(this.addr1);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.btn_sqr);
            this.Controls.Add(this.btn_pow);
            this.Controls.Add(this.btn_mul);
            this.Controls.Add(this.btn_hlt);
            this.Controls.Add(this.btn_sub);
            this.Controls.Add(this.btn_sum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Instructions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Data);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Grimusk";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_sum;
        private System.Windows.Forms.Button btn_sub;
        private System.Windows.Forms.Button btn_hlt;
        private System.Windows.Forms.Button btn_mul;
        private System.Windows.Forms.Button btn_pow;
        private System.Windows.Forms.Button btn_sqr;
        public System.Windows.Forms.ListBox Log;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ListBox Data;
        public System.Windows.Forms.ListBox Instructions;
        public System.Windows.Forms.TextBox addr1;
        public System.Windows.Forms.TextBox addr2;
        private System.Windows.Forms.Button btn_execute;
    }
}

