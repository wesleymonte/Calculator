namespace Calculadora
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
            this.text_Num1 = new System.Windows.Forms.TextBox();
            this.text_Num2 = new System.Windows.Forms.TextBox();
            this.lbl_num1 = new System.Windows.Forms.Label();
            this.bt_plus = new System.Windows.Forms.Button();
            this.bt_minus = new System.Windows.Forms.Button();
            this.bt_mult = new System.Windows.Forms.Button();
            this.bt_div = new System.Windows.Forms.Button();
            this.lbl_num2 = new System.Windows.Forms.Label();
            this.lbl_result2 = new System.Windows.Forms.Label();
            this.lbl_result = new System.Windows.Forms.Label();
            this.bt_sqrt = new System.Windows.Forms.Button();
            this.bt_log = new System.Windows.Forms.Button();
            this.bt_clear2 = new System.Windows.Forms.Button();
            this.bt_clear = new System.Windows.Forms.Button();
            this.bt_sin = new System.Windows.Forms.Button();
            this.bt_cos = new System.Windows.Forms.Button();
            this.bt_tan = new System.Windows.Forms.Button();
            this.bt_xry = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // text_Num1
            // 
            this.text_Num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Num1.Location = new System.Drawing.Point(25, 50);
            this.text_Num1.Name = "text_Num1";
            this.text_Num1.Size = new System.Drawing.Size(215, 31);
            this.text_Num1.TabIndex = 0;
            this.text_Num1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // text_Num2
            // 
            this.text_Num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Num2.Location = new System.Drawing.Point(259, 50);
            this.text_Num2.Name = "text_Num2";
            this.text_Num2.Size = new System.Drawing.Size(215, 31);
            this.text_Num2.TabIndex = 1;
            this.text_Num2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lbl_num1
            // 
            this.lbl_num1.AutoSize = true;
            this.lbl_num1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_num1.Location = new System.Drawing.Point(21, 13);
            this.lbl_num1.Name = "lbl_num1";
            this.lbl_num1.Size = new System.Drawing.Size(129, 33);
            this.lbl_num1.TabIndex = 3;
            this.lbl_num1.Text = "Number 1";
            // 
            // bt_plus
            // 
            this.bt_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_plus.Location = new System.Drawing.Point(409, 99);
            this.bt_plus.Name = "bt_plus";
            this.bt_plus.Size = new System.Drawing.Size(113, 102);
            this.bt_plus.TabIndex = 6;
            this.bt_plus.Text = "+";
            this.bt_plus.UseVisualStyleBackColor = true;
            this.bt_plus.Click += new System.EventHandler(this.bt_plus_Click_1);
            // 
            // bt_minus
            // 
            this.bt_minus.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_minus.Location = new System.Drawing.Point(601, 100);
            this.bt_minus.Name = "bt_minus";
            this.bt_minus.Size = new System.Drawing.Size(113, 102);
            this.bt_minus.TabIndex = 7;
            this.bt_minus.Text = "-";
            this.bt_minus.UseVisualStyleBackColor = true;
            this.bt_minus.Click += new System.EventHandler(this.bt_minus_Click);
            // 
            // bt_mult
            // 
            this.bt_mult.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_mult.Location = new System.Drawing.Point(27, 245);
            this.bt_mult.Name = "bt_mult";
            this.bt_mult.Size = new System.Drawing.Size(113, 102);
            this.bt_mult.TabIndex = 8;
            this.bt_mult.Text = "x";
            this.bt_mult.UseVisualStyleBackColor = true;
            this.bt_mult.Click += new System.EventHandler(this.bt_mult_Click);
            // 
            // bt_div
            // 
            this.bt_div.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_div.Location = new System.Drawing.Point(217, 245);
            this.bt_div.Name = "bt_div";
            this.bt_div.Size = new System.Drawing.Size(113, 102);
            this.bt_div.TabIndex = 9;
            this.bt_div.Text = "/";
            this.bt_div.UseVisualStyleBackColor = true;
            this.bt_div.Click += new System.EventHandler(this.bt_div_Click);
            // 
            // lbl_num2
            // 
            this.lbl_num2.AutoSize = true;
            this.lbl_num2.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_num2.Location = new System.Drawing.Point(253, 13);
            this.lbl_num2.Name = "lbl_num2";
            this.lbl_num2.Size = new System.Drawing.Size(129, 33);
            this.lbl_num2.TabIndex = 10;
            this.lbl_num2.Text = "Number 2";
            // 
            // lbl_result2
            // 
            this.lbl_result2.AutoSize = true;
            this.lbl_result2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_result2.Location = new System.Drawing.Point(522, 55);
            this.lbl_result2.Name = "lbl_result2";
            this.lbl_result2.Size = new System.Drawing.Size(0, 25);
            this.lbl_result2.TabIndex = 11;
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_result.Location = new System.Drawing.Point(521, 13);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(88, 33);
            this.lbl_result.TabIndex = 12;
            this.lbl_result.Text = "Result";
            // 
            // bt_sqrt
            // 
            this.bt_sqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sqrt.Location = new System.Drawing.Point(409, 245);
            this.bt_sqrt.Name = "bt_sqrt";
            this.bt_sqrt.Size = new System.Drawing.Size(113, 102);
            this.bt_sqrt.TabIndex = 13;
            this.bt_sqrt.Text = "√";
            this.bt_sqrt.UseVisualStyleBackColor = true;
            this.bt_sqrt.Click += new System.EventHandler(this.bt_sqrt_Click);
            // 
            // bt_log
            // 
            this.bt_log.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_log.Location = new System.Drawing.Point(601, 248);
            this.bt_log.Name = "bt_log";
            this.bt_log.Size = new System.Drawing.Size(113, 102);
            this.bt_log.TabIndex = 14;
            this.bt_log.Text = "Log";
            this.bt_log.UseVisualStyleBackColor = true;
            this.bt_log.Click += new System.EventHandler(this.bt_log_Click);
            // 
            // bt_clear2
            // 
            this.bt_clear2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_clear2.Location = new System.Drawing.Point(217, 99);
            this.bt_clear2.Name = "bt_clear2";
            this.bt_clear2.Size = new System.Drawing.Size(113, 102);
            this.bt_clear2.TabIndex = 15;
            this.bt_clear2.Text = "Ce";
            this.bt_clear2.UseVisualStyleBackColor = true;
            this.bt_clear2.Click += new System.EventHandler(this.bt_clear2_Click);
            // 
            // bt_clear
            // 
            this.bt_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_clear.Location = new System.Drawing.Point(27, 100);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(113, 102);
            this.bt_clear.TabIndex = 16;
            this.bt_clear.Text = "C";
            this.bt_clear.UseVisualStyleBackColor = true;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // bt_sin
            // 
            this.bt_sin.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sin.Location = new System.Drawing.Point(217, 390);
            this.bt_sin.Name = "bt_sin";
            this.bt_sin.Size = new System.Drawing.Size(113, 102);
            this.bt_sin.TabIndex = 17;
            this.bt_sin.Text = "Sin";
            this.bt_sin.UseVisualStyleBackColor = true;
            this.bt_sin.Click += new System.EventHandler(this.bt_sin_Click);
            // 
            // bt_cos
            // 
            this.bt_cos.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cos.Location = new System.Drawing.Point(404, 390);
            this.bt_cos.Name = "bt_cos";
            this.bt_cos.Size = new System.Drawing.Size(113, 102);
            this.bt_cos.TabIndex = 18;
            this.bt_cos.Text = "Cos";
            this.bt_cos.UseVisualStyleBackColor = true;
            this.bt_cos.Click += new System.EventHandler(this.bt_cos_Click);
            // 
            // bt_tan
            // 
            this.bt_tan.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_tan.Location = new System.Drawing.Point(596, 390);
            this.bt_tan.Name = "bt_tan";
            this.bt_tan.Size = new System.Drawing.Size(113, 102);
            this.bt_tan.TabIndex = 19;
            this.bt_tan.Text = "Tan";
            this.bt_tan.UseVisualStyleBackColor = true;
            this.bt_tan.Click += new System.EventHandler(this.bt_tan_Click);
            // 
            // bt_xry
            // 
            this.bt_xry.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xry.Location = new System.Drawing.Point(27, 390);
            this.bt_xry.Name = "bt_xry";
            this.bt_xry.Size = new System.Drawing.Size(113, 102);
            this.bt_xry.TabIndex = 20;
            this.bt_xry.Text = "x^y";
            this.bt_xry.UseVisualStyleBackColor = true;
            this.bt_xry.Click += new System.EventHandler(this.bt_xry_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(649, 556);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "by Wesley Monte";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 581);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_xry);
            this.Controls.Add(this.bt_tan);
            this.Controls.Add(this.bt_cos);
            this.Controls.Add(this.bt_sin);
            this.Controls.Add(this.bt_clear);
            this.Controls.Add(this.bt_clear2);
            this.Controls.Add(this.bt_log);
            this.Controls.Add(this.bt_sqrt);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.lbl_result2);
            this.Controls.Add(this.lbl_num2);
            this.Controls.Add(this.bt_div);
            this.Controls.Add(this.bt_mult);
            this.Controls.Add(this.bt_minus);
            this.Controls.Add(this.bt_plus);
            this.Controls.Add(this.lbl_num1);
            this.Controls.Add(this.text_Num2);
            this.Controls.Add(this.text_Num1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculator 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_Num1;
        private System.Windows.Forms.Label lbl_num1;
        private System.Windows.Forms.TextBox text_Num2;
        private System.Windows.Forms.Button bt_plus;
        private System.Windows.Forms.Button bt_minus;
        private System.Windows.Forms.Button bt_mult;
        private System.Windows.Forms.Button bt_div;
        private System.Windows.Forms.Label lbl_num2;
        private System.Windows.Forms.Label lbl_result2;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.Button bt_sqrt;
        private System.Windows.Forms.Button bt_log;
        private System.Windows.Forms.Button bt_clear2;
        private System.Windows.Forms.Button bt_clear;
        private System.Windows.Forms.Button bt_sin;
        private System.Windows.Forms.Button bt_cos;
        private System.Windows.Forms.Button bt_tan;
        private System.Windows.Forms.Button bt_xry;
        private System.Windows.Forms.Label label1;
    }
}

